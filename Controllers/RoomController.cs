﻿using bungalowparadise_api.DbContext;
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
