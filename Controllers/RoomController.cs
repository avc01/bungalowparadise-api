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
        public async Task<ActionResult<IEnumerable<GetRoomDto>>> GetRooms()
        {
            var roomsWithReservedDates = await _context.Rooms.AsNoTracking()
                                                             .Where(x => x.Status == "Available")
                                                             .Select(r => new 
                                                             {
                                                                r.Id,
                                                                r.RoomNumber,
                                                                r.Type,
                                                                r.Price,
                                                                r.Status,
                                                                r.Description,
                                                                r.Beds,
                                                                r.GuestsPerRoom,
                                                                r.Name,
                                                                r.ImageUrl,
                                                                r.Bathrooms,
                             
                                                                // Other room properties as needed
                                                                ReservedDateRanges = r.Reservations
                                                                    .Where(res => res.Status == "Confirmed")
                                                                    .Select(res => new List<DateTime> { res.CheckIn, res.CheckOut })
                                                                    .ToList()
                                                             })
                                                             .ToListAsync();

            return roomsWithReservedDates.Select(x => new GetRoomDto()
            {
                Id = x.Id,
                RoomNumber = x.RoomNumber,
                Type = x.Type,
                Price = x.Price,
                Status = x.Status,
                Description = x.Description,
                Beds = x.Beds,
                GuestsPerRoom = x.GuestsPerRoom,
                Name = x.Name,
                ImageUrl = x.ImageUrl?.Split(',') ?? [],
                Bathrooms = x.Bathrooms,
                ReservedDateRanges = x.ReservedDateRanges,
            }).OrderBy(x => x.Price).ToList();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin/rooms")]
        public async Task<ActionResult<IEnumerable<GetRoomDto>>> GetAllRooms()
        {
            var allRooms = await _context.Rooms.AsNoTracking()
                                               .ToListAsync();

            return allRooms.Select(x => new GetRoomDto()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price,
                ImageUrl = x.ImageUrl?.Split(',') ?? [],
                Type = x.Type,
                GuestsPerRoom = x.GuestsPerRoom,
                Bathrooms = x.Bathrooms,
                Status = x.Status,
                RoomNumber = x.RoomNumber,
                Beds = x.Beds,
                ReservedDateRanges = [],
            }).ToList();
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
        [HttpPut("admin/update")]
        public async Task<IActionResult> UpdateRoom([FromForm] EditRoomDto room, [FromServices] S3Service s3Service)
        {
            var existingRoom = await _context.Rooms.FindAsync(room.Id);
            if (existingRoom == null)
            {
                return NotFound();
            }

            // Update room fields
            existingRoom.Name = room.Name;
            existingRoom.RoomNumber = room.RoomNumber;
            existingRoom.Type = room.Type;
            existingRoom.Price = room.Price;
            existingRoom.Status = room.Status;
            existingRoom.Description = room.Description;
            existingRoom.Beds = room.Beds;
            existingRoom.Bathrooms = room.Bathrooms;
            existingRoom.GuestsPerRoom = room.GuestsPerRoom;
            existingRoom.UpdatedAt = DateTime.UtcNow;

            // If new images are uploaded, delete old ones and upload new ones
            if (room.Images != null && room.Images.Count > 0)
            {
                // 🔥 Delete old images
                if (!string.IsNullOrWhiteSpace(existingRoom.ImageUrl))
                {
                    var oldKeys = existingRoom.ImageUrl
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(url => new Uri(url.Trim()).AbsolutePath.TrimStart('/'))
                        .ToList();

                    await s3Service.DeleteFilesAsync(oldKeys);
                }

                // ✅ Upload new images
                var newUrls = await s3Service.UploadFilesAsync(room.Images, "rooms");
                existingRoom.ImageUrl = string.Join(",", newUrls);
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }


        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id, [FromServices] S3Service s3Service)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            // Parse image URLs into S3 keys
            var imageKeys = new List<string?>();

            if (!string.IsNullOrWhiteSpace(room.ImageUrl))
            {
                imageKeys = [.. room.ImageUrl
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(url =>
                    {
                        try
                        {
                            var uri = new Uri(url.Trim());
                            return uri.AbsolutePath.TrimStart('/'); // removes leading "/"
                        }
                        catch
                        {
                            return null;
                        }
                    })
                    .Where(key => !string.IsNullOrEmpty(key))];
            }

            if (imageKeys.Count > 0)
            {
                await s3Service.DeleteFilesAsync(imageKeys);
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("upload")]
        public async Task<IActionResult> UploadRoomWithImage(
            [FromForm] SaveRoomDto room, 
            [FromForm] List<IFormFile> images, 
            [FromServices] S3Service s3Service)
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
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            if (images != null && images.Count != 0)
            {
                var imageUrls = await s3Service.UploadFilesAsync(images, "rooms");
                roomToSave.ImageUrl = string.Join(",", imageUrls);
            }

            await _context.Rooms.AddAsync(roomToSave);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRoom), new { id = roomToSave.Id }, roomToSave);
        }

        [Authorize(Roles = "Admin, User")]
        [HttpGet("SearchRooms")]
        public async Task<ActionResult<IEnumerable<Room>>> SearchRooms
              (DateTime? checkIn,
              DateTime? checkOut,
               string RoomType,
               double? minPrice,
               double? maxPrice)
        {

            var query = _context.Rooms.AsQueryable();

            if (checkIn != null && checkOut != null)
            {

                query = query.Where(room => !room.Reservations.Any(reservation =>
                    reservation.Status != "Cancelled" && // Optional: ignore cancelled reservations
                    reservation.CheckIn < checkOut && checkIn < reservation.CheckOut));
            }

            if (!string.IsNullOrEmpty(RoomType))
            {
                query = query.Where(room => room.Type == RoomType);

            }

            if (minPrice.HasValue)
            {
                query = query.Where(room => room.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(room => room.Price <= maxPrice.Value);
            }

            var availableRooms = await query.ToListAsync();

            return availableRooms;
        }
    }
}
