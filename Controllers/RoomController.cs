using bungalowparadise_api.DbContext;
using bungalowparadise_api.Models;
using bungalowparadise_api.Models.DTOs;
using bungalowparadise_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bungalowparadise_api.Controllers
{
    [Authorize(Roles = "Admin,User")]
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly HotelDbContext _context;

        public RoomController(HotelDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            var rooms = await _context.Rooms.ToListAsync();

            return rooms.OrderBy(x => x.Price).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return room;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<Room>> CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRoom), new { id = room.Id }, room);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("upload")]
        public async Task<IActionResult> UploadRoomWithImage([FromForm] RoomDto room, IFormFile image, [FromServices] S3Service s3Service)
        {
            var roomToSave = new Room() 
            { 
                Description = room.Description,
                Name = room.Name,
                RoomNumber = room.RoomNumber,
                Status = room.Status,
                Type = room.Type,
                Bathrooms = room.Bathrooms,
                Beds = room.Beds,
                GuestsPerRoom = room.GuestsPerRoom,
                Price = room.Price,
            };

            if (image != null)
            {
                var imageUrl = await s3Service.UploadFileAsync(image, "rooms");
                roomToSave.ImageUrl = imageUrl;
            }

            roomToSave.CreatedAt = DateTime.UtcNow;
            roomToSave.UpdatedAt = DateTime.UtcNow;

            await _context.Rooms.AddAsync(roomToSave);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRoom), new { id = roomToSave.Id }, roomToSave);
        }
    }
}
