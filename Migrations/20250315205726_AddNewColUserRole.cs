using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "longtext",
                nullable: false,
                defaultValue: "User")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Rooms",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiredDate",
                value: new DateTime(2027, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiredDate",
                value: new DateTime(2028, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 15, 22, 57, 25, 718, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 15, 22, 57, 25, 718, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 16, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6457), new DateTime(2025, 3, 18, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 20, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6462), new DateTime(2025, 3, 23, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6463), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6434), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6437), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Role", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6173), "User", new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Role", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6252), "User", new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Role", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6254), "User", new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6254) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ImageUrl",
                keyValue: null,
                column: "ImageUrl",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Rooms",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6907), new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6909), new DateTime(2025, 3, 15, 18, 7, 57, 121, DateTimeKind.Utc).AddTicks(6910) });

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
    }
}
