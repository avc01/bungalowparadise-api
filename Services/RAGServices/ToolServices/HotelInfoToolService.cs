using System.Text;

namespace bungalowparadise_api.Services.RAGServices.ToolServices
{
    public class HotelInfoToolService
    {
        public Task<string> GetHotelInfoContextAsync()
        {
            var builder = new StringBuilder();

            builder.AppendLine("Información institucional del Hotel Bungalow Paradise:");
            builder.AppendLine("------------------------------------------------------\n");

            builder.AppendLine("Nombre: Hotel Bungalow Paradise");
            builder.AppendLine("Ubicación: Playa Hermosa, Guanacaste, Costa Rica");
            builder.AppendLine("Años de servicio: Más de 12 años ofreciendo hospitalidad y confort");
            builder.AppendLine("Gerente general: Prof. Esteban Vega");
            builder.AppendLine("Empleados: 28 personas distribuidas en recepción, limpieza, cocina, mantenimiento y atención al cliente");

            builder.AppendLine("\n Misión:");
            builder.AppendLine("Brindar experiencias únicas y memorables a nuestros huéspedes, combinando comodidad, atención personalizada y conexión con la naturaleza en un entorno costarricense auténtico.");

            builder.AppendLine("\n Visión:");
            builder.AppendLine("Ser reconocidos como el hotel boutique líder en la región de Guanacaste por nuestra excelencia en servicio y compromiso con la sostenibilidad.");

            builder.AppendLine("\n Contacto:");
            builder.AppendLine("• Teléfono recepción: +506 2654-7890");
            builder.AppendLine("• Asistencia 24/7: +506 8888-1234");
            builder.AppendLine("• Correo electrónico: bungalowparadisecr@gmail.com");

            builder.AppendLine("\n Redes sociales:");
            builder.AppendLine("• Facebook: https://facebook.com/bungalowparadise");
            builder.AppendLine("• Instagram: https://instagram.com/bungalowparadise");
            builder.AppendLine("• WhatsApp: https://wa.me/50688881234");

            builder.AppendLine("\n Políticas del hotel:");
            builder.AppendLine("• Check-in: A partir de las 3:00 PM");
            builder.AppendLine("• Check-out: Antes de las 11:00 AM");
            builder.AppendLine("• Cancelaciones: Gratis hasta 48 horas antes del check-in");
            builder.AppendLine("• Política de mascotas: Se permiten mascotas pequeñas bajo previa solicitud");
            builder.AppendLine("• Niños: Bienvenidos. No se cobran cargos adicionales por menores de 6 años compartiendo cama");
            builder.AppendLine("• Estacionamiento: Gratuito para todos los huéspedes");
            builder.AppendLine("• Fumar: Prohibido fumar dentro de las habitaciones o espacios cerrados");

            builder.AppendLine("\n Accesibilidad:");
            builder.AppendLine("• Rutas accesibles en todas las áreas comunes");
            builder.AppendLine("• Habitaciones adaptadas para personas con movilidad reducida");
            builder.AppendLine("• Rampas de acceso y señalización visual en zonas clave");
            builder.AppendLine("• Personal capacitado para asistir a personas con discapacidad");

            builder.AppendLine("\n Compromiso con la sostenibilidad:");
            builder.AppendLine("• Uso de energía solar para calefacción de agua");
            builder.AppendLine("• Programa de reciclaje y reducción de plásticos");
            builder.AppendLine("• Colaboración con proveedores locales y orgánicos");
            builder.AppendLine("• Certificación CST Nivel 4 (Certificación para la Sostenibilidad Turística)");

            builder.AppendLine("\n Promociones vigentes:");
            builder.AppendLine(" 'Escapada de Verano': 15% de descuento en estadías de 3 noches o más durante abril y mayo.");
            builder.AppendLine(" 'Plan Familiar': Hospedaje gratis para niños menores de 10 años durante fines de semana.");
            builder.AppendLine(" 'Paquete Relax': Incluye masaje para 2 personas y desayuno continental todos los días.");
            builder.AppendLine(" 'Viaje de Negocios': 10% de descuento en habitaciones ejecutivas + acceso ilimitado a salas de reuniones.");
            builder.AppendLine(" 'Celebra tu cumpleaños': Noche gratis si reservas al menos 2 noches durante la semana de tu cumpleaños.");

            builder.AppendLine("\n Servicios adicionales:");
            builder.AppendLine(" Servicio de lavandería y planchado bajo solicitud");
            builder.AppendLine(" Alquiler de bicicletas y scooters para explorar los alrededores");
            builder.AppendLine(" Clases de yoga al amanecer en la terraza principal");
            builder.AppendLine(" Tours organizados: avistamiento de tortugas, paseos en catamarán, senderismo y canopy");
            builder.AppendLine(" Servicio a la habitación disponible de 7:00 AM a 10:00 PM");
            builder.AppendLine(" Transporte privado desde/hacia el Aeropuerto Internacional de Liberia");
            builder.AppendLine(" Área de coworking con Wi-Fi de alta velocidad y estaciones ergonómicas");
            builder.AppendLine(" Actividades infantiles supervisadas los fines de semana");
            builder.AppendLine(" Piscina temperada con bar húmedo y servicio de snacks");
            builder.AppendLine(" Tienda de souvenirs y productos locales en la recepción");

            return Task.FromResult(builder.ToString());
        }
    }
}
