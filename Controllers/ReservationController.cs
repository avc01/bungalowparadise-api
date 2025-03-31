using bungalowparadise_api.DbContext;
using bungalowparadise_api.HostedServices;
using bungalowparadise_api.HostedServices.MailTemplates;
using bungalowparadise_api.Models;
using bungalowparadise_api.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace bungalowparadise_api.Controllers
{
    [Authorize(Roles = "Admin,User")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly HotelDbContext _context;
        private readonly EmailNotificationService _emailNotificationService;

        public ReservationController(HotelDbContext context, EmailNotificationService emailNotificationService)
        {
            _context = context;
            _emailNotificationService = emailNotificationService;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            return await _context.Reservations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return reservation;
        }

        [HttpPost]
        public async Task<ActionResult<Reservation>> CreateReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetReservation), new { id = reservation.Id }, reservation);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReservation(int id, Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return BadRequest();
            }

            _context.Entry(reservation).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("confirm-reservation")]
        public async Task<IActionResult> ConfirmReservation([FromBody] ReservationConfirmationDto reservationDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Datos de reservación inválidos.");

            // Validar tarjeta
            var (isCardValid, cardType, cardError) = ValidateCard(reservationDto.CardNumber, reservationDto.ExpiryMonth, reservationDto.ExpiryYear, reservationDto.CVV);
            if (!isCardValid)
                return BadRequest(cardError);

            // Verificar habitaciones
            var rooms = await _context.Rooms
                .Where(x => reservationDto.RoomIds.Contains(x.Id))
                .ToListAsync();

            if (rooms.Count != reservationDto.RoomIds.Count())
                return BadRequest("Una o más habitaciones seleccionadas no existen.");

            // Marcar habitaciones como ocupadas
            rooms.ForEach(r => r.Status = "Occupied");

            var checkIn = new DateTime(reservationDto.CheckIn.Year,
                                       reservationDto.CheckIn.Month,
                                       reservationDto.CheckIn.Day,
                                       12, 0, 0, DateTimeKind.Utc);

            var checkOut = new DateTime(reservationDto.CheckOut.Year,
                                        reservationDto.CheckOut.Month,
                                        reservationDto.CheckOut.Day,
                                        12, 0, 0, DateTimeKind.Utc);

            var newReservation = new Reservation()
            {
                CheckIn = checkIn,
                CheckOut = checkOut,
                Status = "Confirmed",
                CreatedAt = DateTime.UtcNow,
                UserId = reservationDto.UserId,
                NumberOfGuests = rooms.Sum(x => x.GuestsPerRoom),
                NumberOfAdults = 0,
                NumberOfKids = 0,
                Rooms = rooms,
            };

            if (!await _context.CardDetails.AnyAsync(x => x.UserId == reservationDto.UserId))
            {
                var newCard = new CardDetail()
                {
                    CardHolderName = reservationDto.CardName,
                    CardCode = int.Parse(reservationDto.CVV),
                    CardNumber = long.Parse(reservationDto.CardNumber.Replace(" ", "")),
                    UserId = reservationDto.UserId,
                    ExpiredDate = new DateTime(int.Parse(reservationDto.ExpiryYear),
                                          int.Parse(reservationDto.ExpiryMonth), 1),
                };

                await _context.CardDetails.AddAsync(newCard);
            }

            await _context.Reservations.AddAsync(newReservation);
            await _context.SaveChangesAsync();

            var newPayment = new Payment()
            {
                Amount = reservationDto.TotalAmount,
                PaymentMethod = cardType ?? "Card",
                PaymentStatus = "Pending",
                ReservationId = newReservation.Id,
            };

            await _context.Payments.AddAsync(newPayment);
            await _context.SaveChangesAsync();

            string reservationCode = $"BP-{newReservation.Id}";

            await _emailNotificationService.SendEmailAsync(
                reservationDto.UserEmail,
                ReceiptMailTemplate.GetReceiptTemplate(reservationDto, reservationCode),
                "Comprobante de Reservación - Bungalow Paradise");

            return Ok(new
            { 
                status = "Reservación confirmada exitosamente.", 
                reservationId = reservationCode,
                rooms = rooms.Count,
                amount = reservationDto.TotalAmount,
            });
        }

        private (bool IsValid, string? CardType, string? ErrorMessage) ValidateCard(string cardNumber, string expiryMonth, string expiryYear, string cvv)
        {
            cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            if (!Regex.IsMatch(cardNumber, @"^\d+$"))
                return (false, null, "El número de tarjeta debe contener solo dígitos.");

            string? cardType = cardNumber switch
            {
                _ when Regex.IsMatch(cardNumber, @"^4\d{12}(\d{3})?$") => "Visa",
                _ when Regex.IsMatch(cardNumber, @"^5[1-5]\d{14}$") => "MasterCard",
                _ when Regex.IsMatch(cardNumber, @"^3[47]\d{13}$") => "American Express",
                _ => null
            };

            if (cardType == null)
                return (false, null, "Tipo de tarjeta no válido. Aceptamos Visa, MasterCard y American Express.");

            if (!int.TryParse(expiryMonth, out int month) || month < 1 || month > 12)
                return (false, cardType, "El mes de expiración es inválido.");

            if (!int.TryParse(expiryYear, out int year) || year < DateTime.UtcNow.Year)
                return (false, cardType, "El año de expiración es inválido.");

            var expiryDate = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
            if (DateTime.UtcNow.Date > expiryDate)
                return (false, cardType, "La tarjeta está vencida.");

            if (!Regex.IsMatch(cvv, @"^\d+$"))
                return (false, cardType, "El CVV debe contener solo números.");

            int expectedCvvLength = cardType == "American Express" ? 4 : 3;
            if (cvv.Length != expectedCvvLength)
                return (false, cardType, $"Las tarjetas {cardType} requieren un CVV de {expectedCvvLength} dígitos.");

            return (true, cardType, null);
        }
    }
}
