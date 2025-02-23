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
        public DbSet<ReservationRoom> ReservationRooms { get; set; }

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

            // ----- ReservationRooms -----
            modelBuilder.Entity<ReservationRoom>()
                        .HasKey(rr => new { rr.ReservationId, rr.RoomId });

            modelBuilder.Entity<ReservationRoom>()
                        .HasOne(rr => rr.Reservation)
                        .WithMany(r => r.ReservationRooms)
                        .HasForeignKey(rr => rr.ReservationId);

            modelBuilder.Entity<ReservationRoom>()
                        .HasOne(rr => rr.Room)
                        .WithMany(r => r.ReservationRooms)
                        .HasForeignKey(rr => rr.RoomId);

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

                // Relation: Notification -> User
                entity.HasOne(n => n.User)
                      .WithMany(u => u.Notifications)
                      .HasForeignKey(n => n.UserId)
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

                // Relation: Review -> Room
                entity.HasOne(r => r.Room)
                      .WithMany(rm => rm.Reviews)
                      .HasForeignKey(r => r.RoomId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
