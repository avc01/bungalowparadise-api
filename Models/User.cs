﻿namespace bungalowparadise_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation property
        public ICollection<PasswordReset>? PasswordResets { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<Notification>? Notifications { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
