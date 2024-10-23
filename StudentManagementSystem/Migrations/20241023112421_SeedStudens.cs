using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentEmail", "StudentName", "StudentPhone" },
                values: new object[,]
                {
                    { 1, "esermjila07@gmail.com", "Esethu Mjila", "0604269728" },
                    { 2, "asivemyeni@gmail.com", "Asive Myeni", "0736379802" },
                    { 3, "michael.j@example.com", "Michael Johnson", "555-111-2222" },
                    { 4, "emily.d@example.com", "Emily Davis", "444-222-3333" },
                    { 5, "william.b@example.com", "William Brown", "333-999-8888" },
                    { 6, "jessica.t@example.com", "Jessica Taylor", "666-777-8888" },
                    { 7, "david.w@example.com", "David Wilson", "777-888-9999" },
                    { 8, "sarah.l@example.com", "Sarah Lee", "222-333-4444" },
                    { 9, "james.w@example.com", "James White", "888-999-0000" },
                    { 10, "ashley.h@example.com", "Ashley Harris", "999-000-1111" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);
        }
    }
}
