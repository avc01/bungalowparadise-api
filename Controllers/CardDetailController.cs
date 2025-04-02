using bungalowparadise_api.DbContext;
using bungalowparadise_api.Models;
using bungalowparadise_api.Models.DTOs;
using bungalowparadise_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace bungalowparadise_api.Controllers
{
    [Authorize(Roles = "Admin,User")]
    [Route("api/[controller]")]
    [ApiController]
    public class CardDetailController : ControllerBase
    {
        private readonly HotelDbContext _context;

        public CardDetailController(HotelDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDetail>>> GetCardDetails()
        {
            return await _context.CardDetails.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CardDetail>> GetCardDetail(int id)
        {
            var cardDetail = await _context.CardDetails.FindAsync(id);
            if (cardDetail == null)
            {
                return NotFound();
            }
            return cardDetail;
        }

        [HttpGet("user-card")]
        public async Task<ActionResult<CardDto>> GetCardDetailOfUser(int userId, bool masked = true)
        {
            var userCard = await GetCardDetailDtoOfUser(userId, masked);
            if (userCard == null)
                return NotFound();

            return Ok(userCard);
        }

        [HttpPost]
        public async Task<ActionResult<CardDetail>> CreateCardDetail(CardDetail cardDetail)
        {
            _context.CardDetails.Add(cardDetail);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCardDetail), new { id = cardDetail.Id }, cardDetail);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCardDetail(int id, CardDetail cardDetail)
        {
            if (id != cardDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(cardDetail).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardDetail(int id)
        {
            var cardDetail = await _context.CardDetails.FindAsync(id);
            if (cardDetail == null)
            {
                return NotFound();
            }

            _context.CardDetails.Remove(cardDetail);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("new-card")]
        public async Task<ActionResult<CardDto>> AddNewUserCard([Required, FromBody] NewCardDto newCard, [FromServices] CardValidatorService cardValidatorService)
        {
            var (isCardValid, _, cardError) = cardValidatorService.ValidateCard(newCard.CardNumber, newCard.ExpiryMonth, newCard.ExpiryYear, newCard.CVV);
            if (!isCardValid)
                return BadRequest(cardError);

            var cardToAdd = new CardDetail()
            {
                CardHolderName = newCard.CardHolder,
                CardCode = int.Parse(newCard.CVV),
                CardNumber = long.Parse(newCard.CardNumber.Replace(" ", "")),
                UserId = newCard.UserId,
                ExpiredDate = new DateTime(int.Parse(newCard.ExpiryYear),
                                          int.Parse(newCard.ExpiryMonth), 1),
            };

            if (await _context.CardDetails.AnyAsync(x => x.UserId == newCard.UserId))
            {
                cardToAdd.Id = newCard.OldCardId.GetValueOrDefault();

                _context.CardDetails.Update(cardToAdd);
            }
            else
            {
                await _context.CardDetails.AddAsync(cardToAdd);
            }

            await _context.SaveChangesAsync();

            var userCard = await GetCardDetailDtoOfUser(newCard.UserId);
            return Ok(userCard);
        }

        private async Task<CardDto?> GetCardDetailDtoOfUser(int userId, bool masked = true)
        {
            var cardDetail = await _context.CardDetails.AsNoTracking().SingleOrDefaultAsync(x => x.UserId == userId);

            if (cardDetail == null)
                return null;

            var cardNumber = cardDetail.CardNumber.ToString();

            var publicCardNumber = cardNumber;

            if (masked)
            {
                var first4 = cardNumber[..4];
                var last4 = cardNumber[^4..];
                var middleMask = string.Join(" ", Enumerable.Repeat("•", cardNumber.Length - 8));

                publicCardNumber = $"{first4} {middleMask} {last4}";
            }

            return new CardDto()
            {
                Id = cardDetail.Id.ToString(),
                CardHolder = cardDetail.CardHolderName,
                CardNumber = publicCardNumber,
                ExpiryMonth = cardDetail.ExpiredDate.Month.ToString("D2"),
                ExpiryYear = cardDetail.ExpiredDate.Year.ToString(),
                CardType = cardNumber switch
                {
                    _ when Regex.IsMatch(cardNumber, @"^4\d{12}(\d{3})?$") => "visa",
                    _ when Regex.IsMatch(cardNumber, @"^5[1-5]\d{14}$") => "mastercard",
                    _ when Regex.IsMatch(cardNumber, @"^3[47]\d{13}$") => "amex",
                    _ => string.Empty
                },
                CVV = masked ? string.Empty : cardDetail.CardCode.ToString(),
            };
        }
    }
}
