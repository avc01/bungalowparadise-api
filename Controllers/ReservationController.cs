using bungalowparadise_api.DbContext;
using bungalowparadise_api.HostedServices;
using bungalowparadise_api.HostedServices.MailTemplates;
using bungalowparadise_api.Models;
using bungalowparadise_api.Models.DTOs;
using bungalowparadise_api.Services;
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
        public async Task<IActionResult> ConfirmReservation([FromBody] ReservationConfirmationDto reservationDto, [FromServices] CardValidatorService cardValidatorService)
        {
            if (!ModelState.IsValid)
                return BadRequest("Datos de reservación inválidos.");

            // Validar tarjeta
            var (isCardValid, cardType, cardError) = cardValidatorService.ValidateCard(reservationDto.CardNumber, reservationDto.ExpiryMonth, reservationDto.ExpiryYear, reservationDto.CVV);
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
    }
}
