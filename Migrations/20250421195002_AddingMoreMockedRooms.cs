using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class AddingMoreMockedRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiredDate",
                value: new DateTime(2028, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiredDate",
                value: new DateTime(2027, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "ExpiredDate",
                value: new DateTime(2029, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "ExpiredDate",
                value: new DateTime(2026, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5687), new DateTime(2025, 4, 23, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5693), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 24, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5695), new DateTime(2025, 4, 27, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5695), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 28, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5696), new DateTime(2025, 5, 1, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5631), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5633), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5635), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5637), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5639), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5640), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5642), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5644), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5644) });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Bathrooms", "Beds", "CreatedAt", "Description", "GuestsPerRoom", "ImageUrl", "Name", "Price", "RoomNumber", "Status", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, 2, 1, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5645), "Suite frente al mar con cama king", 2, null, "Oceanfront Suite", 330.0, "209", "Available", "Suite", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5646) },
                    { 22, 1, 2, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5647), "Vista panorámica al atardecer", 2, null, "Sunset View Double", 165.0, "210", "Available", "Double", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5647) },
                    { 23, 1, 1, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5649), "Perfecta para estancias cortas", 1, null, "Express Stay", 100.0, "211", "Available", "Single", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5649) },
                    { 24, 1, 2, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5650), "Moderna con balcón privado", 2, null, "Balcony Room", 175.0, "212", "Available", "Double", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5650) },
                    { 25, 2, 2, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5652), "Suite presidencial con vista 360°", 3, null, "Panoramic Suite", 350.0, "213", "Available", "Suite", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5652) },
                    { 26, 1, 1, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5653), "Con acceso rápido al lobby", 1, null, "Lobby Quickstay", 98.0, "214", "Available", "Single", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5654) },
                    { 27, 1, 2, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5656), "Decoración tropical y luminosa", 2, null, "Tropical Vibes Room", 150.0, "215", "Available", "Double", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5656) },
                    { 28, 2, 2, new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5657), "Suite premium con doble ambiente", 4, null, "Split Suite", 310.0, "216", "Available", "Suite", new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5658) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5516), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5519), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5520), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5522), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5523), new DateTime(2025, 4, 21, 19, 50, 1, 723, DateTimeKind.Utc).AddTicks(5524) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiredDate",
                value: new DateTime(2028, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiredDate",
                value: new DateTime(2027, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "ExpiredDate",
                value: new DateTime(2029, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "ExpiredDate",
                value: new DateTime(2026, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 22, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9046), new DateTime(2025, 4, 23, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9051), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 24, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9053), new DateTime(2025, 4, 27, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9053), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 28, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9055), new DateTime(2025, 5, 1, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9055), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9008), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9010), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9012), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9014), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9015), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9017), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9019), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9020), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8886), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8889), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8890), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8892), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 4, 21, 19, 45, 13, 442, DateTimeKind.Utc).AddTicks(8894) });
        }
    }
}
