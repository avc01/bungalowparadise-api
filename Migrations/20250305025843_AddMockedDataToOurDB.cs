using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class AddMockedDataToOurDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Beds", "CreatedAt", "Description", "GuestsPerRoom", "Price", "RoomNumber", "Status", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3517), "Cozy single room", 1, 100.0, "101", "Available", "Single", new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3518) },
                    { 2, 2, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3519), "Spacious double room", 2, 150.0, "102", "Available", "Double", new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3520) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "LastName", "Name", "PasswordHash", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3343), "john@example.com", "Doe", "John", "hashedpassword", "1234567890", new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3344) },
                    { 2, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3346), "jane@example.com", "Smith", "Jane", "hashedpassword", "9876543210", new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3346) },
                    { 3, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3347), "michael@example.com", "Johnson", "Michael", "hashedpassword", "5556667777", new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3348) }
                });

            migrationBuilder.InsertData(
                table: "CardDetails",
                columns: new[] { "Id", "CardCode", "CardHolderName", "CardNumber", "ExpiredDate", "UserId" },
                values: new object[,]
                {
                    { 1, 123, "John Doe", 1234567812345678L, new DateTime(2027, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3446), 1 },
                    { 2, 456, "Jane Smith", 8765432187654321L, new DateTime(2028, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3454), 2 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedAt", "Message", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3473), "Welcome to our service!", "Unread", 1 },
                    { 2, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3474), "Your reservation has been confirmed!", "Unread", 2 }
                });

            migrationBuilder.InsertData(
                table: "PasswordResets",
                columns: new[] { "Id", "ExpiresAt", "ResetToken", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 5, 4, 58, 43, 177, DateTimeKind.Utc).AddTicks(3493), "abcd1234", 1 },
                    { 2, new DateTime(2025, 3, 5, 4, 58, 43, 177, DateTimeKind.Utc).AddTicks(3498), "efgh5678", 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckIn", "CheckOut", "CreatedAt", "NumberOfAdults", "NumberOfGuests", "NumberOfKids", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 6, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3538), new DateTime(2025, 3, 8, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3540), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3541), 2, 2, 0, "Confirmed", 1 },
                    { 2, new DateTime(2025, 3, 10, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543), new DateTime(2025, 3, 13, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543), 2, 3, 1, "Pending", 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "Amazing experience!", new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3585), 5, 1 },
                    { 2, "Very comfortable stay!", new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3587), 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedAt", "PaymentMethod", "PaymentStatus", "ReservationId", "TransactionId" },
                values: new object[,]
                {
                    { 1, 200.5, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3561), "Credit Card", "Completed", 1, "TX123456" },
                    { 2, 350.75, new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3562), "PayPal", "Pending", 2, "TX789012" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
