namespace bungalowparadise_api.DbContext
{
    using bungalowparadise_api.Models;
    using Microsoft.EntityFrameworkCore;

    public class HotelDbContext : DbContext 
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PasswordReset> PasswordResets { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CardDetail> CardDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ----- Users -----
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.HasIndex(u => u.Email).IsUnique();
                entity.Property(u => u.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
                entity.Property(u => u.UpdatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
                entity.Property(u => u.Role)
                      .HasDefaultValue("User");
            });

            // ----- PasswordResets -----
            modelBuilder.Entity<PasswordReset>(entity =>
            {
                entity.HasKey(pr => pr.Id);
                entity.Property(pr => pr.ResetToken)
                      .IsRequired();
                entity.HasIndex(pr => pr.ResetToken).IsUnique();

                // Relation: PasswordReset -> User
                entity.HasOne(pr => pr.User)
                      .WithMany(u => u.PasswordResets)
                      .HasForeignKey(pr => pr.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ----- Rooms -----
            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(r => r.Id);

                entity.Property(r => r.RoomNumber).IsRequired();
                entity.HasIndex(r => r.RoomNumber).IsUnique();
                entity.Property(r => r.Type).IsRequired();
                entity.Property(r => r.Status).HasDefaultValue("Available");
                entity.Property(r => r.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
                entity.Property(r => r.UpdatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");
            });

            // ----- Reservations -----
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Status).HasDefaultValue("Pending");
                entity.Property(r => r.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                // Relation: Reservation -> User
                entity.HasOne(r => r.User)
                      .WithMany(u => u.Reservations)
                      .HasForeignKey(r => r.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ----- Payments -----
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.PaymentMethod).IsRequired();
                entity.Property(p => p.PaymentStatus).HasDefaultValue("Pending");
                entity.Property(p => p.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                // Relation: Payment -> Reservation
                entity.HasOne(p => p.Reservation)
                      .WithMany(r => r.Payments)
                      .HasForeignKey(p => p.ReservationId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ----- Notifications -----
            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Status).HasDefaultValue("Unread");
                entity.Property(n => n.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                // Relation: Notification -> Reservation
                entity.HasOne(n => n.Reservation)
                      .WithMany(u => u.Notifications)
                      .HasForeignKey(n => n.ReservationId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ----- Reviews -----
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.Property(r => r.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                // Relation: Review -> User
                entity.HasOne(r => r.User)
                      .WithMany(u => u.Reviews)
                      .HasForeignKey(r => r.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ----- CardDetails -----
            modelBuilder.Entity<CardDetail>(entity =>
            {
                entity.HasKey(r => r.Id);

                // Relation: CardDetail -> User
                entity.HasOne(r => r.User)
                      .WithOne(u => u.CardDetail)
                      .HasForeignKey<CardDetail>(r => r.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // DATA SEEDING/MOCK PARA NUESTRAS TABLAS!

            modelBuilder.Entity<User>().HasData(
                new User { Id = 8, Name = "Ana", LastName = "Morales", Email = "ana@example.com", PasswordHash = "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", Phone = "88888888", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 9, Name = "Luis", LastName = "Castro", Email = "luis@example.com", PasswordHash = "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", Phone = "77777777", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 10, Name = "Esteban", LastName = "Zamora", Email = "esteban@example.com", PasswordHash = "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", Phone = "66666666", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 11, Name = "Valeria", LastName = "Jiménez", Email = "valeria@example.com", PasswordHash = "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", Phone = "99999999", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 12, Name = "David", LastName = "Rojas", Email = "david@example.com", PasswordHash = "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", Phone = "55555555", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 13, RoomNumber = "201", Type = "Double", Price = 180.00, Status = "Available", Description = "Habitación con vista a la montaña", Beds = 2, GuestsPerRoom = 2, Bathrooms = 1, Name = "Mountain View Room", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 14, RoomNumber = "202", Type = "Single", Price = 110.00, Status = "Available", Description = "Individual con escritorio y buena iluminación", Beds = 1, GuestsPerRoom = 1, Bathrooms = 1, Name = "Work Pod", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 15, RoomNumber = "203", Type = "Suite", Price = 320.00, Status = "Available", Description = "Suite con terraza privada y bar", Beds = 1, GuestsPerRoom = 2, Bathrooms = 2, Name = "Sunset Suite", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 16, RoomNumber = "204", Type = "Double", Price = 145.00, Status = "Available", Description = "Moderna con acceso a piscina", Beds = 2, GuestsPerRoom = 2, Bathrooms = 1, Name = "Poolside Double", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 17, RoomNumber = "205", Type = "Single", Price = 95.00, Status = "Available", Description = "Compacta y económica", Beds = 1, GuestsPerRoom = 1, Bathrooms = 1, Name = "Traveler Basic", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 18, RoomNumber = "206", Type = "Double", Price = 160.00, Status = "Maintenance", Description = "En remodelación con nueva decoración", Beds = 2, GuestsPerRoom = 2, Bathrooms = 1, Name = "Renovation Suite", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 19, RoomNumber = "207", Type = "Suite", Price = 290.00, Status = "Available", Description = "Suite con minibar y jacuzzi", Beds = 1, GuestsPerRoom = 2, Bathrooms = 2, Name = "Luxury Escape", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 20, RoomNumber = "208", Type = "Double", Price = 170.00, Status = "Available", Description = "Ideal para familias pequeñas", Beds = 2, GuestsPerRoom = 3, Bathrooms = 1, Name = "Family Room", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 21, RoomNumber = "209", Type = "Suite", Price = 330.00, Status = "Available", Description = "Suite frente al mar con cama king", Beds = 1, GuestsPerRoom = 2, Bathrooms = 2, Name = "Oceanfront Suite", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 22, RoomNumber = "210", Type = "Double", Price = 165.00, Status = "Available", Description = "Vista panorámica al atardecer", Beds = 2, GuestsPerRoom = 2, Bathrooms = 1, Name = "Sunset View Double", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 23, RoomNumber = "211", Type = "Single", Price = 100.00, Status = "Available", Description = "Perfecta para estancias cortas", Beds = 1, GuestsPerRoom = 1, Bathrooms = 1, Name = "Express Stay", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 24, RoomNumber = "212", Type = "Double", Price = 175.00, Status = "Available", Description = "Moderna con balcón privado", Beds = 2, GuestsPerRoom = 2, Bathrooms = 1, Name = "Balcony Room", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 25, RoomNumber = "213", Type = "Suite", Price = 350.00, Status = "Available", Description = "Suite presidencial con vista 360°", Beds = 2, GuestsPerRoom = 3, Bathrooms = 2, Name = "Panoramic Suite", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 26, RoomNumber = "214", Type = "Single", Price = 98.00, Status = "Available", Description = "Con acceso rápido al lobby", Beds = 1, GuestsPerRoom = 1, Bathrooms = 1, Name = "Lobby Quickstay", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 27, RoomNumber = "215", Type = "Double", Price = 150.00, Status = "Available", Description = "Decoración tropical y luminosa", Beds = 2, GuestsPerRoom = 2, Bathrooms = 1, Name = "Tropical Vibes Room", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 28, RoomNumber = "216", Type = "Suite", Price = 310.00, Status = "Available", Description = "Suite premium con doble ambiente", Beds = 2, GuestsPerRoom = 4, Bathrooms = 2, Name = "Split Suite", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 7, UserId = 8, CheckIn = DateTime.UtcNow.AddDays(1), CheckOut = DateTime.UtcNow.AddDays(2), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 1, NumberOfAdults = 1, NumberOfKids = 0 },
                new Reservation { Id = 8, UserId = 9, CheckIn = DateTime.UtcNow.AddDays(3), CheckOut = DateTime.UtcNow.AddDays(6), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 3, NumberOfAdults = 2, NumberOfKids = 1 },
                new Reservation { Id = 9, UserId = 10, CheckIn = DateTime.UtcNow.AddDays(7), CheckOut = DateTime.UtcNow.AddDays(10), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 2, NumberOfAdults = 2, NumberOfKids = 0 }
            );

            modelBuilder.Entity("ReservationRoom").HasData(
                new { ReservationsId = 7, RoomsId = 13 },
                new { ReservationsId = 8, RoomsId = 14 },
                new { ReservationsId = 8, RoomsId = 20 },
                new { ReservationsId = 9, RoomsId = 15 }
            );

            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = 3, ReservationId = 7, PaymentMethod = "American Express", Amount = 180.00, PaymentStatus = "Pending", TransactionId = "TX000777", CreatedAt = DateTime.UtcNow },
                new Payment { Id = 4, ReservationId = 9, PaymentMethod = "American Express", Amount = 320.00, PaymentStatus = "Pending", TransactionId = "TX000888", CreatedAt = DateTime.UtcNow },
                new Payment { Id = 5, ReservationId = 8, PaymentMethod = "American Express", Amount = 320.00, PaymentStatus = "Pending", TransactionId = "TX000838", CreatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 6, UserId = 8, Rating = 4, Comment = "Buen lugar para relajarse.", CreatedAt = DateTime.UtcNow },
                new Review { Id = 7, UserId = 9, Rating = 5, Comment = "Muy recomendado para vacaciones.", CreatedAt = DateTime.UtcNow },
                new Review { Id = 8, UserId = 10, Rating = 3, Comment = "Podría mejorar el servicio.", CreatedAt = DateTime.UtcNow }
            );

            //modelBuilder.Entity<Notification>().HasData(
            //    new Notification { Id = 3, ReservationId = 7, Message = "Gracias por reservar con nosotros.", Status = "Unread", CreatedAt = DateTime.UtcNow },
            //    new Notification { Id = 4, ReservationId = 9, Message = "Tu pago ha sido recibido.", Status = "Unread", CreatedAt = DateTime.UtcNow }
            //);

            modelBuilder.Entity<CardDetail>().HasData(
                new CardDetail { Id = 5, UserId = 8, ExpiredDate = DateTime.UtcNow.AddYears(3), CardNumber = 1234567890120001, CardCode = 123, CardHolderName = "Ana Morales" },
                new CardDetail { Id = 6, UserId = 9, ExpiredDate = DateTime.UtcNow.AddYears(2), CardNumber = 1234567890120002, CardCode = 321, CardHolderName = "Luis Castro" },
                new CardDetail { Id = 7, UserId = 10, ExpiredDate = DateTime.UtcNow.AddYears(4), CardNumber = 1234567890120003, CardCode = 456, CardHolderName = "Esteban Zamora" },
                new CardDetail { Id = 8, UserId = 12, ExpiredDate = DateTime.UtcNow.AddYears(1), CardNumber = 1234567890120004, CardCode = 654, CardHolderName = "David Rojas" }
            );
        }
    }
}
