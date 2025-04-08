using bungalowparadise_api.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace bungalowparadise_api.Services.RAGServices.ToolServices
{
    public class BookingToolService
    {
        private readonly HotelDbContext _db;

        public BookingToolService(HotelDbContext db)
        {
            _db = db;
        }

        public async Task<string> GetBookingContextAsync()
        {
            var rooms = await _db.Rooms
                .Include(r => r.Reservations)
                .OrderBy(r => r.Price)
                .ToListAsync();

            if (!rooms.Any())
                return "Actualmente no hay habitaciones registradas.";

            var builder = new StringBuilder();
            builder.AppendLine("Información de habitaciones del hotel Bungalow Paradise:");
            builder.AppendLine("--------------------------------------------------------");

            foreach (var room in rooms)
            {
                builder.AppendLine($"\n📌 {room.Name} (#{room.RoomNumber})");
                builder.AppendLine($"• Tipo: {room.Type}");
                builder.AppendLine($"• Capacidad: {room.GuestsPerRoom} huéspedes, {room.Beds} cama(s), {room.Bathrooms} baño(s)");
                builder.AppendLine($"• Precio por noche: ${room.Price}");
                builder.AppendLine($"• Estado: {(room.Status == "Available" ? "Disponible" : "No disponible")}");
                builder.AppendLine($"• Descripción: {room.Description}");

                // 🔄 Fechas de reserva asociadas
                if (room.Reservations != null && room.Reservations.Any())
                {
                    var activeBookings = room.Reservations
                        .OrderBy(r => r.CheckIn)
                        .Select(r => $"  DEL {r.CheckIn:dd MMM yyyy} AL {r.CheckOut:dd MMM yyyy} RESERVADA!");

                    if (activeBookings.Any())
                    {
                        builder.AppendLine("• Fechas RESERVADAS!:");
                        foreach (var range in activeBookings)
                            builder.AppendLine(range);
                    }
                }
            }

            return builder.ToString();
        }
    }
}
