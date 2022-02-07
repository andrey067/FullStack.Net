using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.Api.Data.Migrations
{
    public partial class Atualizando_a_tabela_Eventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Eventos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Eventos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 8, 22, 2, 8, 3, 197, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 6, 17, 18, 35, 34, 104, DateTimeKind.Local).AddTicks(6064), "Jennifer9@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ricky Williamson", 75, "357-270-9332 x15350", "Olson LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 3, new DateTime(2022, 9, 3, 1, 59, 19, 104, DateTimeKind.Local).AddTicks(2484), new DateTime(2022, 5, 15, 0, 41, 49, 381, DateTimeKind.Local).AddTicks(9397), "Jared_Williamson45@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tyrique Johnson", 2, "(583) 565-6511", "Bernhard, Kuhlman and Waters", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 5, new DateTime(2022, 11, 7, 2, 10, 30, 675, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 4, 5, 3, 41, 20, 265, DateTimeKind.Local).AddTicks(4063), "Spencer_Ernser33@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Beulah Bauch", 28, "876-351-5030 x064", "Schinner - Grady", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 7, new DateTime(2022, 10, 11, 8, 59, 24, 209, DateTimeKind.Local).AddTicks(4104), new DateTime(2022, 10, 9, 6, 0, 13, 937, DateTimeKind.Local).AddTicks(1747), "Rolando_Bayer36@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Laney Hyatt", 87, "837-631-4263", "Steuber and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 9, new DateTime(2023, 1, 10, 1, 44, 3, 900, DateTimeKind.Local).AddTicks(5857), new DateTime(2022, 10, 3, 21, 59, 5, 456, DateTimeKind.Local).AddTicks(186), "Meredith.Bradtke@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Horacio Reichert", 82, "651-634-6952 x083", "Erdman, Kohler and Mohr", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Eventos");
        }
    }
}
