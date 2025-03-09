using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class NotificationLinkedToReservationNotUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Notifications",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                newName: "IX_Notifications_ReservationId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Reservations_ReservationId",
                table: "Notifications",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Reservations_ReservationId",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Notifications",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_ReservationId",
                table: "Notifications",
                newName: "IX_Notifications_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
