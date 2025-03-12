using bungalowparadise_api.DbContext;
using bungalowparadise_api.HostedServices;
using bungalowparadise_api.HostedServices.MailTemplates;
using bungalowparadise_api.Models;
using bungalowparadise_api.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace bungalowparadise_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly HotelDbContext _context;
        private readonly EmailNotificationService _emailNotificationService;
        private readonly PasswordHasher<User> _passwordHasher;
        private readonly IConfiguration _config;

        public AuthController(
            HotelDbContext context, 
            EmailNotificationService emailNotificationService, 
            IConfiguration config)
        {
            _context = context;
            _emailNotificationService = emailNotificationService;
            _config = config;
            _passwordHasher = new PasswordHasher<User>();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
            {
                return BadRequest("Este correo ya existe");
            }

            var user = new User
            {
                Email = dto.Email,
                Name = dto.Name,
                LastName = dto.LastName,
                Phone = dto.Phone,
                PasswordHash = string.Empty,
            };

            user.PasswordHash = _passwordHasher.HashPassword(user, dto.Password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Usuario Registrado" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Email == dto.Email);
            if (user == null)
                return Unauthorized("Correo inválido");

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);
            if (result == PasswordVerificationResult.Failed)
                return Unauthorized("Contraseña inválida");

            var token = GenerateJwtToken(user);

            return Ok(new
            {
                token,
                user = new { user.Id, user.Email }
            });
        }

        [HttpPost("request-password-reset")]
        public async Task<IActionResult> RequestPasswordReset([FromBody] string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
                return BadRequest();

            var token = Guid.NewGuid().ToString("N")[..6];

            var passwordResetTry = new PasswordReset() 
            {
                ResetToken = token,
                UserId = user.Id,
                ExpiresAt = DateTime.UtcNow.AddMinutes(15),
            };

            await _context.PasswordResets.AddAsync(passwordResetTry);
            await _context.SaveChangesAsync();

            await _emailNotificationService.SendEmailAsync(user.Email, PasswordResetMailTemplate.GetPasswordResetTemplate(token, $"{user.Name} {user.LastName}"), "Código para Restablecer Contraseña");

            return Ok("Token enviado. Expira en 15 mins");
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordWithToken([FromBody] PasswordResetDto passwordResetDto)
        {
            var resetRequest = await _context.PasswordResets
                .FirstOrDefaultAsync(u => u.ResetToken == passwordResetDto.Token && u.ExpiresAt > DateTime.UtcNow);

            if (resetRequest == null)
                return BadRequest("Token inválido o expirado.");

            var user = await _context.Users.FindAsync(resetRequest.UserId);

            var passwordHasher = new PasswordHasher<User>();

            // Actualizamos contraseña
            user.PasswordHash = passwordHasher.HashPassword(user, passwordResetDto.NewPassword);

            await _context.SaveChangesAsync();

            return Ok("Contraseña actualizada correctamente.");
        }

        [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> Me()
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
                return Unauthorized();

            return Ok(new { user.Id, user.Email });
        }

        private string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
