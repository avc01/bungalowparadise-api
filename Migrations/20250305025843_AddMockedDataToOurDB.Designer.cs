﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bungalowparadise_api.DbContext;

#nullable disable

namespace bungalowparadise_api.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20250305025843_AddMockedDataToOurDB")]
    partial class AddMockedDataToOurDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ReservationRoom", b =>
                {
                    b.Property<int>("ReservationsId")
                        .HasColumnType("int");

                    b.Property<int>("RoomsId")
                        .HasColumnType("int");

                    b.HasKey("ReservationsId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("ReservationRoom");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.CardDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardCode")
                        .HasColumnType("int");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("CardNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CardDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardCode = 123,
                            CardHolderName = "John Doe",
                            CardNumber = 1234567812345678L,
                            ExpiredDate = new DateTime(2027, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3446),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CardCode = 456,
                            CardHolderName = "Jane Smith",
                            CardNumber = 8765432187654321L,
                            ExpiredDate = new DateTime(2028, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3454),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Unread");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3473),
                            Message = "Welcome to our service!",
                            Status = "Unread",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3474),
                            Message = "Your reservation has been confirmed!",
                            Status = "Unread",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("bungalowparadise_api.Models.PasswordReset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpiresAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ResetToken")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResetToken")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("PasswordResets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpiresAt = new DateTime(2025, 3, 5, 4, 58, 43, 177, DateTimeKind.Utc).AddTicks(3493),
                            ResetToken = "abcd1234",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExpiresAt = new DateTime(2025, 3, 5, 4, 58, 43, 177, DateTimeKind.Utc).AddTicks(3498),
                            ResetToken = "efgh5678",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Pending");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 200.5,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3561),
                            PaymentMethod = "Credit Card",
                            PaymentStatus = "Completed",
                            ReservationId = 1,
                            TransactionId = "TX123456"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 350.75,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3562),
                            PaymentMethod = "PayPal",
                            PaymentStatus = "Pending",
                            ReservationId = 2,
                            TransactionId = "TX789012"
                        });
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.Property<int>("NumberOfAdults")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfKids")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Pending");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CheckIn = new DateTime(2025, 3, 6, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3538),
                            CheckOut = new DateTime(2025, 3, 8, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3540),
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3541),
                            NumberOfAdults = 2,
                            NumberOfGuests = 2,
                            NumberOfKids = 0,
                            Status = "Confirmed",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CheckIn = new DateTime(2025, 3, 10, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543),
                            CheckOut = new DateTime(2025, 3, 13, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543),
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543),
                            NumberOfAdults = 2,
                            NumberOfGuests = 3,
                            NumberOfKids = 1,
                            Status = "Pending",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Amazing experience!",
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3585),
                            Rating = 5,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Very comfortable stay!",
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3587),
                            Rating = 4,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Beds")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GuestsPerRoom")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Available");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.HasKey("Id");

                    b.HasIndex("RoomNumber")
                        .IsUnique();

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Beds = 1,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3517),
                            Description = "Cozy single room",
                            GuestsPerRoom = 1,
                            Price = 100.0,
                            RoomNumber = "101",
                            Status = "Available",
                            Type = "Single",
                            UpdatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3518)
                        },
                        new
                        {
                            Id = 2,
                            Beds = 2,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3519),
                            Description = "Spacious double room",
                            GuestsPerRoom = 2,
                            Price = 150.0,
                            RoomNumber = "102",
                            Status = "Available",
                            Type = "Double",
                            UpdatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3520)
                        });
                });

            modelBuilder.Entity("bungalowparadise_api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(6)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3343),
                            Email = "john@example.com",
                            LastName = "Doe",
                            Name = "John",
                            PasswordHash = "hashedpassword",
                            Phone = "1234567890",
                            UpdatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3344)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3346),
                            Email = "jane@example.com",
                            LastName = "Smith",
                            Name = "Jane",
                            PasswordHash = "hashedpassword",
                            Phone = "9876543210",
                            UpdatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3346)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3347),
                            Email = "michael@example.com",
                            LastName = "Johnson",
                            Name = "Michael",
                            PasswordHash = "hashedpassword",
                            Phone = "5556667777",
                            UpdatedAt = new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3348)
                        });
                });

            modelBuilder.Entity("ReservationRoom", b =>
                {
                    b.HasOne("bungalowparadise_api.Models.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bungalowparadise_api.Models.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bungalowparadise_api.Models.CardDetail", b =>
                {
                    b.HasOne("bungalowparadise_api.Models.User", "User")
                        .WithOne("CardDetail")
                        .HasForeignKey("bungalowparadise_api.Models.CardDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Notification", b =>
                {
                    b.HasOne("bungalowparadise_api.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.PasswordReset", b =>
                {
                    b.HasOne("bungalowparadise_api.Models.User", "User")
                        .WithMany("PasswordResets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Payment", b =>
                {
                    b.HasOne("bungalowparadise_api.Models.Reservation", "Reservation")
                        .WithMany("Payments")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Reservation", b =>
                {
                    b.HasOne("bungalowparadise_api.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Review", b =>
                {
                    b.HasOne("bungalowparadise_api.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.Reservation", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("bungalowparadise_api.Models.User", b =>
                {
                    b.Navigation("CardDetail");

                    b.Navigation("Notifications");

                    b.Navigation("PasswordResets");

                    b.Navigation("Reservations");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
