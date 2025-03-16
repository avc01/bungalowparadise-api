using bungalowparadise_api.DbContext;
using bungalowparadise_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
