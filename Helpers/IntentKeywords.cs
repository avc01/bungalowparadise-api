namespace bungalowparadise_api.Helpers
{
    public static class IntentKeywords
    {
        public static readonly Dictionary<UserIntent, string[]> Keywords = new()
        {
            [UserIntent.BookingInquiry] =
            [
                "habitacion", "habitaciones", "reservé", "reservado", "reservaré",
                "disponible", "disponibilidad", "dispondré", "disponía",
                "precio", "precios", "tarifa", "tarifas", "costo", "costos", "cuesta", "costaba", "costará",
                "tipo de habitacion", "categoría", "suite", "cama", "camas", "sencilla", "doble", "triple", "lujo",
                "reservar", "reservando", "reservé", "reservaré",
                "reserva", "reservacion", "agendar", "agendé", "agendando", "check in", "check-in", "check-out", "entrada", "salida",
                "fecha", "fechas", "día", "días", "calendario", "agenda", "ocupacion", "ocupado", "ocupada",
                "room", "rooms", "available", "availability", "bed", "beds", "price", "cost", "rate",
                "book", "booking", "reservation", "dates", "calendar", "checkin", "checkout"
            ],

            [UserIntent.ReviewInquiry] =
            [
                "reseña", "reseñas", "opinion", "opiniones", "comentario", "comentarios", "comenté", "comentando",
                "calificacion", "valoracion", "valoré", "valorando", "puntaje", "puntuación", "experiencia", "vivencia",
                "recomendado", "recomiendo", "recomendé", "recomendaría",
                "review", "reviews", "feedback", "rating", "comment", "complaint",
                "queja", "quejé", "quejando", "testimonio", "testimony", "testimonial", "critica", "críticas"
            ],

            [UserIntent.HotelInfo] =
            [
                "hotel", "ubicacion", "ubicación", "ubicado", "ubicados", "estan" ,"están ubicados", "dónde queda", "dónde está",
                "direccion", "dirección", "lugar", "sitio", "localización", "cómo llegar",
                "empleados", "personal", "staff", "trabajadores", "equipo",
                "vision", "visión", "mision", "misión", "propósito", "objetivo",
                "historia", "historial", "origen", "años de servicio", "fundado", "fundación", "inició",
                "sostenibilidad", "ecológico", "ambiental", "responsable", "certificación", "CST",
                "política", "políticas", "reglas", "normas", "condiciones", "términos",
                "servicio al cliente", "atencion", "asistencia", "soporte",
                "contacto", "teléfono", "correo", "email", "whatsapp", "número",
                "desayuno", "wifi", "piscina", "spa", "restaurante", "comida", "alimentación", "lavandería", "actividades",
                "souvenir", "souvenirs", "bar", "tienda", "coworking", "transporte", "tours", "masajes", "servicio",
                "accesibilidad", "discapacidad", "acceso", "rampa", "rampla", "sensorial", "visual", "auditiva",
                "location", "history", "mission", "vision", "about", "staff", "rules", "policy", "contact", "phone",
                "hours", "help", "breakfast", "pool", "restaurant", "bar", "laundry", "spa", "tour", "gift", "store",
                "sustainability", "assistance", "accessibility", "disability", "wheelchair", "promotion", "promocion",
                "promociones", "offers", "ofertas", "deal", "discount", "servicios", "servicio"
            ]
        };
    }
}
