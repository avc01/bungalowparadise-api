using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTransactionIdRequirement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payments_TransactionId",
                table: "Payments");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "Payments",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiredDate",
                value: new DateTime(2027, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiredDate",
                value: new DateTime(2028, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiredDate",
                value: new DateTime(2029, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiredDate",
                value: new DateTime(2026, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 31, 3, 38, 28, 73, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 31, 3, 38, 28, 73, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 1, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6542), new DateTime(2025, 4, 3, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6545), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 5, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6552), new DateTime(2025, 4, 8, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6553), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 2, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6554), new DateTime(2025, 4, 4, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6555), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 10, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6556), new DateTime(2025, 4, 15, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6557), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 7, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 4, 9, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 4, 3, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6560), new DateTime(2025, 4, 6, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6560), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6496), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6499), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6501), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6503), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6505), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6506), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6508), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6510), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6512), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6513), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6515), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6517), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6299), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6301), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6303), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6305), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6306), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6307), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6309), new DateTime(2025, 3, 31, 1, 38, 28, 73, DateTimeKind.Utc).AddTicks(6309) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "TransactionId",
                keyValue: null,
                column: "TransactionId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "Payments",
                type: "varchar(255)",
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
                value: new DateTime(2027, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiredDate",
                value: new DateTime(2028, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiredDate",
                value: new DateTime(2029, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiredDate",
                value: new DateTime(2026, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 15, 23, 42, 6, 627, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "PasswordResets",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiresAt",
                value: new DateTime(2025, 3, 15, 23, 42, 6, 627, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 16, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7351), new DateTime(2025, 3, 18, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7353), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 20, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7356), new DateTime(2025, 3, 23, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7357), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 17, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 3, 19, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7359), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 25, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7360), new DateTime(2025, 3, 30, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7361), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 22, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7362), new DateTime(2025, 3, 24, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7362), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt" },
                values: new object[] { new DateTime(2025, 3, 18, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 3, 21, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7312), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7314), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7316), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7318), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7321), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7323), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7326), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7068), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7071), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7073), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7075), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7076), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7077), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7079), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TransactionId",
                table: "Payments",
                column: "TransactionId",
                unique: true);
        }
    }
}
