using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class RoomModelUpdatePart1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bathrooms",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Rooms",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiredDate",
                value: new DateTime(2027, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiredDate",
                value: new DateTime(2028, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 15, 20, 7, 57, 121, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 15, 20, 7, 57, 121, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 16, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6932), new DateTime(2025, 3, 18, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6934), new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 20, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6936), new DateTime(2025, 3, 23, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6936), new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bathrooms", "CreatedAt", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6907), "/placeholder.svg", "Deluxe Ocean View", new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bathrooms", "CreatedAt", "ImageUrl", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6909), "/placeholder.svg", "Premium Garden Suite", new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6680), new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6682), new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6684), new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6684) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bathrooms",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiredDate",
                value: new DateTime(2027, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiredDate",
                value: new DateTime(2028, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 9, 18, 20, 45, 67, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 9, 18, 20, 45, 67, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 10, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3568), new DateTime(2025, 3, 12, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3571), new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3574), new DateTime(2025, 3, 17, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3574), new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3548), new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3549), new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3385), new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3387), new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3389), new DateTime(2025, 3, 9, 16, 20, 45, 67, DateTimeKind.Utc).AddTicks(3389) });
        }
    }
}
