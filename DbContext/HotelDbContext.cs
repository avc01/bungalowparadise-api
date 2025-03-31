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
                new User { Id = 1, Name = "John", LastName = "Doe", Email = "john@example.com", PasswordHash = "hashedpassword", Phone = "1234567890", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 2, Name = "Jane", LastName = "Smith", Email = "jane@example.com", PasswordHash = "hashedpassword", Phone = "9876543210", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 3, Name = "Michael", LastName = "Johnson", Email = "michael@example.com", PasswordHash = "hashedpassword", Phone = "5556667777", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 4, Name = "Lucía", LastName = "Gómez", Email = "lucia@example.com", PasswordHash = "hashedpassword", Phone = "1112223333", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 5, Name = "Carlos", LastName = "Ramírez", Email = "carlos@example.com", PasswordHash = "hashedpassword", Phone = "4445556666", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "Admin" },
                new User { Id = 6, Name = "Sofía", LastName = "Fernández", Email = "sofia@example.com", PasswordHash = "hashedpassword", Phone = "7778889999", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "User" },
                new User { Id = 7, Name = "Andrés", LastName = "Martínez", Email = "andres@example.com", PasswordHash = "hashedpassword", Phone = "2223334444", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Role = "Admin" }
            );

            modelBuilder.Entity<CardDetail>().HasData(
                new CardDetail { Id = 1, UserId = 1, ExpiredDate = DateTime.UtcNow.AddYears(2), CardNumber = 1234567812345678, CardCode = 123, CardHolderName = "John Doe" },
                new CardDetail { Id = 2, UserId = 2, ExpiredDate = DateTime.UtcNow.AddYears(3), CardNumber = 8765432187654321, CardCode = 456, CardHolderName = "Jane Smith" },
                new CardDetail { Id = 3, UserId = 4, ExpiredDate = DateTime.UtcNow.AddYears(4), CardNumber = 4321432143214321, CardCode = 789, CardHolderName = "Lucía Gómez" },
                new CardDetail { Id = 4, UserId = 5, ExpiredDate = DateTime.UtcNow.AddYears(1), CardNumber = 5678567856785678, CardCode = 321, CardHolderName = "Carlos Ramírez" }
            );

            modelBuilder.Entity<Notification>().HasData(
                new Notification { Id = 1, ReservationId = 1, Message = "Welcome to our service!", Status = "Unread", CreatedAt = DateTime.UtcNow },
                new Notification { Id = 2, ReservationId = 2, Message = "Your reservation has been confirmed!", Status = "Unread", CreatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<PasswordReset>().HasData(
                new PasswordReset { Id = 1, UserId = 1, ResetToken = "abcd1234", ExpiresAt = DateTime.UtcNow.AddHours(2) },
                new PasswordReset { Id = 2, UserId = 2, ResetToken = "efgh5678", ExpiresAt = DateTime.UtcNow.AddHours(2) }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "101", Type = "Single", Price = 100.00, Status = "Available", Description = "Acogedora habitación individual", Beds = 1, GuestsPerRoom = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "Deluxe Ocean View" },
                new Room { Id = 2, RoomNumber = "102", Type = "Double", Price = 150.00, Status = "Available", Description = "Amplia habitación doble", Beds = 2, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "Premium Garden Suite" },
                new Room { Id = 3, RoomNumber = "103", Type = "Suite", Price = 250.00, Status = "Available", Description = "Suite de lujo con vista al mar", Beds = 1, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 2, ImageUrl = "/placeholder.svg", Name = "Executive Ocean Suite" },
                new Room { Id = 4, RoomNumber = "104", Type = "Single", Price = 90.00, Status = "Occupied", Description = "Habitación individual económica", Beds = 1, GuestsPerRoom = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "Budget Single" },
                new Room { Id = 5, RoomNumber = "105", Type = "Double", Price = 160.00, Status = "Available", Description = "Habitación doble moderna con balcón", Beds = 2, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "City View Deluxe" },
                new Room { Id = 6, RoomNumber = "106", Type = "Suite", Price = 300.00, Status = "Available", Description = "Gran suite con jacuzzi privado", Beds = 1, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 2, ImageUrl = "/placeholder.svg", Name = "Presidential Suite" },
                new Room { Id = 7, RoomNumber = "107", Type = "Double", Price = 140.00, Status = "Under Maintenance", Description = "Cómoda habitación doble con escritorio", Beds = 2, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "Business Room" },
                new Room { Id = 8, RoomNumber = "108", Type = "Single", Price = 95.00, Status = "Available", Description = "Tranquila habitación individual cerca del jardín", Beds = 1, GuestsPerRoom = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "Garden Nook" },
                new Room { Id = 9, RoomNumber = "109", Type = "Double", Price = 170.00, Status = "Available", Description = "Habitación doble con vista parcial al mar", Beds = 2, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "Sunset Double" },
                new Room { Id = 10, RoomNumber = "110", Type = "Suite", Price = 280.00, Status = "Occupied", Description = "Suite de lujo con cocina incluida", Beds = 2, GuestsPerRoom = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 2, ImageUrl = "/placeholder.svg", Name = "Family Suite" },
                new Room { Id = 11, RoomNumber = "111", Type = "Single", Price = 105.00, Status = "Available", Description = "Habitación individual ideal para viajeros", Beds = 1, GuestsPerRoom = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "Traveler's Spot" },
                new Room { Id = 12, RoomNumber = "112", Type = "Double", Price = 155.00, Status = "Available", Description = "Habitación doble con cama tamaño king", Beds = 1, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Bathrooms = 1, ImageUrl = "/placeholder.svg", Name = "King Double Room" }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, UserId = 1, CheckIn = DateTime.UtcNow.AddDays(1), CheckOut = DateTime.UtcNow.AddDays(3), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 2, NumberOfAdults = 2, NumberOfKids = 0 },
                new Reservation { Id = 2, UserId = 2, CheckIn = DateTime.UtcNow.AddDays(5), CheckOut = DateTime.UtcNow.AddDays(8), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 3, NumberOfAdults = 2, NumberOfKids = 1 },
                new Reservation { Id = 3, UserId = 4, CheckIn = DateTime.UtcNow.AddDays(2), CheckOut = DateTime.UtcNow.AddDays(4), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 1, NumberOfAdults = 1, NumberOfKids = 0 },
                new Reservation { Id = 4, UserId = 5, CheckIn = DateTime.UtcNow.AddDays(10), CheckOut = DateTime.UtcNow.AddDays(15), Status = "Cancelled", CreatedAt = DateTime.UtcNow, NumberOfGuests = 4, NumberOfAdults = 2, NumberOfKids = 2 },
                new Reservation { Id = 5, UserId = 6, CheckIn = DateTime.UtcNow.AddDays(7), CheckOut = DateTime.UtcNow.AddDays(9), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 2, NumberOfAdults = 1, NumberOfKids = 1 },
                new Reservation { Id = 6, UserId = 7, CheckIn = DateTime.UtcNow.AddDays(3), CheckOut = DateTime.UtcNow.AddDays(6), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 2, NumberOfAdults = 2, NumberOfKids = 0 }
            );

            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = 1, ReservationId = 1, PaymentMethod = "Credit Card", Amount = 200.50, PaymentStatus = "Completed", TransactionId = "TX123456", CreatedAt = DateTime.UtcNow },
                new Payment { Id = 2, ReservationId = 2, PaymentMethod = "PayPal", Amount = 350.75, PaymentStatus = "Pending", TransactionId = "TX789012", CreatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, UserId = 1, Rating = 5, Comment = "¡Experiencia increíble!", CreatedAt = DateTime.UtcNow },
                new Review { Id = 2, UserId = 2, Rating = 4, Comment = "¡Estancia muy cómoda!", CreatedAt = DateTime.UtcNow },
                new Review { Id = 3, UserId = 4, Rating = 3, Comment = "Buena atención, pero la habitación era algo ruidosa.", CreatedAt = DateTime.UtcNow },
                new Review { Id = 4, UserId = 5, Rating = 5, Comment = "Excelente servicio y vista espectacular.", CreatedAt = DateTime.UtcNow },
                new Review { Id = 5, UserId = 6, Rating = 2, Comment = "No cumplió mis expectativas, había problemas con la limpieza.", CreatedAt = DateTime.UtcNow }
            );

            // Seeding Many-to-Many Relationship for ReservationRoom (Implicit Table)
            modelBuilder.Entity("ReservationRoom").HasData(
                new { ReservationsId = 1, RoomsId = 1 },
                new { ReservationsId = 1, RoomsId = 2 },
                new { ReservationsId = 2, RoomsId = 2 },
                new { ReservationsId = 3, RoomsId = 4 },
                new { ReservationsId = 4, RoomsId = 6 },
                new { ReservationsId = 4, RoomsId = 10 },
                new { ReservationsId = 5, RoomsId = 5 },
                new { ReservationsId = 6, RoomsId = 9 },
                new { ReservationsId = 6, RoomsId = 12 }
            );
        }
    }
}
