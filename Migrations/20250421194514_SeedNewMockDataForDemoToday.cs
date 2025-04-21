using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewMockDataForDemoToday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Bathrooms", "Beds", "CreatedAt", "Description", "GuestsPerRoom", "ImageUrl", "Name", "Price", "RoomNumber", "Status", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 13, 1, 2, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9008), "Habitación con vista a la montaña", 2, null, "Mountain View Room", 180.0, "201", "Available", "Double", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9008) },
                    { 14, 1, 1, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9010), "Individual con escritorio y buena iluminación", 1, null, "Work Pod", 110.0, "202", "Available", "Single", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9010) },
                    { 15, 2, 1, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9012), "Suite con terraza privada y bar", 2, null, "Sunset Suite", 320.0, "203", "Available", "Suite", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9012) },
                    { 16, 1, 2, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9014), "Moderna con acceso a piscina", 2, null, "Poolside Double", 145.0, "204", "Available", "Double", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9014) },
                    { 17, 1, 1, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9015), "Compacta y económica", 1, null, "Traveler Basic", 95.0, "205", "Available", "Single", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9016) },
                    { 18, 1, 2, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9017), "En remodelación con nueva decoración", 2, null, "Renovation Suite", 160.0, "206", "Maintenance", "Double", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9017) },
                    { 19, 2, 1, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9019), "Suite con minibar y jacuzzi", 2, null, "Luxury Escape", 290.0, "207", "Available", "Suite", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9019) },
                    { 20, 1, 2, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9020), "Ideal para familias pequeñas", 3, null, "Family Room", 170.0, "208", "Available", "Double", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9020) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "LastName", "Name", "PasswordHash", "Phone", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 8, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8886), "ana@example.com", "Morales", "Ana", "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", "88888888", "User", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8887) },
                    { 9, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8889), "luis@example.com", "Castro", "Luis", "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", "77777777", "User", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8889) },
                    { 10, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8890), "esteban@example.com", "Zamora", "Esteban", "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", "66666666", "User", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8891) },
                    { 11, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8892), "valeria@example.com", "Jiménez", "Valeria", "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", "99999999", "User", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8892) },
                    { 12, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8893), "david@example.com", "Rojas", "David", "$2b$12$pkJWEKnH.XsPx.coq8LDn.DR7CiOf92.Y0kJdoeggqP6qG..T8qDW", "55555555", "User", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8894) }
                });

            migrationBuilder.InsertData(
                table: "CardDetails",
                columns: new[] { "Id", "CardCode", "CardHolderName", "CardNumber", "ExpiredDate", "UserId" },
                values: new object[,]
                {
                    { 5, 123, "Ana Morales", 1234567890120001L, new DateTime(2028, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9186), 8 },
                    { 6, 321, "Luis Castro", 1234567890120002L, new DateTime(2027, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9192), 9 },
                    { 7, 456, "Esteban Zamora", 1234567890120003L, new DateTime(2029, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9193), 10 },
                    { 8, 654, "David Rojas", 1234567890120004L, new DateTime(2026, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9195), 12 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckIn", "CheckOut", "CreatedAt", "NumberOfAdults", "NumberOfGuests", "NumberOfKids", "Status", "UserId" },
                values: new object[,]
                {
                    { 7, new DateTime(2025, 4, 22, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9046), new DateTime(2025, 4, 23, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9051), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9052), 1, 1, 0, "Confirmed", 8 },
                    { 8, new DateTime(2025, 4, 24, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9053), new DateTime(2025, 4, 27, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9053), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9054), 2, 3, 1, "Confirmed", 9 },
                    { 9, new DateTime(2025, 4, 28, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9055), new DateTime(2025, 5, 1, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9055), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9056), 2, 2, 0, "Confirmed", 10 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "Rating", "UserId" },
                values: new object[,]
                {
                    { 6, "Buen lugar para relajarse.", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9164), 4, 8 },
                    { 7, "Muy recomendado para vacaciones.", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9165), 5, 9 },
                    { 8, "Podría mejorar el servicio.", new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9166), 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedAt", "PaymentMethod", "PaymentStatus", "ReservationId", "TransactionId" },
                values: new object[,]
                {
                    { 3, 180.0, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9141), "American Express", "Pending", 7, "TX000777" },
                    { 4, 320.0, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9142), "American Express", "Pending", 9, "TX000888" },
                    { 5, 320.0, new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9143), "American Express", "Pending", 8, "TX000838" }
                });

            migrationBuilder.InsertData(
                table: "ReservationRoom",
                columns: new[] { "ReservationsId", "RoomsId" },
                values: new object[,]
                {
                    { 7, 13 },
                    { 8, 14 },
                    { 8, 20 },
                    { 9, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 8, 20 });

            migrationBuilder.DeleteData(
                table: "ReservationRoom",
                keyColumns: new[] { "ReservationsId", "RoomsId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Bathrooms", "Beds", "CreatedAt", "Description", "GuestsPerRoom", "ImageUrl", "Name", "Price", "RoomNumber", "Status", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6496), "Acogedora habitación individual", 1, "/placeholder.svg", "Deluxe Ocean View", 100.0, "101", "Available", "Single", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6497) },
                    { 2, 1, 2, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6499), "Amplia habitación doble", 2, "/placeholder.svg", "Premium Garden Suite", 150.0, "102", "Available", "Double", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6499) },
                    { 3, 2, 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6501), "Suite de lujo con vista al mar", 2, "/placeholder.svg", "Executive Ocean Suite", 250.0, "103", "Available", "Suite", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6501) },
                    { 4, 1, 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6503), "Habitación individual económica", 1, "/placeholder.svg", "Budget Single", 90.0, "104", "Occupied", "Single", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6503) },
                    { 5, 1, 2, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6505), "Habitación doble moderna con balcón", 2, "/placeholder.svg", "City View Deluxe", 160.0, "105", "Available", "Double", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6505) },
                    { 6, 2, 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6506), "Gran suite con jacuzzi privado", 2, "/placeholder.svg", "Presidential Suite", 300.0, "106", "Available", "Suite", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6507) },
                    { 7, 1, 2, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6508), "Cómoda habitación doble con escritorio", 2, "/placeholder.svg", "Business Room", 140.0, "107", "Under Maintenance", "Double", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6508) },
                    { 8, 1, 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6510), "Tranquila habitación individual cerca del jardín", 1, "/placeholder.svg", "Garden Nook", 95.0, "108", "Available", "Single", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6510) },
                    { 9, 1, 2, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6512), "Habitación doble con vista parcial al mar", 2, "/placeholder.svg", "Sunset Double", 170.0, "109", "Available", "Double", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6512) },
                    { 10, 2, 2, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6513), "Suite de lujo con cocina incluida", 4, "/placeholder.svg", "Family Suite", 280.0, "110", "Occupied", "Suite", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6514) },
                    { 11, 1, 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6515), "Habitación individual ideal para viajeros", 1, "/placeholder.svg", "Traveler's Spot", 105.0, "111", "Available", "Single", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6515) },
                    { 12, 1, 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6517), "Habitación doble con cama tamaño king", 2, "/placeholder.svg", "King Double Room", 155.0, "112", "Available", "Double", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6517) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "LastName", "Name", "PasswordHash", "Phone", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6299), "john@example.com", "Doe", "John", "hashedpassword", "1234567890", "User", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6300) },
                    { 2, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6301), "jane@example.com", "Smith", "Jane", "hashedpassword", "9876543210", "User", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6302) },
                    { 3, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6303), "michael@example.com", "Johnson", "Michael", "hashedpassword", "5556667777", "User", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6303) },
                    { 4, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6305), "lucia@example.com", "Gómez", "Lucía", "hashedpassword", "1112223333", "User", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6305) },
                    { 5, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6306), "carlos@example.com", "Ramírez", "Carlos", "hashedpassword", "4445556666", "Admin", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6306) },
                    { 6, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6307), "sofia@example.com", "Fernández", "Sofía", "hashedpassword", "7778889999", "User", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6308) },
                    { 7, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6309), "andres@example.com", "Martínez", "Andrés", "hashedpassword", "2223334444", "Admin", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6309) }
                });

            migrationBuilder.InsertData(
                table: "CardDetails",
                columns: new[] { "Id", "CardCode", "CardHolderName", "CardNumber", "ExpiredDate", "UserId" },
                values: new object[,]
                {
                    { 1, 123, "John Doe", 1234567812345678L, new DateTime(2027, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6410), 1 },
                    { 2, 456, "Jane Smith", 8765432187654321L, new DateTime(2028, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6417), 2 },
                    { 3, 789, "Lucía Gómez", 4321432143214321L, new DateTime(2029, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6419), 4 },
                    { 4, 321, "Carlos Ramírez", 5678567856785678L, new DateTime(2026, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6420), 5 }
                });

            migrationBuilder.InsertData(
                table: "PasswordResets",
                columns: new[] { "Id", "ExpiresAt", "ResetToken", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 3, 38, 28, 73, DateTimeKind.Utc).AddTicks(6463), "abcd1234", 1 },
                    { 2, new DateTime(2025, 3, 31, 3, 38, 28, 73, DateTimeKind.Utc).AddTicks(6474), "efgh5678", 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckIn", "CheckOut", "CreatedAt", "NumberOfAdults", "NumberOfGuests", "NumberOfKids", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 1, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6542), new DateTime(2025, 4, 3, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6545), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6546), 2, 2, 0, "Confirmed", 1 },
                    { 2, new DateTime(2025, 4, 5, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6552), new DateTime(2025, 4, 8, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6553), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6553), 2, 3, 1, "Confirmed", 2 },
                    { 3, new DateTime(2025, 4, 2, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6554), new DateTime(2025, 4, 4, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6555), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6555), 1, 1, 0, "Confirmed", 4 },
                    { 4, new DateTime(2025, 4, 10, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6556), new DateTime(2025, 4, 15, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6557), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6557), 2, 4, 2, "Cancelled", 5 },
                    { 5, new DateTime(2025, 4, 7, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 4, 9, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6559), 1, 2, 1, "Confirmed", 6 },
                    { 6, new DateTime(2025, 4, 3, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6560), new DateTime(2025, 4, 6, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6560), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6561), 2, 2, 0, "Confirmed", 7 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "¡Experiencia increíble!", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6596), 5, 1 },
                    { 2, "¡Estancia muy cómoda!", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6597), 4, 2 },
                    { 3, "Buena atención, pero la habitación era algo ruidosa.", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6598), 3, 4 },
                    { 4, "Excelente servicio y vista espectacular.", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6599), 5, 5 },
                    { 5, "No cumplió mis expectativas, había problemas con la limpieza.", new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6600), 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "Message", "ReservationId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6442), "Welcome to our service!", 1, "Unread" },
                    { 2, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6443), "Your reservation has been confirmed!", 2, "Unread" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedAt", "PaymentMethod", "PaymentStatus", "ReservationId", "TransactionId" },
                values: new object[,]
                {
                    { 1, 200.5, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6579), "Credit Card", "Completed", 1, "TX123456" },
                    { 2, 350.75, new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6580), "PayPal", "Pending", 2, "TX789012" }
                });

            migrationBuilder.InsertData(
                table: "ReservationRoom",
                columns: new[] { "ReservationsId", "RoomsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 4 },
                    { 4, 6 },
                    { 4, 10 },
                    { 5, 5 },
                    { 6, 9 },
                    { 6, 12 }
                });
        }
    }
}
