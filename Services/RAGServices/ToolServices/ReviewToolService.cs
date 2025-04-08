using bungalowparadise_api.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace bungalowparadise_api.Services.RAGServices.ToolServices
{
    public class ReviewToolService
    {
        private readonly HotelDbContext _db;

        public ReviewToolService(HotelDbContext db)
        {
            _db = db;
        }

        public async Task<string> GetReviewsContextAsync()
        {
            var reviews = await _db.Reviews
                .Include(r => r.User)
                .OrderByDescending(r => r.CreatedAt)
                .Take(10)
                .ToListAsync();

            if (!reviews.Any())
                return "No hay reseñas disponibles en este momento.";

            var builder = new StringBuilder();
            builder.AppendLine("Últimas reseñas de huéspedes del hotel Bungalow Paradise:");
            builder.AppendLine("----------------------------------------------------------");

            foreach (var review in reviews)
            {
                var username = review.User?.Name ?? "Usuario anónimo";
                builder.AppendLine($"\n🧾 Reseña por {username} ({review.CreatedAt:dd MMM yyyy}):");
                builder.AppendLine($"• Calificación: {new string('⭐', review.Rating)} ({review.Rating}/5)");
                builder.AppendLine($"• Comentario: \"{review.Comment}\"");
            }

            return builder.ToString();
        }
    }
}
