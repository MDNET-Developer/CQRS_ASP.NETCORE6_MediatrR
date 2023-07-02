using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRS_ASP.NETCore6.Migrations
{
    public partial class student_data_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Degree", "Name", "Surname", "University" },
                values: new object[] { 1, 22, "Master", "Murad", "Aliyev", "AzTU" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Degree", "Name", "Surname", "University" },
                values: new object[] { 2, 22, "Master", "Elshad", "Babayev", "AzTU" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Degree", "Name", "Surname", "University" },
                values: new object[] { 3, 22, "Master", "Farid", "Fahiyev", "ADNSU" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
