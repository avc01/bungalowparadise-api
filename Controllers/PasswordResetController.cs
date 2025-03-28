﻿using bungalowparadise_api.DbContext;
using bungalowparadise_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bungalowparadise_api.Controllers
{
    [Authorize(Roles = "Admin,User")]
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordResetController : ControllerBase
    {
        private readonly HotelDbContext _context;

        public PasswordResetController(HotelDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PasswordReset>>> GetPasswordResets()
        {
            return await _context.PasswordResets.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PasswordReset>> GetPasswordReset(int id)
        {
            var passwordReset = await _context.PasswordResets.FindAsync(id);
            if (passwordReset == null)
            {
                return NotFound();
            }
            return passwordReset;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<PasswordReset>> CreatePasswordReset(PasswordReset passwordReset)
        {
            _context.PasswordResets.Add(passwordReset);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPasswordReset), new { id = passwordReset.Id }, passwordReset);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePasswordReset(int id, PasswordReset passwordReset)
        {
            if (id != passwordReset.Id)
            {
                return BadRequest();
            }

            _context.Entry(passwordReset).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePasswordReset(int id)
        {
            var passwordReset = await _context.PasswordResets.FindAsync(id);
            if (passwordReset == null)
            {
                return NotFound();
            }

            _context.PasswordResets.Remove(passwordReset);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
