using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bungalowparadise_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataSampleSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 20, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7356), new DateTime(2025, 3, 23, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7357), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7357), "Confirmed" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "CreatedAt" },
                values: new object[] { "¡Experiencia increíble!", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "CreatedAt" },
                values: new object[] { "¡Estancia muy cómoda!", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7306), "Acogedora habitación individual", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7308), "Amplia habitación doble", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Bathrooms", "Beds", "CreatedAt", "Description", "GuestsPerRoom", "ImageUrl", "Name", "Price", "RoomNumber", "Status", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 2, 1, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7310), "Suite de lujo con vista al mar", 2, "/placeholder.svg", "Executive Ocean Suite", 250.0, "103", "Available", "Suite", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7311) },
                    { 4, 1, 1, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7312), "Habitación individual económica", 1, "/placeholder.svg", "Budget Single", 90.0, "104", "Occupied", "Single", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7313) },
                    { 5, 1, 2, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7314), "Habitación doble moderna con balcón", 2, "/placeholder.svg", "City View Deluxe", 160.0, "105", "Available", "Double", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7314) },
                    { 6, 2, 1, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7316), "Gran suite con jacuzzi privado", 2, "/placeholder.svg", "Presidential Suite", 300.0, "106", "Available", "Suite", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7316) },
                    { 7, 1, 2, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7318), "Cómoda habitación doble con escritorio", 2, "/placeholder.svg", "Business Room", 140.0, "107", "Under Maintenance", "Double", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7318) },
                    { 8, 1, 1, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7320), "Tranquila habitación individual cerca del jardín", 1, "/placeholder.svg", "Garden Nook", 95.0, "108", "Available", "Single", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7320) },
                    { 9, 1, 2, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7321), "Habitación doble con vista parcial al mar", 2, "/placeholder.svg", "Sunset Double", 170.0, "109", "Available", "Double", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7322) },
                    { 10, 2, 2, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7323), "Suite de lujo con cocina incluida", 4, "/placeholder.svg", "Family Suite", 280.0, "110", "Occupied", "Suite", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7323) },
                    { 11, 1, 1, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7325), "Habitación individual ideal para viajeros", 1, "/placeholder.svg", "Traveler's Spot", 105.0, "111", "Available", "Single", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7325) },
                    { 12, 1, 1, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7326), "Habitación doble con cama tamaño king", 2, "/placeholder.svg", "King Double Room", 155.0, "112", "Available", "Double", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7327) }
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "LastName", "Name", "PasswordHash", "Phone", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7075), "lucia@example.com", "Gómez", "Lucía", "hashedpassword", "1112223333", "User", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7075) },
                    { 5, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7076), "carlos@example.com", "Ramírez", "Carlos", "hashedpassword", "4445556666", "Admin", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7076) },
                    { 6, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7077), "sofia@example.com", "Fernández", "Sofía", "hashedpassword", "7778889999", "User", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7078) },
                    { 7, new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7079), "andres@example.com", "Martínez", "Andrés", "hashedpassword", "2223334444", "Admin", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7079) }
                });

            migrationBuilder.InsertData(
                table: "CardDetails",
                columns: new[] { "Id", "CardCode", "CardHolderName", "CardNumber", "ExpiredDate", "UserId" },
                values: new object[,]
                {
                    { 3, 789, "Lucía Gómez", 4321432143214321L, new DateTime(2029, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7236), 4 },
                    { 4, 321, "Carlos Ramírez", 5678567856785678L, new DateTime(2026, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7238), 5 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CheckIn", "CheckOut", "CreatedAt", "NumberOfAdults", "NumberOfGuests", "NumberOfKids", "Status", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2025, 3, 17, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 3, 19, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7359), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7359), 1, 1, 0, "Confirmed", 4 },
                    { 4, new DateTime(2025, 3, 25, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7360), new DateTime(2025, 3, 30, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7361), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7361), 2, 4, 2, "Cancelled", 5 },
                    { 5, new DateTime(2025, 3, 22, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7362), new DateTime(2025, 3, 24, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7362), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7363), 1, 2, 1, "Confirmed", 6 },
                    { 6, new DateTime(2025, 3, 18, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 3, 21, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7364), 2, 2, 0, "Confirmed", 7 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "Rating", "UserId" },
                values: new object[,]
                {
                    { 3, "Buena atención, pero la habitación era algo ruidosa.", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7402), 3, 4 },
                    { 4, "Excelente servicio y vista espectacular.", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7403), 5, 5 },
                    { 5, "No cumplió mis expectativas, había problemas con la limpieza.", new DateTime(2025, 3, 15, 21, 42, 6, 627, DateTimeKind.Utc).AddTicks(7404), 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "ReservationRoom",
                columns: new[] { "ReservationsId", "RoomsId" },
                values: new object[,]
                {
                    { 3, 4 },
                    { 4, 6 },
                    { 4, 10 },
                    { 5, 5 },
                    { 6, 9 },
                    { 6, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardDetails",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "CheckIn", "CheckOut", "CreatedAt", "Status" },
                values: new object[] { new DateTime(2025, 3, 20, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6462), new DateTime(2025, 3, 23, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6463), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6463), "Pending" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "CreatedAt" },
                values: new object[] { "Amazing experience!", new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "CreatedAt" },
                values: new object[] { "Very comfortable stay!", new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6434), "Cozy single room", new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6437), "Spacious double room", new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6252), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6254), new DateTime(2025, 3, 15, 20, 57, 25, 718, DateTimeKind.Utc).AddTicks(6254) });
        }
    }
}
