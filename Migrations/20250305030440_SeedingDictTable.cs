using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDictTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiredDate",
                value: new DateTime(2027, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiredDate",
                value: new DateTime(2028, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 5, 5, 4, 40, 159, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 5, 5, 4, 40, 159, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.InsertData(
                table: "ReservationRoom",
                columns: new[] { "ReservationsId", "RoomsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9202), new DateTime(2025, 3, 8, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9204), new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 10, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9207), new DateTime(2025, 3, 13, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9207), new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9182), new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9184), new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9008), new DateTime(2025, 3, 5, 3, 4, 40, 159, DateTimeKind.Utc).AddTicks(9008) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiredDate",
                value: new DateTime(2027, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiredDate",
                value: new DateTime(2028, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 5, 4, 58, 43, 177, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 5, 4, 58, 43, 177, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3538), new DateTime(2025, 3, 8, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3540), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 10, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543), new DateTime(2025, 3, 13, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3517), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3519), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3343), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3346), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3347), new DateTime(2025, 3, 5, 2, 58, 43, 177, DateTimeKind.Utc).AddTicks(3348) });
        }
    }
}
