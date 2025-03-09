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
                entity.Property(p => p.TransactionId).IsRequired();
                entity.HasIndex(p => p.TransactionId).IsUnique();
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
               new User { Id = 1, Name = "John", LastName = "Doe", Email = "john@example.com", PasswordHash = "hashedpassword", Phone = "1234567890", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new User { Id = 2, Name = "Jane", LastName = "Smith", Email = "jane@example.com", PasswordHash = "hashedpassword", Phone = "9876543210", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new User { Id = 3, Name = "Michael", LastName = "Johnson", Email = "michael@example.com", PasswordHash = "hashedpassword", Phone = "5556667777", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<CardDetail>().HasData(
                new CardDetail { Id = 1, UserId = 1, ExpiredDate = DateTime.UtcNow.AddYears(2), CardNumber = 1234567812345678, CardCode = 123, CardHolderName = "John Doe" },
                new CardDetail { Id = 2, UserId = 2, ExpiredDate = DateTime.UtcNow.AddYears(3), CardNumber = 8765432187654321, CardCode = 456, CardHolderName = "Jane Smith" }
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
                new Room { Id = 1, RoomNumber = "101", Type = "Single", Price = 100.00, Status = "Available", Description = "Cozy single room", Beds = 1, GuestsPerRoom = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Room { Id = 2, RoomNumber = "102", Type = "Double", Price = 150.00, Status = "Available", Description = "Spacious double room", Beds = 2, GuestsPerRoom = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, UserId = 1, CheckIn = DateTime.UtcNow.AddDays(1), CheckOut = DateTime.UtcNow.AddDays(3), Status = "Confirmed", CreatedAt = DateTime.UtcNow, NumberOfGuests = 2, NumberOfAdults = 2, NumberOfKids = 0 },
                new Reservation { Id = 2, UserId = 2, CheckIn = DateTime.UtcNow.AddDays(5), CheckOut = DateTime.UtcNow.AddDays(8), Status = "Pending", CreatedAt = DateTime.UtcNow, NumberOfGuests = 3, NumberOfAdults = 2, NumberOfKids = 1 }
            );

            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = 1, ReservationId = 1, PaymentMethod = "Credit Card", Amount = 200.50, PaymentStatus = "Completed", TransactionId = "TX123456", CreatedAt = DateTime.UtcNow },
                new Payment { Id = 2, ReservationId = 2, PaymentMethod = "PayPal", Amount = 350.75, PaymentStatus = "Pending", TransactionId = "TX789012", CreatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review { Id = 1, UserId = 1, Rating = 5, Comment = "Amazing experience!", CreatedAt = DateTime.UtcNow },
                new Review { Id = 2, UserId = 2, Rating = 4, Comment = "Very comfortable stay!", CreatedAt = DateTime.UtcNow }
            );

            // Seeding Many-to-Many Relationship for ReservationRoom (Implicit Table)
            modelBuilder.Entity("ReservationRoom").HasData(
                new { ReservationsId = 1, RoomsId = 1 },
                new { ReservationsId = 1, RoomsId = 2 },
                new { ReservationsId = 2, RoomsId = 2 }
            );
        }
    }
}
