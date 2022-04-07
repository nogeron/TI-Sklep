using Microsoft.EntityFrameworkCore.Migrations;

namespace TI_Sklep.Migrations
{
    public partial class ChangeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataProdukcji",
                table: "Filmy",
                newName: "DataDodania");

            migrationBuilder.AddColumn<string>(
                name: "Dlugosc",
                table: "Filmy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dlugosc", "Plakat" },
                values: new object[] { "11", "teksanska-masakra-pila-mechaniczna.jpg" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dlugosc", "Plakat" },
                values: new object[] { "12", "numer-23.jpg" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                column: "Dlugosc",
                value: "13");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                column: "Dlugosc",
                value: "114");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                column: "Dlugosc",
                value: "15");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 6,
                column: "Dlugosc",
                value: "126");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 7,
                column: "Dlugosc",
                value: "27");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 8,
                column: "Dlugosc",
                value: "41");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9,
                column: "Dlugosc",
                value: "43");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10,
                column: "Dlugosc",
                value: "99");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dlugosc",
                table: "Filmy");

            migrationBuilder.RenameColumn(
                name: "DataDodania",
                table: "Filmy",
                newName: "DataProdukcji");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                column: "Plakat",
                value: "teksanska - masakra - pila - mechaniczna.jpg");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "Plakat",
                value: "numer - 23.jpg");
        }
    }
}
