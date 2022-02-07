using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.Api.Data.Migrations
{
    public partial class adicionandoMaisEnventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2022, 3, 21, 0, 48, 11, 528, DateTimeKind.Local).AddTicks(7403), new DateTime(2022, 4, 1, 5, 10, 10, 723, DateTimeKind.Local).AddTicks(949), "Laurie43@gmail.com", "Aurelia Carter", 32, "970-645-8145 x3328", "Schaden - Tromp" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2023, 1, 23, 1, 42, 54, 443, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 1, 8, 0, 20, 31, 360, DateTimeKind.Local).AddTicks(6569), "Ethel55@hotmail.com", "Jillian Doyle", 20, "312.930.8913 x317", "Macejkovic Group" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2023, 2, 2, 9, 54, 30, 68, DateTimeKind.Local).AddTicks(8301), new DateTime(2022, 8, 30, 14, 4, 50, 852, DateTimeKind.Local).AddTicks(6450), "Terence.Leuschke53@hotmail.com", "Monserrat Mann", 57, "728.335.9150", "Altenwerth Inc" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2022, 4, 5, 3, 53, 28, 747, DateTimeKind.Local).AddTicks(8516), new DateTime(2022, 8, 15, 8, 31, 3, 303, DateTimeKind.Local).AddTicks(6579), "Nathan_Kunze61@gmail.com", "Bailey Rice", 51, "1-287-417-0936 x707", "Mills, Parker and Lakin" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 43, 7, 583, DateTimeKind.Local).AddTicks(6864), new DateTime(2022, 2, 15, 22, 24, 42, 106, DateTimeKind.Local).AddTicks(9649), "Marcella52@gmail.com", "Dena Ortiz", 62, "1-622-556-7876 x410", "King, Morar and Reinger" });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 517, new DateTime(2022, 4, 11, 17, 36, 11, 142, DateTimeKind.Local).AddTicks(3856), new DateTime(2022, 7, 20, 20, 25, 33, 269, DateTimeKind.Local).AddTicks(9956), "Nettie52@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Fritz Hermiston", 76, "1-498-352-8313 x6737", "Wilderman - Larkin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 337, new DateTime(2022, 3, 23, 20, 28, 13, 674, DateTimeKind.Local).AddTicks(1562), new DateTime(2022, 7, 2, 19, 44, 3, 896, DateTimeKind.Local).AddTicks(2959), "Maurice81@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tyree Goyette", 64, "520-531-4872", "Hayes - Kovacek", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 339, new DateTime(2022, 6, 15, 13, 49, 56, 465, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 8, 25, 11, 31, 41, 579, DateTimeKind.Local).AddTicks(186), "Carlton_Ruecker86@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Zack Predovic", 72, "1-672-947-4078 x8289", "Heathcote LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 341, new DateTime(2022, 2, 24, 13, 48, 9, 564, DateTimeKind.Local).AddTicks(7208), new DateTime(2022, 4, 27, 17, 44, 46, 612, DateTimeKind.Local).AddTicks(3331), "Elena_Schiller@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Leonora Heaney", 81, "469.773.9788", "Kirlin - Yundt", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 343, new DateTime(2022, 6, 11, 10, 11, 54, 492, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 11, 7, 1, 7, 52, 107, DateTimeKind.Local).AddTicks(3019), "Chad72@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Troy Turner", 13, "1-299-591-0652", "Bahringer - McCullough", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 345, new DateTime(2022, 12, 7, 13, 6, 0, 463, DateTimeKind.Local).AddTicks(2662), new DateTime(2022, 2, 17, 22, 56, 49, 97, DateTimeKind.Local).AddTicks(8977), "Bobbie_Morar77@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Gladys Kirlin", 29, "1-845-702-5756", "Lakin LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 347, new DateTime(2023, 2, 2, 1, 17, 23, 549, DateTimeKind.Local).AddTicks(138), new DateTime(2022, 10, 6, 19, 17, 43, 850, DateTimeKind.Local).AddTicks(3839), "Ian_Botsford83@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Clara Heathcote", 18, "(693) 415-5220 x14105", "Jones LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 349, new DateTime(2022, 12, 6, 1, 41, 47, 328, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 5, 9, 11, 8, 15, 941, DateTimeKind.Local).AddTicks(8333), "Shawn54@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Laverne Keebler", 10, "1-834-747-4029", "Carroll - Rippin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 351, new DateTime(2022, 6, 18, 11, 30, 31, 293, DateTimeKind.Local).AddTicks(7842), new DateTime(2022, 12, 16, 8, 16, 25, 364, DateTimeKind.Local).AddTicks(1680), "Renee_Auer@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Finn Herzog", 26, "1-543-665-8364", "Heaney - Schuppe", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 353, new DateTime(2022, 12, 4, 2, 59, 48, 450, DateTimeKind.Local).AddTicks(909), new DateTime(2022, 7, 14, 6, 6, 50, 773, DateTimeKind.Local).AddTicks(7541), "Toby_Wintheiser1@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kacie Conroy", 22, "(366) 750-8749 x5480", "Bergstrom - Rau", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 355, new DateTime(2022, 2, 27, 0, 41, 46, 609, DateTimeKind.Local).AddTicks(9553), new DateTime(2022, 3, 23, 13, 26, 40, 390, DateTimeKind.Local).AddTicks(3849), "Carlos63@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alda Senger", 3, "754.952.8627", "Tillman and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 357, new DateTime(2022, 12, 13, 4, 1, 30, 381, DateTimeKind.Local).AddTicks(8241), new DateTime(2022, 6, 28, 18, 52, 6, 96, DateTimeKind.Local).AddTicks(3234), "Henrietta.Hamill34@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Richmond Block", 34, "1-910-876-8046", "Schmitt, Johnston and Smith", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 359, new DateTime(2022, 4, 13, 2, 39, 30, 469, DateTimeKind.Local).AddTicks(242), new DateTime(2022, 12, 14, 13, 57, 0, 453, DateTimeKind.Local).AddTicks(7997), "Ronnie.Krajcik@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Nasir Jones", 35, "(257) 533-8362", "Bartoletti, Koelpin and Koss", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 361, new DateTime(2022, 7, 27, 18, 14, 33, 429, DateTimeKind.Local).AddTicks(8167), new DateTime(2022, 8, 3, 4, 29, 38, 319, DateTimeKind.Local).AddTicks(3107), "Pablo_Bashirian@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Maurice Hessel", 59, "1-327-322-4312", "Jacobi, Wiza and Bartell", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 363, new DateTime(2023, 1, 2, 13, 36, 6, 100, DateTimeKind.Local).AddTicks(5673), new DateTime(2022, 6, 4, 5, 42, 52, 665, DateTimeKind.Local).AddTicks(9622), "Christopher.Turcotte@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Makenzie Zemlak", 59, "458-787-6888", "Reilly Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 365, new DateTime(2022, 7, 8, 20, 37, 33, 154, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 12, 14, 0, 16, 58, 446, DateTimeKind.Local).AddTicks(1772), "Lindsey.Goyette@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Burnice Streich", 17, "534-972-3333", "Altenwerth - Gleason", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 367, new DateTime(2022, 5, 15, 4, 23, 14, 900, DateTimeKind.Local).AddTicks(4494), new DateTime(2022, 8, 4, 3, 6, 6, 332, DateTimeKind.Local).AddTicks(8910), "Susie.Robel70@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Marcia Reichert", 43, "(649) 524-6732 x13474", "Borer, Reilly and Mohr", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 369, new DateTime(2022, 7, 21, 14, 10, 34, 512, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 7, 2, 5, 17, 22, 622, DateTimeKind.Local).AddTicks(4730), "Thelma.Orn@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Brianne Raynor", 40, "1-795-922-8310", "Kilback Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 371, new DateTime(2022, 9, 14, 9, 41, 51, 597, DateTimeKind.Local).AddTicks(8728), new DateTime(2022, 5, 25, 16, 35, 22, 390, DateTimeKind.Local).AddTicks(7083), "Kirk_Mayert68@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Yasmine Romaguera", 49, "(220) 949-4472", "Mertz Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 373, new DateTime(2023, 1, 17, 11, 23, 29, 509, DateTimeKind.Local).AddTicks(8047), new DateTime(2022, 8, 14, 7, 25, 7, 845, DateTimeKind.Local).AddTicks(9528), "Alan58@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sharon O'Conner", 22, "(342) 256-6363", "Raynor - Krajcik", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 375, new DateTime(2022, 6, 7, 8, 35, 16, 232, DateTimeKind.Local).AddTicks(3957), new DateTime(2022, 2, 27, 6, 59, 7, 311, DateTimeKind.Local).AddTicks(8835), "Marion.Harber@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Daija Mante", 17, "628.387.1198", "Ruecker - Tillman", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 377, new DateTime(2022, 9, 10, 6, 1, 43, 453, DateTimeKind.Local).AddTicks(3483), new DateTime(2022, 2, 6, 21, 3, 54, 703, DateTimeKind.Local).AddTicks(4584), "Kari86@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Libbie Kihn", 11, "(548) 774-3284", "Treutel - Lebsack", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 379, new DateTime(2022, 8, 19, 18, 8, 33, 361, DateTimeKind.Local).AddTicks(1459), new DateTime(2022, 3, 19, 17, 55, 36, 15, DateTimeKind.Local).AddTicks(6094), "Marion_Abernathy13@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Santiago Swaniawski", 7, "1-265-696-6004 x96442", "Koss LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 381, new DateTime(2022, 6, 21, 3, 7, 52, 782, DateTimeKind.Local).AddTicks(6261), new DateTime(2022, 10, 14, 1, 58, 36, 625, DateTimeKind.Local).AddTicks(7799), "Elisa_DAmore0@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Stanford Feil", 66, "1-828-339-1700 x5489", "Greenfelder and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 383, new DateTime(2023, 1, 26, 21, 46, 23, 89, DateTimeKind.Local).AddTicks(7623), new DateTime(2022, 5, 19, 12, 59, 35, 449, DateTimeKind.Local).AddTicks(8606), "Marcella94@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Gianni Kulas", 51, "994.974.9520", "Koss - Botsford", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 385, new DateTime(2022, 11, 28, 23, 46, 18, 928, DateTimeKind.Local).AddTicks(8472), new DateTime(2022, 11, 6, 12, 55, 39, 508, DateTimeKind.Local).AddTicks(5328), "Rafael.Tromp@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Adrain Mraz", 6, "613.250.1934 x19225", "Koss, Emmerich and Streich", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 387, new DateTime(2022, 11, 16, 22, 46, 50, 541, DateTimeKind.Local).AddTicks(9904), new DateTime(2022, 3, 17, 6, 21, 40, 206, DateTimeKind.Local).AddTicks(1110), "Elmer79@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Blanche Fadel", 93, "(280) 464-7614 x612", "Welch, Conn and Harvey", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 389, new DateTime(2022, 3, 16, 15, 2, 20, 775, DateTimeKind.Local).AddTicks(9446), new DateTime(2022, 9, 5, 16, 12, 42, 527, DateTimeKind.Local).AddTicks(3533), "Gilberto_Mayert15@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Layne Haag", 30, "734-626-7310 x43261", "Terry Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 335, new DateTime(2023, 1, 27, 7, 30, 1, 537, DateTimeKind.Local).AddTicks(6276), new DateTime(2022, 5, 26, 11, 44, 18, 938, DateTimeKind.Local).AddTicks(40), "Kristin47@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Karlie Davis", 53, "618.861.8552 x43040", "Schmeler - Jaskolski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 333, new DateTime(2023, 1, 29, 20, 17, 2, 56, DateTimeKind.Local).AddTicks(3056), new DateTime(2022, 5, 1, 20, 28, 1, 396, DateTimeKind.Local).AddTicks(6234), "Kerry8@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ryder Heidenreich", 64, "1-493-533-3508", "Keeling - Prosacco", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 331, new DateTime(2022, 6, 26, 8, 22, 9, 339, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 2, 2, 15, 14, 38, 262, DateTimeKind.Local).AddTicks(7725), "Alfonso.Ullrich@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Dawn Cummings", 54, "(587) 501-2642", "Graham - Gulgowski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 329, new DateTime(2022, 7, 11, 16, 12, 29, 307, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 2, 15, 0, 5, 30, 53, DateTimeKind.Local).AddTicks(1045), "Shannon82@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Isac Roberts", 0, "1-462-849-4909 x0010", "Metz Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 273, new DateTime(2022, 11, 8, 10, 55, 33, 31, DateTimeKind.Local).AddTicks(3175), new DateTime(2022, 12, 26, 0, 31, 11, 335, DateTimeKind.Local).AddTicks(2848), "Tabitha86@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Chaya Bergnaum", 14, "534.353.3880", "Dare - Heathcote", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 275, new DateTime(2022, 7, 26, 22, 45, 41, 192, DateTimeKind.Local).AddTicks(6145), new DateTime(2023, 1, 2, 13, 40, 27, 419, DateTimeKind.Local).AddTicks(5781), "Darla61@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Garrick Pacocha", 5, "867.755.7019", "Hodkiewicz, Feil and Jacobson", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 277, new DateTime(2023, 1, 1, 1, 33, 48, 607, DateTimeKind.Local).AddTicks(2935), new DateTime(2022, 11, 4, 23, 9, 39, 41, DateTimeKind.Local).AddTicks(6693), "Katie.Kshlerin@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Claudie Brown", 33, "1-884-325-5967", "Davis and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 279, new DateTime(2022, 12, 3, 16, 34, 47, 104, DateTimeKind.Local).AddTicks(9199), new DateTime(2022, 3, 19, 6, 45, 56, 806, DateTimeKind.Local).AddTicks(6708), "Molly.Mueller7@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Robyn Walsh", 17, "674-496-1690 x369", "Ledner, Wiza and Ziemann", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 281, new DateTime(2022, 9, 4, 0, 19, 29, 600, DateTimeKind.Local).AddTicks(2703), new DateTime(2022, 8, 28, 7, 50, 59, 309, DateTimeKind.Local).AddTicks(5308), "Yolanda.Jaskolski@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tabitha Volkman", 84, "935-667-3078", "Upton, Graham and Green", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 283, new DateTime(2022, 8, 5, 8, 20, 43, 320, DateTimeKind.Local).AddTicks(7293), new DateTime(2022, 3, 11, 1, 26, 50, 835, DateTimeKind.Local).AddTicks(3587), "Christina95@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Layla Gulgowski", 24, "(483) 209-2052", "Kertzmann, Williamson and Collins", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 285, new DateTime(2022, 12, 29, 15, 27, 52, 897, DateTimeKind.Local).AddTicks(4032), new DateTime(2022, 4, 12, 1, 3, 6, 956, DateTimeKind.Local).AddTicks(8538), "Faye_Kuhic85@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Lambert Kuhn", 41, "473-605-9056 x56202", "Zulauf, Hessel and O'Kon", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 287, new DateTime(2022, 7, 12, 17, 51, 31, 345, DateTimeKind.Local).AddTicks(8032), new DateTime(2022, 10, 4, 10, 4, 35, 274, DateTimeKind.Local).AddTicks(5915), "Jeannette.Gislason@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Logan Roob", 100, "723.838.5313 x86609", "Leannon - Heidenreich", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 289, new DateTime(2022, 7, 25, 13, 57, 44, 924, DateTimeKind.Local).AddTicks(4545), new DateTime(2022, 11, 16, 23, 56, 15, 400, DateTimeKind.Local).AddTicks(5196), "Betty_Bergnaum65@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Keyshawn Farrell", 92, "1-923-302-5734 x8737", "Bashirian, Schuppe and Quigley", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 291, new DateTime(2022, 11, 14, 6, 44, 8, 501, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 12, 28, 5, 12, 47, 568, DateTimeKind.Local).AddTicks(7414), "Michael_Corwin@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Edison Brakus", 40, "818.262.8418", "Rice, Schinner and Dare", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 293, new DateTime(2022, 8, 20, 19, 45, 37, 779, DateTimeKind.Local).AddTicks(2093), new DateTime(2022, 10, 24, 1, 29, 39, 106, DateTimeKind.Local).AddTicks(1443), "Camille_Terry65@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Vance Keebler", 73, "1-488-958-2199", "Dickinson LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 295, new DateTime(2022, 3, 17, 18, 18, 16, 835, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 8, 3, 23, 55, 25, 451, DateTimeKind.Local).AddTicks(469), "Phillip_Kirlin27@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jason Schulist", 15, "829.302.6726", "DuBuque, Pacocha and Ruecker", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 297, new DateTime(2023, 1, 31, 17, 29, 28, 83, DateTimeKind.Local).AddTicks(3851), new DateTime(2022, 4, 27, 19, 36, 10, 933, DateTimeKind.Local).AddTicks(4579), "Rosie.Pollich@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Pat Bogisich", 89, "256-669-9633 x402", "Anderson, Gaylord and Lynch", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 391, new DateTime(2022, 5, 27, 10, 18, 54, 930, DateTimeKind.Local).AddTicks(9669), new DateTime(2022, 4, 8, 8, 47, 16, 100, DateTimeKind.Local).AddTicks(2265), "Dana77@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Johann Gulgowski", 96, "677-783-9070 x471", "Jast, Deckow and MacGyver", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 299, new DateTime(2022, 4, 7, 21, 16, 34, 758, DateTimeKind.Local).AddTicks(2357), new DateTime(2022, 4, 14, 11, 28, 44, 261, DateTimeKind.Local).AddTicks(6349), "Ramona_Mertz@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rex Von", 57, "1-406-405-3091 x2205", "Connelly, Hartmann and Roberts", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 303, new DateTime(2022, 8, 18, 12, 49, 28, 907, DateTimeKind.Local).AddTicks(7137), new DateTime(2022, 10, 18, 4, 8, 10, 298, DateTimeKind.Local).AddTicks(1379), "Omar_Spencer2@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kristy Boehm", 66, "234.204.2551 x664", "Dare Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 305, new DateTime(2022, 8, 11, 10, 57, 55, 133, DateTimeKind.Local).AddTicks(2332), new DateTime(2022, 7, 6, 19, 5, 14, 657, DateTimeKind.Local).AddTicks(9448), "Eunice23@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Felicia Lang", 29, "(955) 786-1885 x2858", "Dietrich - Schiller", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 307, new DateTime(2022, 10, 11, 7, 21, 29, 556, DateTimeKind.Local).AddTicks(5765), new DateTime(2022, 6, 29, 12, 9, 58, 472, DateTimeKind.Local).AddTicks(9370), "Stacey_Metz2@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Eric Lemke", 61, "1-457-684-7724", "Welch - Schmitt", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 309, new DateTime(2022, 11, 27, 21, 15, 24, 221, DateTimeKind.Local).AddTicks(9922), new DateTime(2022, 3, 14, 12, 14, 28, 268, DateTimeKind.Local).AddTicks(9746), "Deanna_Hirthe78@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Amina Lesch", 40, "478.990.5734 x88096", "Breitenberg - Walsh", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 311, new DateTime(2022, 6, 22, 13, 44, 23, 102, DateTimeKind.Local).AddTicks(8102), new DateTime(2022, 7, 15, 2, 59, 33, 468, DateTimeKind.Local).AddTicks(9510), "Enrique_Daugherty47@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Maximilian Lakin", 72, "369-558-0387 x976", "Larson Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 313, new DateTime(2022, 7, 26, 8, 27, 41, 420, DateTimeKind.Local).AddTicks(4979), new DateTime(2022, 9, 20, 21, 41, 55, 19, DateTimeKind.Local).AddTicks(9944), "Anthony5@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Phoebe Bauch", 51, "(951) 921-7343 x97490", "Mertz Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 315, new DateTime(2022, 5, 3, 5, 46, 44, 792, DateTimeKind.Local).AddTicks(6722), new DateTime(2022, 7, 30, 18, 48, 43, 169, DateTimeKind.Local).AddTicks(4886), "Israel.Wolf@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Gerson Roberts", 14, "994-426-8160 x761", "VonRueden - Walter", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 317, new DateTime(2022, 8, 22, 6, 24, 10, 947, DateTimeKind.Local).AddTicks(5644), new DateTime(2022, 11, 7, 8, 58, 41, 34, DateTimeKind.Local).AddTicks(1366), "Jim.Lebsack26@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Andy Morar", 1, "(361) 279-0671", "Smitham LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 319, new DateTime(2022, 8, 25, 2, 44, 56, 313, DateTimeKind.Local).AddTicks(24), new DateTime(2022, 12, 12, 3, 34, 3, 704, DateTimeKind.Local).AddTicks(1057), "Joyce_Reilly@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Nicolette Morissette", 86, "1-608-293-1382", "Fadel, Batz and Tremblay", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 321, new DateTime(2022, 2, 8, 18, 44, 56, 814, DateTimeKind.Local).AddTicks(8131), new DateTime(2022, 8, 15, 17, 23, 57, 940, DateTimeKind.Local).AddTicks(8650), "Florence0@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Reuben Waters", 82, "1-400-316-5347 x6879", "Lind Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 323, new DateTime(2022, 2, 14, 14, 24, 23, 491, DateTimeKind.Local).AddTicks(2928), new DateTime(2022, 7, 29, 5, 19, 45, 884, DateTimeKind.Local).AddTicks(5545), "Roy.Kemmer65@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rachelle Ruecker", 83, "(478) 486-1844", "McGlynn, Kozey and Weimann", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 325, new DateTime(2022, 7, 9, 10, 6, 17, 973, DateTimeKind.Local).AddTicks(9692), new DateTime(2022, 9, 18, 10, 21, 19, 158, DateTimeKind.Local).AddTicks(1294), "Shannon_Yundt2@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Darryl Keebler", 85, "249.355.7049", "Johnson and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 327, new DateTime(2023, 1, 8, 7, 6, 27, 648, DateTimeKind.Local).AddTicks(3692), new DateTime(2022, 8, 3, 18, 17, 14, 526, DateTimeKind.Local).AddTicks(7350), "Bessie_Johns@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Mara Schaefer", 45, "584.554.1848", "Tillman - Durgan", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 301, new DateTime(2022, 5, 29, 1, 34, 28, 739, DateTimeKind.Local).AddTicks(821), new DateTime(2022, 5, 2, 6, 48, 18, 696, DateTimeKind.Local).AddTicks(7370), "Clay_Baumbach79@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Everett Homenick", 71, "(951) 420-2680 x166", "Rath, Kerluke and Grant", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 519, new DateTime(2022, 12, 1, 23, 23, 51, 352, DateTimeKind.Local).AddTicks(3572), new DateTime(2022, 9, 8, 8, 10, 54, 6, DateTimeKind.Local).AddTicks(6918), "Karla.Mueller@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Hilton Rutherford", 26, "(582) 837-2656", "Hegmann and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 393, new DateTime(2022, 5, 6, 7, 2, 28, 685, DateTimeKind.Local).AddTicks(7898), new DateTime(2022, 4, 15, 19, 50, 4, 851, DateTimeKind.Local).AddTicks(9362), "Sherri_Morissette49@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Easter Gleason", 4, "600.558.6474 x133", "Kirlin - Corkery", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 397, new DateTime(2023, 2, 2, 5, 34, 41, 706, DateTimeKind.Local).AddTicks(8851), new DateTime(2022, 8, 1, 23, 21, 46, 524, DateTimeKind.Local).AddTicks(2513), "Jo_Hills71@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Robin Herman", 94, "702-524-6253", "Kling, Wiegand and Hoppe", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 463, new DateTime(2022, 4, 19, 22, 19, 15, 35, DateTimeKind.Local).AddTicks(9255), new DateTime(2022, 5, 14, 19, 54, 29, 785, DateTimeKind.Local).AddTicks(9416), "Moses_Kuvalis@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Carlo Walker", 52, "1-623-289-9336", "Crona, Frami and Powlowski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 465, new DateTime(2022, 4, 28, 23, 28, 34, 38, DateTimeKind.Local).AddTicks(5904), new DateTime(2022, 4, 18, 0, 41, 2, 4, DateTimeKind.Local).AddTicks(8575), "Janice22@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Terence Williamson", 25, "823-731-6062", "Jacobi Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 467, new DateTime(2022, 11, 1, 11, 4, 58, 839, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 3, 4, 8, 6, 57, 247, DateTimeKind.Local).AddTicks(3857), "Roberto_Carter80@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Wilbert Sauer", 24, "266-957-8086", "Sipes Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 469, new DateTime(2022, 5, 23, 7, 15, 13, 579, DateTimeKind.Local).AddTicks(4993), new DateTime(2022, 12, 13, 15, 2, 55, 288, DateTimeKind.Local).AddTicks(1926), "Sonia_Klocko65@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Maribel Willms", 81, "(471) 425-9809 x21156", "Marks, Will and Harvey", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 471, new DateTime(2022, 5, 22, 1, 19, 48, 780, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 3, 19, 15, 32, 37, 975, DateTimeKind.Local).AddTicks(7109), "Stephen37@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sibyl Kling", 23, "422-358-9394 x391", "Schiller LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 473, new DateTime(2022, 12, 1, 11, 36, 58, 563, DateTimeKind.Local).AddTicks(9208), new DateTime(2022, 7, 14, 21, 13, 19, 945, DateTimeKind.Local).AddTicks(5204), "Alicia31@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kacey Rodriguez", 75, "761.219.1562 x227", "Jaskolski Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 475, new DateTime(2022, 7, 21, 10, 3, 58, 7, DateTimeKind.Local).AddTicks(1777), new DateTime(2022, 4, 16, 9, 29, 59, 976, DateTimeKind.Local).AddTicks(5258), "Claire_Terry18@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jocelyn Douglas", 33, "1-745-685-3895 x453", "Reichel - Franecki", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 477, new DateTime(2022, 5, 1, 13, 48, 28, 60, DateTimeKind.Local).AddTicks(773), new DateTime(2022, 12, 26, 4, 49, 58, 781, DateTimeKind.Local).AddTicks(4101), "Jamie.Murazik85@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Stephania Grant", 48, "(595) 304-8300", "Hoeger, Kuhlman and Mohr", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 479, new DateTime(2022, 6, 17, 0, 38, 55, 863, DateTimeKind.Local).AddTicks(5143), new DateTime(2022, 3, 30, 2, 16, 48, 953, DateTimeKind.Local).AddTicks(352), "Eileen.Fritsch34@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rosamond Metz", 13, "(999) 568-9261 x3546", "Gleason LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 481, new DateTime(2022, 4, 3, 7, 57, 25, 255, DateTimeKind.Local).AddTicks(5333), new DateTime(2022, 12, 12, 18, 0, 34, 323, DateTimeKind.Local).AddTicks(7985), "Tabitha32@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Geraldine Franecki", 45, "292-487-4156 x8179", "Brakus - Schiller", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 483, new DateTime(2022, 8, 7, 19, 12, 55, 545, DateTimeKind.Local).AddTicks(930), new DateTime(2022, 5, 12, 6, 51, 28, 228, DateTimeKind.Local).AddTicks(9447), "Amy53@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Trey Volkman", 47, "1-408-609-1397", "Schmeler - Ledner", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 485, new DateTime(2022, 7, 15, 2, 4, 57, 494, DateTimeKind.Local).AddTicks(4239), new DateTime(2023, 1, 5, 18, 54, 46, 176, DateTimeKind.Local).AddTicks(6099), "Margarita69@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tavares Corkery", 79, "(762) 663-7242", "Mann, Purdy and Mann", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 487, new DateTime(2022, 4, 13, 18, 18, 33, 805, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 3, 8, 6, 28, 38, 709, DateTimeKind.Local).AddTicks(7014), "Ramiro_Jones@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Quinten Bayer", 80, "1-980-538-3364", "Schinner - Frami", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 489, new DateTime(2022, 9, 24, 16, 37, 30, 817, DateTimeKind.Local).AddTicks(2333), new DateTime(2022, 7, 9, 22, 43, 31, 168, DateTimeKind.Local).AddTicks(558), "Norma.Ortiz@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Edwin Lang", 39, "1-956-623-5298", "Moore, Schimmel and Schamberger", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 491, new DateTime(2022, 3, 19, 7, 50, 16, 569, DateTimeKind.Local).AddTicks(7013), new DateTime(2022, 8, 21, 9, 24, 10, 808, DateTimeKind.Local).AddTicks(9477), "Wilfred_Lubowitz@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sarina Hammes", 3, "1-691-730-9693", "Casper - Carroll", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 493, new DateTime(2022, 2, 25, 12, 20, 31, 668, DateTimeKind.Local).AddTicks(8713), new DateTime(2022, 12, 15, 23, 3, 39, 53, DateTimeKind.Local).AddTicks(2277), "Teri_Runolfsdottir@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Fidel Lowe", 70, "(306) 971-1389 x271", "Koelpin - Robel", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 495, new DateTime(2022, 12, 30, 20, 52, 36, 793, DateTimeKind.Local).AddTicks(669), new DateTime(2022, 10, 1, 19, 14, 29, 651, DateTimeKind.Local).AddTicks(6371), "Dominic_OKon28@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Shaun Labadie", 93, "569.631.4156", "Mante, Upton and Jacobson", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 497, new DateTime(2022, 11, 11, 12, 46, 48, 104, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 7, 24, 18, 32, 33, 98, DateTimeKind.Local).AddTicks(2976), "Randal_Bosco39@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Leola Olson", 42, "1-325-763-4127 x0607", "Green, Gulgowski and Lesch", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 499, new DateTime(2022, 7, 3, 12, 46, 17, 666, DateTimeKind.Local).AddTicks(1450), new DateTime(2022, 4, 10, 1, 21, 41, 395, DateTimeKind.Local).AddTicks(9204), "Irving.Stoltenberg53@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Demetrius Nolan", 29, "(985) 642-6310", "Shields, Daniel and Yundt", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 501, new DateTime(2022, 9, 10, 10, 7, 6, 26, DateTimeKind.Local).AddTicks(5536), new DateTime(2022, 6, 12, 4, 15, 38, 975, DateTimeKind.Local).AddTicks(3712), "Helen81@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "General Miller", 5, "1-716-877-6857 x19015", "McDermott LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 503, new DateTime(2023, 1, 14, 4, 49, 18, 784, DateTimeKind.Local).AddTicks(2996), new DateTime(2022, 9, 16, 17, 10, 15, 762, DateTimeKind.Local).AddTicks(3104), "Kelly25@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Clotilde Torphy", 83, "442.362.5775 x1974", "Hane - Moore", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 505, new DateTime(2023, 1, 16, 12, 22, 13, 528, DateTimeKind.Local).AddTicks(1971), new DateTime(2022, 5, 8, 10, 22, 39, 797, DateTimeKind.Local).AddTicks(7354), "Clark.Aufderhar@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ruby Cartwright", 31, "1-340-531-9684", "Beier LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 507, new DateTime(2022, 4, 18, 12, 59, 40, 431, DateTimeKind.Local).AddTicks(5528), new DateTime(2022, 6, 8, 17, 47, 26, 227, DateTimeKind.Local).AddTicks(126), "Barry.Corkery@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Luther Orn", 49, "(871) 762-9823", "Blick - Fahey", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 509, new DateTime(2022, 9, 13, 19, 53, 43, 919, DateTimeKind.Local).AddTicks(5491), new DateTime(2022, 10, 14, 8, 8, 39, 465, DateTimeKind.Local).AddTicks(6042), "Jack.Cruickshank61@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Marguerite Mraz", 12, "500.605.2224", "Flatley Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 511, new DateTime(2022, 6, 7, 2, 52, 2, 601, DateTimeKind.Local).AddTicks(4471), new DateTime(2022, 4, 23, 21, 51, 57, 589, DateTimeKind.Local).AddTicks(342), "Guillermo.Anderson@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Agustin Ferry", 14, "(638) 507-1514 x753", "Brekke, Marquardt and Smith", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 513, new DateTime(2022, 10, 7, 16, 9, 16, 821, DateTimeKind.Local).AddTicks(5947), new DateTime(2022, 7, 15, 10, 49, 58, 231, DateTimeKind.Local).AddTicks(495), "Jeffery.Wyman@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Terry Luettgen", 96, "728-695-5914 x88915", "Heller, Koelpin and Marquardt", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 515, new DateTime(2022, 7, 29, 17, 15, 12, 192, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 7, 11, 20, 24, 21, 907, DateTimeKind.Local).AddTicks(4537), "Marlene16@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Chauncey Trantow", 48, "325-827-6327", "Ebert Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 461, new DateTime(2022, 4, 12, 16, 31, 57, 970, DateTimeKind.Local).AddTicks(6767), new DateTime(2022, 10, 22, 23, 0, 47, 88, DateTimeKind.Local).AddTicks(3724), "Mack_Oberbrunner@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tito Hahn", 92, "416.274.4510", "Hansen Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 459, new DateTime(2022, 10, 4, 21, 35, 51, 625, DateTimeKind.Local).AddTicks(7699), new DateTime(2022, 7, 23, 9, 37, 17, 46, DateTimeKind.Local).AddTicks(1607), "Anthony1@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Reuben Hand", 49, "(464) 658-8768 x941", "Swaniawski Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 457, new DateTime(2022, 4, 24, 13, 37, 38, 772, DateTimeKind.Local).AddTicks(2201), new DateTime(2022, 3, 22, 20, 50, 17, 286, DateTimeKind.Local).AddTicks(7003), "Julian_Wilkinson@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Faye Jaskolski", 91, "540.230.8089 x5793", "Ziemann - Beahan", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 455, new DateTime(2022, 3, 8, 0, 47, 26, 225, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 2, 2, 3, 6, 57, 956, DateTimeKind.Local).AddTicks(7269), "Sonia34@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Mary Bauch", 68, "310.969.3307", "Hickle Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 271, new DateTime(2022, 3, 22, 22, 50, 34, 362, DateTimeKind.Local).AddTicks(4875), new DateTime(2022, 7, 26, 23, 46, 52, 507, DateTimeKind.Local).AddTicks(837), "Forrest.Sanford@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Estell Spinka", 93, "732-295-3761", "Schumm, Krajcik and Collier", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 401, new DateTime(2022, 7, 19, 2, 38, 4, 439, DateTimeKind.Local).AddTicks(7287), new DateTime(2022, 5, 11, 15, 34, 22, 446, DateTimeKind.Local).AddTicks(1919), "Ignacio_Nader@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ubaldo Gibson", 58, "892-306-8317", "Mann Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 403, new DateTime(2023, 1, 22, 14, 58, 11, 178, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 1, 25, 0, 35, 1, 204, DateTimeKind.Local).AddTicks(3151), "Harold.Orn@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Raphaelle Barrows", 96, "(205) 324-0757", "Tromp, Reichert and Wyman", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 405, new DateTime(2022, 2, 21, 9, 24, 32, 676, DateTimeKind.Local).AddTicks(2501), new DateTime(2022, 12, 28, 9, 26, 24, 271, DateTimeKind.Local).AddTicks(9628), "Tracey_Stark16@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ulices Ullrich", 40, "518.978.5715 x24103", "Goodwin, Kirlin and Von", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 407, new DateTime(2023, 1, 30, 8, 13, 1, 333, DateTimeKind.Local).AddTicks(4824), new DateTime(2022, 11, 29, 7, 15, 34, 758, DateTimeKind.Local).AddTicks(5168), "Elias35@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Drake Zulauf", 36, "514.277.3571", "Haag Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 409, new DateTime(2022, 10, 27, 20, 27, 50, 568, DateTimeKind.Local).AddTicks(6316), new DateTime(2022, 4, 20, 2, 39, 44, 740, DateTimeKind.Local).AddTicks(4412), "Verna50@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Verona Kutch", 72, "973-631-3010", "Brekke LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 411, new DateTime(2022, 8, 22, 5, 12, 48, 373, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 2, 9, 14, 37, 28, 488, DateTimeKind.Local).AddTicks(7834), "Kay_Zieme@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Clay Rohan", 67, "609-470-0414 x9811", "Aufderhar Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 413, new DateTime(2023, 1, 20, 5, 26, 24, 939, DateTimeKind.Local).AddTicks(8402), new DateTime(2022, 4, 26, 3, 53, 50, 937, DateTimeKind.Local).AddTicks(8824), "Rickey_Zboncak3@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sister Wuckert", 48, "344.461.4397 x6412", "Spinka LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 415, new DateTime(2022, 6, 9, 8, 16, 27, 311, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 1, 1, 3, 1, 47, 695, DateTimeKind.Local).AddTicks(1523), "Levi.Franecki@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Fritz Altenwerth", 26, "(760) 325-8881 x7737", "Willms, Keeling and Sauer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 417, new DateTime(2022, 5, 20, 13, 25, 50, 239, DateTimeKind.Local).AddTicks(4832), new DateTime(2022, 10, 21, 4, 55, 27, 257, DateTimeKind.Local).AddTicks(3551), "Bruce.Breitenberg@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kayleigh Rowe", 22, "654-738-1221", "Price, Marquardt and Dicki", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 419, new DateTime(2022, 10, 29, 15, 58, 16, 613, DateTimeKind.Local).AddTicks(4337), new DateTime(2022, 12, 9, 19, 11, 37, 213, DateTimeKind.Local).AddTicks(8896), "Marc6@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Dudley Rippin", 46, "(536) 398-9135 x74575", "Bednar - Reichel", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 421, new DateTime(2022, 12, 15, 4, 24, 52, 119, DateTimeKind.Local).AddTicks(6072), new DateTime(2022, 6, 26, 14, 32, 40, 931, DateTimeKind.Local).AddTicks(431), "Horace.Johnston41@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Payton King", 70, "468-652-9067 x11261", "Douglas, Ferry and Moen", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 423, new DateTime(2022, 7, 16, 8, 17, 3, 324, DateTimeKind.Local).AddTicks(6586), new DateTime(2022, 12, 16, 0, 23, 47, 231, DateTimeKind.Local).AddTicks(9337), "Tammy_Hintz13@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Hillard Rempel", 45, "(702) 747-6182 x012", "Strosin, Gorczany and Jacobs", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 395, new DateTime(2022, 9, 30, 18, 16, 29, 210, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 6, 19, 19, 21, 18, 507, DateTimeKind.Local).AddTicks(9831), "Ana.Schuppe65@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Joseph Hayes", 26, "(276) 284-6681", "Jast, Reilly and Marvin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 425, new DateTime(2023, 2, 5, 18, 16, 0, 915, DateTimeKind.Local).AddTicks(7827), new DateTime(2022, 8, 20, 12, 36, 57, 524, DateTimeKind.Local).AddTicks(3232), "Darrell.Daniel92@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Althea Rempel", 80, "(321) 515-0917 x6189", "Runte, Spinka and Ondricka", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 429, new DateTime(2022, 12, 1, 17, 24, 22, 532, DateTimeKind.Local).AddTicks(9544), new DateTime(2022, 9, 25, 7, 26, 24, 737, DateTimeKind.Local).AddTicks(7835), "George.Langosh35@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Reynold McCullough", 52, "673-677-2172 x0704", "Okuneva - Schoen", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 431, new DateTime(2022, 3, 22, 18, 14, 49, 141, DateTimeKind.Local).AddTicks(7220), new DateTime(2022, 11, 6, 12, 8, 6, 587, DateTimeKind.Local).AddTicks(8643), "Emily.Rosenbaum71@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Angeline Schimmel", 86, "977.208.0979 x0728", "Gaylord, Waters and Koelpin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 433, new DateTime(2022, 10, 7, 21, 6, 5, 428, DateTimeKind.Local).AddTicks(9034), new DateTime(2022, 8, 15, 14, 26, 2, 312, DateTimeKind.Local).AddTicks(6865), "Salvador.Zulauf90@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Niko Padberg", 54, "452.732.9344", "Prosacco, Sawayn and Jones", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 435, new DateTime(2022, 9, 27, 16, 25, 10, 134, DateTimeKind.Local).AddTicks(7055), new DateTime(2022, 12, 2, 14, 12, 26, 782, DateTimeKind.Local).AddTicks(1534), "Jacqueline.Lubowitz19@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Raymond Balistreri", 16, "742-878-9878 x4203", "Schiller, Cremin and Jones", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 437, new DateTime(2022, 3, 15, 17, 11, 22, 298, DateTimeKind.Local).AddTicks(394), new DateTime(2022, 11, 11, 10, 54, 25, 362, DateTimeKind.Local).AddTicks(5216), "Irving_OKeefe96@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Carey Strosin", 56, "664-875-0316", "Blanda, Kuvalis and Turner", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 439, new DateTime(2023, 1, 10, 18, 34, 34, 421, DateTimeKind.Local).AddTicks(6324), new DateTime(2022, 11, 30, 23, 42, 40, 260, DateTimeKind.Local).AddTicks(3116), "Gabriel_Berge@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sheridan Rowe", 95, "891-526-5692", "Rowe - Rippin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 441, new DateTime(2022, 7, 24, 10, 14, 17, 899, DateTimeKind.Local).AddTicks(1471), new DateTime(2023, 2, 3, 4, 35, 27, 910, DateTimeKind.Local).AddTicks(5511), "Allen.Sipes@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Mervin Wisozk", 92, "498.595.8904", "Feeney, Aufderhar and Beier", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 443, new DateTime(2022, 6, 29, 23, 33, 37, 10, DateTimeKind.Local).AddTicks(8476), new DateTime(2022, 7, 9, 3, 18, 6, 288, DateTimeKind.Local).AddTicks(3481), "Charlie_Medhurst@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Theodore Green", 95, "486-878-9100 x46615", "Roob Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 445, new DateTime(2022, 9, 15, 14, 54, 30, 667, DateTimeKind.Local).AddTicks(9997), new DateTime(2022, 3, 28, 16, 16, 2, 417, DateTimeKind.Local).AddTicks(308), "Eileen.Kilback22@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Celia Lesch", 38, "810.889.0652 x73167", "Bauch - Corkery", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 447, new DateTime(2022, 7, 2, 1, 25, 31, 852, DateTimeKind.Local).AddTicks(1811), new DateTime(2022, 6, 7, 5, 42, 49, 337, DateTimeKind.Local).AddTicks(5321), "Eric_Lebsack80@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Elvera Greenfelder", 19, "832-839-8438 x611", "Brekke and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 449, new DateTime(2022, 4, 29, 10, 46, 38, 105, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 1, 6, 22, 57, 35, 536, DateTimeKind.Local).AddTicks(7701), "Amelia70@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Peter Kuhic", 78, "467-869-5460 x45008", "Hessel Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 451, new DateTime(2022, 11, 4, 6, 22, 33, 742, DateTimeKind.Local).AddTicks(3277), new DateTime(2022, 7, 24, 0, 3, 45, 953, DateTimeKind.Local).AddTicks(9522), "Mildred.Nicolas59@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Heath Yost", 73, "(267) 235-8363 x59191", "Parker Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 453, new DateTime(2022, 9, 10, 23, 58, 4, 127, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 7, 26, 16, 56, 9, 942, DateTimeKind.Local).AddTicks(4455), "Forrest_Wisoky@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Eldred Friesen", 47, "223.849.7228 x87584", "Huels, Lindgren and Zemlak", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 427, new DateTime(2022, 8, 21, 13, 21, 19, 612, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 8, 6, 2, 18, 42, 342, DateTimeKind.Local).AddTicks(8031), "Gloria_Hane51@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Marilie Schiller", 92, "955-510-4660 x5862", "Larson, Ferry and Hyatt", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 399, new DateTime(2023, 1, 1, 8, 56, 5, 351, DateTimeKind.Local).AddTicks(7628), new DateTime(2022, 7, 4, 14, 8, 10, 862, DateTimeKind.Local).AddTicks(2493), "Betsy.Durgan25@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Irwin Douglas", 95, "215.818.3556 x91914", "Crist - Dooley", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 269, new DateTime(2022, 7, 27, 22, 26, 46, 840, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 2, 10, 5, 38, 43, 554, DateTimeKind.Local).AddTicks(3681), "Jacob.Goldner95@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Darrell Welch", 47, "523-364-3284 x6810", "Deckow Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 265, new DateTime(2022, 2, 14, 13, 26, 42, 738, DateTimeKind.Local).AddTicks(7860), new DateTime(2022, 7, 19, 13, 26, 9, 383, DateTimeKind.Local).AddTicks(3486), "Lawrence.Botsford40@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Eden Welch", 80, "388.218.7451", "Goldner - Leffler", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 79, new DateTime(2022, 4, 7, 22, 1, 53, 868, DateTimeKind.Local).AddTicks(5412), new DateTime(2022, 2, 10, 23, 20, 24, 862, DateTimeKind.Local).AddTicks(8299), "Jill.Lubowitz9@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Cedrick Zieme", 17, "576.698.5351", "Reynolds - Rath", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 81, new DateTime(2022, 5, 28, 13, 35, 18, 575, DateTimeKind.Local).AddTicks(4924), new DateTime(2022, 4, 29, 21, 41, 37, 349, DateTimeKind.Local).AddTicks(6166), "Casey.Hintz27@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Myrtie King", 70, "1-571-357-6359 x30006", "Conroy - Glover", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 83, new DateTime(2022, 3, 4, 11, 37, 30, 223, DateTimeKind.Local).AddTicks(188), new DateTime(2022, 5, 5, 21, 13, 53, 15, DateTimeKind.Local).AddTicks(8059), "Vernon.Boehm93@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kole Dickens", 35, "(532) 504-7897", "Jacobson Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 85, new DateTime(2022, 8, 2, 7, 38, 22, 241, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 5, 18, 2, 56, 44, 528, DateTimeKind.Local).AddTicks(520), "Matthew.Predovic@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Laverna Stiedemann", 14, "423-318-4843 x88283", "Thiel - Leffler", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 87, new DateTime(2022, 6, 24, 10, 13, 41, 885, DateTimeKind.Local).AddTicks(9800), new DateTime(2022, 7, 13, 8, 19, 47, 46, DateTimeKind.Local).AddTicks(6852), "Jennie51@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ebony Jacobson", 56, "629.674.3628", "Stoltenberg, Klocko and Denesik", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 89, new DateTime(2022, 11, 3, 5, 9, 28, 329, DateTimeKind.Local).AddTicks(8599), new DateTime(2022, 6, 27, 3, 21, 34, 956, DateTimeKind.Local).AddTicks(5303), "Lynn68@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Cora Beahan", 84, "272.202.7578", "Nicolas Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 91, new DateTime(2022, 9, 12, 0, 6, 0, 896, DateTimeKind.Local).AddTicks(624), new DateTime(2022, 6, 25, 18, 51, 36, 667, DateTimeKind.Local).AddTicks(5415), "Tabitha_Wilkinson@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sophia Mayert", 14, "471.835.2130", "Hegmann and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 93, new DateTime(2022, 10, 1, 19, 56, 18, 51, DateTimeKind.Local).AddTicks(1660), new DateTime(2022, 11, 17, 0, 20, 15, 474, DateTimeKind.Local).AddTicks(5886), "Josefina69@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Melissa Vandervort", 75, "(475) 991-0622 x9606", "Kris - Wintheiser", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 95, new DateTime(2023, 1, 31, 3, 45, 42, 363, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 10, 3, 22, 59, 38, 588, DateTimeKind.Local).AddTicks(2679), "Daniel.Kub@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Dominic Maggio", 5, "(940) 633-7329 x08857", "Hermiston, Hegmann and Reichert", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 97, new DateTime(2022, 11, 8, 3, 2, 51, 866, DateTimeKind.Local).AddTicks(9836), new DateTime(2022, 11, 19, 7, 13, 49, 518, DateTimeKind.Local).AddTicks(3266), "Shannon.Swaniawski16@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Harmon Ondricka", 46, "(693) 421-0605 x7523", "Langworth and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 99, new DateTime(2022, 10, 19, 13, 36, 30, 386, DateTimeKind.Local).AddTicks(1528), new DateTime(2022, 9, 18, 2, 33, 15, 73, DateTimeKind.Local).AddTicks(5713), "Malcolm_Pouros@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Deshaun Kuhlman", 66, "1-778-206-5091 x19698", "Spinka - Crona", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 101, new DateTime(2022, 8, 4, 9, 25, 59, 224, DateTimeKind.Local).AddTicks(7119), new DateTime(2022, 9, 3, 23, 18, 2, 726, DateTimeKind.Local).AddTicks(6351), "David.Bogan@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Verona Flatley", 99, "(830) 574-0778", "Wuckert, Harris and Champlin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 103, new DateTime(2022, 7, 28, 4, 24, 52, 80, DateTimeKind.Local).AddTicks(618), new DateTime(2022, 5, 20, 3, 18, 27, 74, DateTimeKind.Local).AddTicks(4438), "Gerald.Wintheiser87@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Emie Batz", 52, "1-867-575-9344", "Cruickshank Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 77, new DateTime(2022, 12, 3, 9, 19, 30, 401, DateTimeKind.Local).AddTicks(8717), new DateTime(2022, 3, 18, 8, 9, 31, 18, DateTimeKind.Local).AddTicks(1329), "Connie.Spencer@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Whitney Barrows", 9, "501-767-0034 x3569", "Beatty LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 105, new DateTime(2022, 12, 12, 6, 19, 38, 51, DateTimeKind.Local).AddTicks(4530), new DateTime(2022, 7, 5, 8, 31, 40, 580, DateTimeKind.Local).AddTicks(337), "Winston_Daugherty@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Lonny Spinka", 46, "1-226-350-5868", "Mills, Quigley and Gutkowski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 109, new DateTime(2022, 7, 21, 15, 39, 43, 720, DateTimeKind.Local).AddTicks(4223), new DateTime(2022, 5, 18, 7, 30, 41, 783, DateTimeKind.Local).AddTicks(1773), "Misty_Langosh@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Juanita Bartoletti", 61, "(838) 796-6929 x15910", "Hettinger, Roberts and Jacobi", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 111, new DateTime(2022, 6, 27, 8, 3, 19, 34, DateTimeKind.Local).AddTicks(2335), new DateTime(2022, 12, 23, 14, 59, 40, 16, DateTimeKind.Local).AddTicks(1452), "Carlos.Deckow@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Hugh Johns", 59, "990.889.4013 x3243", "Schulist, Greenholt and Boyer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 113, new DateTime(2022, 12, 19, 18, 26, 30, 587, DateTimeKind.Local).AddTicks(7167), new DateTime(2022, 6, 27, 2, 57, 31, 405, DateTimeKind.Local).AddTicks(6574), "Lydia71@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Shayne Cronin", 64, "874-642-4790 x940", "Hand - Stamm", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 115, new DateTime(2022, 3, 28, 10, 56, 3, 668, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 2, 4, 15, 42, 42, 920, DateTimeKind.Local).AddTicks(110), "Jessica69@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tomasa Friesen", 80, "(933) 310-1688", "Hoeger, Zboncak and Beier", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 117, new DateTime(2022, 9, 21, 2, 31, 8, 587, DateTimeKind.Local).AddTicks(6206), new DateTime(2022, 4, 26, 10, 22, 9, 618, DateTimeKind.Local).AddTicks(298), "John41@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Claire Champlin", 29, "580.944.9600 x9406", "Runolfsdottir LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 119, new DateTime(2022, 10, 24, 21, 24, 8, 758, DateTimeKind.Local).AddTicks(5572), new DateTime(2022, 10, 5, 18, 59, 13, 860, DateTimeKind.Local).AddTicks(5910), "Winifred30@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Scotty O'Connell", 86, "(634) 359-6808 x383", "Kuvalis - O'Reilly", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 121, new DateTime(2022, 9, 23, 13, 46, 6, 679, DateTimeKind.Local).AddTicks(4575), new DateTime(2022, 3, 29, 19, 43, 30, 892, DateTimeKind.Local).AddTicks(5032), "Christian_Rempel32@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Filiberto Homenick", 1, "(610) 884-4094", "Wolf, Connelly and Bechtelar", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 123, new DateTime(2022, 7, 17, 18, 54, 22, 2, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 4, 20, 13, 54, 19, 530, DateTimeKind.Local).AddTicks(6636), "Elena.Beahan23@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Adam Rosenbaum", 46, "217.436.9585 x1493", "Stanton - Wolff", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 125, new DateTime(2022, 5, 18, 16, 35, 29, 673, DateTimeKind.Local).AddTicks(9143), new DateTime(2022, 6, 2, 15, 0, 15, 180, DateTimeKind.Local).AddTicks(5288), "Angel11@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Noemi Shields", 36, "(514) 776-8245", "Wyman - Kris", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 127, new DateTime(2022, 8, 19, 18, 5, 17, 662, DateTimeKind.Local).AddTicks(7463), new DateTime(2022, 6, 7, 21, 15, 47, 738, DateTimeKind.Local).AddTicks(2395), "Ronald50@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Marlene Abernathy", 0, "(825) 826-8703 x008", "Gerlach - Harvey", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 129, new DateTime(2022, 5, 26, 21, 0, 25, 914, DateTimeKind.Local).AddTicks(1693), new DateTime(2022, 3, 20, 4, 39, 56, 608, DateTimeKind.Local).AddTicks(8222), "Lana.Boyer@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Loy Cummings", 45, "437-638-5496 x62371", "Rodriguez - Roberts", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 131, new DateTime(2023, 1, 11, 14, 31, 44, 350, DateTimeKind.Local).AddTicks(1871), new DateTime(2022, 9, 12, 1, 0, 18, 339, DateTimeKind.Local).AddTicks(3294), "Ellis_Veum49@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bailey Stoltenberg", 65, "605-496-2635 x014", "Stracke Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 133, new DateTime(2022, 7, 11, 10, 50, 28, 362, DateTimeKind.Local).AddTicks(6045), new DateTime(2022, 11, 20, 18, 28, 24, 819, DateTimeKind.Local).AddTicks(7638), "Cecilia_Wisozk@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alexanne Romaguera", 59, "858-598-5671 x11535", "Lueilwitz, Kunde and Daugherty", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 107, new DateTime(2022, 6, 1, 17, 58, 24, 866, DateTimeKind.Local).AddTicks(6645), new DateTime(2022, 8, 20, 12, 32, 58, 430, DateTimeKind.Local).AddTicks(596), "Dawn17@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Annamae Dickens", 8, "1-281-447-0486 x984", "Barton - Rice", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 75, new DateTime(2022, 3, 13, 16, 1, 12, 456, DateTimeKind.Local).AddTicks(4191), new DateTime(2022, 5, 6, 13, 11, 35, 430, DateTimeKind.Local).AddTicks(460), "Robin.Kassulke@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Valerie Rempel", 88, "419.532.7669 x76969", "Borer Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 73, new DateTime(2022, 5, 24, 5, 0, 15, 393, DateTimeKind.Local).AddTicks(824), new DateTime(2022, 9, 6, 3, 47, 54, 518, DateTimeKind.Local).AddTicks(4435), "Roosevelt_Swift@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jessika Muller", 30, "1-349-814-7271 x94305", "Walsh, Bergstrom and Swaniawski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 71, new DateTime(2022, 4, 8, 19, 55, 35, 503, DateTimeKind.Local).AddTicks(937), new DateTime(2022, 5, 23, 15, 28, 28, 956, DateTimeKind.Local).AddTicks(7731), "Deanna.Mayert@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Johan Hamill", 70, "1-422-649-7794 x150", "Ward, Streich and Cormier", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 13, new DateTime(2022, 5, 9, 19, 45, 24, 732, DateTimeKind.Local).AddTicks(776), new DateTime(2022, 4, 4, 23, 50, 47, 176, DateTimeKind.Local).AddTicks(9036), "Clay15@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Armando Ondricka", 51, "(465) 359-4145 x29132", "Steuber - Marks", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 15, new DateTime(2022, 12, 14, 16, 19, 2, 362, DateTimeKind.Local).AddTicks(8274), new DateTime(2022, 10, 28, 16, 40, 2, 189, DateTimeKind.Local).AddTicks(9963), "Fernando.Volkman@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jose Considine", 9, "266.334.1136 x1296", "Moen - Schmeler", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 17, new DateTime(2022, 3, 16, 13, 23, 30, 122, DateTimeKind.Local).AddTicks(903), new DateTime(2022, 11, 15, 13, 32, 7, 518, DateTimeKind.Local).AddTicks(5154), "Marcus63@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Daija Bernhard", 53, "(200) 342-7777", "Steuber, Rodriguez and Kassulke", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 19, new DateTime(2022, 3, 14, 0, 46, 44, 439, DateTimeKind.Local).AddTicks(7706), new DateTime(2022, 7, 24, 8, 6, 43, 642, DateTimeKind.Local).AddTicks(3822), "Justin89@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Perry MacGyver", 98, "1-602-914-1347", "Beahan, Altenwerth and Wyman", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 21, new DateTime(2023, 1, 6, 8, 24, 32, 902, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 1, 25, 9, 57, 39, 816, DateTimeKind.Local).AddTicks(9198), "Marianne.Treutel@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Fausto Monahan", 18, "500.597.3049 x680", "Rippin - Gulgowski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 23, new DateTime(2022, 9, 5, 15, 15, 8, 67, DateTimeKind.Local).AddTicks(3797), new DateTime(2022, 11, 5, 16, 33, 8, 892, DateTimeKind.Local).AddTicks(4579), "Tomas.Romaguera67@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kendall Quigley", 73, "(231) 351-1436 x68722", "Kovacek, Jones and Ritchie", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 25, new DateTime(2022, 5, 21, 16, 48, 46, 79, DateTimeKind.Local).AddTicks(2289), new DateTime(2022, 2, 9, 2, 23, 8, 556, DateTimeKind.Local).AddTicks(1081), "Randal_Pouros@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Mabelle Torp", 7, "322.626.2508", "Ankunding - Kuhn", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 27, new DateTime(2023, 1, 31, 16, 39, 20, 125, DateTimeKind.Local).AddTicks(4221), new DateTime(2022, 10, 5, 6, 19, 32, 300, DateTimeKind.Local).AddTicks(7618), "Stuart.Armstrong16@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Elenor Leffler", 6, "(352) 415-1250 x1522", "Murray - Skiles", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 29, new DateTime(2022, 3, 6, 9, 15, 4, 572, DateTimeKind.Local).AddTicks(2246), new DateTime(2022, 11, 28, 9, 48, 31, 46, DateTimeKind.Local).AddTicks(8257), "Elsie17@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Zoila Berge", 83, "336-592-6549 x643", "Kshlerin, Skiles and Wuckert", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 31, new DateTime(2022, 3, 5, 15, 12, 18, 641, DateTimeKind.Local).AddTicks(6253), new DateTime(2022, 8, 5, 9, 50, 46, 220, DateTimeKind.Local).AddTicks(8157), "Flora_Langosh71@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Brittany Harris", 88, "1-941-263-5295 x161", "Wisozk, Hane and Windler", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 33, new DateTime(2022, 11, 7, 1, 18, 57, 971, DateTimeKind.Local).AddTicks(1968), new DateTime(2022, 7, 15, 0, 28, 12, 733, DateTimeKind.Local).AddTicks(6809), "Ricardo.Gleason12@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jonatan Towne", 76, "(973) 277-4630 x686", "O'Kon, Daniel and Carter", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 35, new DateTime(2022, 12, 14, 14, 28, 54, 39, DateTimeKind.Local).AddTicks(6508), new DateTime(2023, 1, 26, 5, 49, 33, 221, DateTimeKind.Local).AddTicks(3417), "Audrey.Moore79@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alf Wintheiser", 49, "1-561-307-9918", "Purdy Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 37, new DateTime(2022, 12, 26, 16, 19, 23, 434, DateTimeKind.Local).AddTicks(7915), new DateTime(2022, 9, 2, 11, 38, 1, 211, DateTimeKind.Local).AddTicks(1794), "Greg.Shanahan15@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Craig Windler", 81, "1-604-754-7504 x4029", "Stamm - Okuneva", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 39, new DateTime(2022, 4, 24, 3, 39, 40, 167, DateTimeKind.Local).AddTicks(8579), new DateTime(2022, 7, 16, 2, 34, 24, 419, DateTimeKind.Local).AddTicks(4468), "Margaret.Greenfelder40@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Toby VonRueden", 33, "(606) 476-2481 x9288", "Ryan Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 41, new DateTime(2022, 12, 15, 14, 36, 35, 305, DateTimeKind.Local).AddTicks(5114), new DateTime(2022, 7, 1, 14, 3, 16, 127, DateTimeKind.Local).AddTicks(4670), "Bernadette.Weimann@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Katrine Watsica", 11, "(777) 213-1743 x34095", "Graham, Hickle and Kovacek", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 43, new DateTime(2022, 11, 29, 20, 41, 33, 785, DateTimeKind.Local).AddTicks(2968), new DateTime(2022, 3, 7, 15, 37, 6, 417, DateTimeKind.Local).AddTicks(2045), "Caroline_Wunsch@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alena Rosenbaum", 14, "1-597-680-7663 x75959", "Jast, Huels and Trantow", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 45, new DateTime(2022, 7, 23, 16, 34, 31, 790, DateTimeKind.Local).AddTicks(7096), new DateTime(2023, 2, 2, 10, 53, 59, 843, DateTimeKind.Local).AddTicks(5237), "Elaine_Kerluke@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Clair Kassulke", 70, "(530) 413-9532 x988", "Schmeler - Sauer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 47, new DateTime(2022, 8, 3, 2, 41, 59, 632, DateTimeKind.Local).AddTicks(5664), new DateTime(2022, 4, 1, 23, 35, 41, 697, DateTimeKind.Local).AddTicks(7062), "Frankie_Collins@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Madisen Erdman", 85, "1-981-887-2644", "Mante - Swaniawski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 49, new DateTime(2022, 3, 28, 9, 37, 40, 441, DateTimeKind.Local).AddTicks(1344), new DateTime(2022, 6, 19, 8, 48, 48, 549, DateTimeKind.Local).AddTicks(9163), "Kim55@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Clark Wyman", 60, "854.203.2594 x17439", "Reinger - Bednar", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 51, new DateTime(2022, 5, 28, 16, 46, 29, 487, DateTimeKind.Local).AddTicks(1229), new DateTime(2022, 12, 24, 23, 4, 51, 488, DateTimeKind.Local).AddTicks(1834), "Mae_Mayer@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Phyllis Bergstrom", 79, "1-797-547-9527", "Prosacco - Lind", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 53, new DateTime(2022, 11, 5, 4, 9, 26, 33, DateTimeKind.Local).AddTicks(4021), new DateTime(2022, 8, 7, 2, 1, 23, 668, DateTimeKind.Local).AddTicks(5673), "Karen72@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Beth Kerluke", 19, "796-918-0819", "Kuhic, West and Gutmann", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 55, new DateTime(2022, 7, 3, 5, 39, 51, 33, DateTimeKind.Local).AddTicks(8842), new DateTime(2022, 7, 8, 15, 50, 19, 826, DateTimeKind.Local).AddTicks(6326), "Horace91@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ike Mraz", 18, "311-347-2349 x52538", "Krajcik Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 57, new DateTime(2022, 3, 28, 1, 37, 42, 272, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 7, 25, 19, 24, 53, 688, DateTimeKind.Local).AddTicks(1168), "Angelina81@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Osbaldo Ward", 32, "1-895-855-6304 x781", "Medhurst Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 59, new DateTime(2022, 12, 28, 21, 9, 14, 882, DateTimeKind.Local).AddTicks(4468), new DateTime(2022, 5, 2, 0, 17, 23, 177, DateTimeKind.Local).AddTicks(8212), "Shelia.Halvorson@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Salvador Medhurst", 77, "827-371-4937", "Walsh Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 61, new DateTime(2022, 2, 24, 9, 1, 50, 23, DateTimeKind.Local).AddTicks(1871), new DateTime(2022, 12, 12, 19, 9, 13, 158, DateTimeKind.Local).AddTicks(8493), "Owen_Powlowski@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Darrel White", 32, "(636) 927-2757 x456", "Corkery - Fahey", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 63, new DateTime(2022, 9, 16, 5, 54, 55, 509, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 7, 3, 5, 23, 36, 537, DateTimeKind.Local).AddTicks(5632), "Raymond.Gislason51@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Marjorie Mills", 23, "319.599.7821", "Schultz, Heaney and Stark", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 65, new DateTime(2022, 10, 6, 12, 48, 25, 172, DateTimeKind.Local).AddTicks(6258), new DateTime(2022, 2, 14, 0, 29, 24, 320, DateTimeKind.Local).AddTicks(2047), "Gilbert.Bogisich@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Georgianna Ritchie", 85, "530-245-8187", "Wehner - McClure", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 67, new DateTime(2022, 4, 22, 10, 7, 53, 903, DateTimeKind.Local).AddTicks(8106), new DateTime(2022, 8, 4, 22, 7, 32, 553, DateTimeKind.Local).AddTicks(596), "Isaac.Breitenberg@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Saul Dibbert", 22, "917.226.6915 x500", "Parker - Wintheiser", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 69, new DateTime(2022, 11, 27, 14, 5, 55, 230, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 4, 1, 10, 53, 33, 551, DateTimeKind.Local).AddTicks(7923), "Nathan16@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Susan Conn", 96, "854.547.2162 x41750", "Armstrong, Mills and Dickinson", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 135, new DateTime(2023, 1, 16, 5, 48, 22, 508, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 11, 17, 5, 35, 51, 226, DateTimeKind.Local).AddTicks(1780), "Casey.Cormier@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Stuart Haley", 30, "574.622.5486", "Cruickshank Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 267, new DateTime(2022, 12, 24, 20, 0, 44, 783, DateTimeKind.Local).AddTicks(8838), new DateTime(2022, 12, 16, 1, 58, 1, 138, DateTimeKind.Local).AddTicks(3219), "Dianna.Price33@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Maud Conn", 72, "1-990-942-0076 x398", "Wehner, Stiedemann and Kuphal", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 137, new DateTime(2023, 1, 11, 13, 38, 42, 683, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 4, 10, 23, 16, 27, 56, DateTimeKind.Local).AddTicks(1864), "Emma_Grant@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Trent Jones", 9, "975-550-2522", "Dickens Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 141, new DateTime(2022, 6, 6, 9, 31, 31, 611, DateTimeKind.Local).AddTicks(2077), new DateTime(2022, 12, 31, 23, 1, 38, 892, DateTimeKind.Local).AddTicks(3469), "Terry65@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Reginald Balistreri", 24, "1-455-288-4506", "Botsford - Macejkovic", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 209, new DateTime(2022, 9, 10, 1, 58, 9, 927, DateTimeKind.Local).AddTicks(1571), new DateTime(2022, 2, 8, 13, 37, 5, 813, DateTimeKind.Local).AddTicks(1500), "Melissa37@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kurtis Steuber", 61, "464.704.6722", "Lueilwitz Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 211, new DateTime(2022, 4, 18, 17, 40, 33, 723, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 1, 7, 4, 32, 3, 650, DateTimeKind.Local).AddTicks(2635), "Carole.Lind@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Oceane Spencer", 74, "653.347.0563 x924", "Jacobs, Parker and Kutch", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 213, new DateTime(2022, 6, 2, 15, 11, 9, 226, DateTimeKind.Local).AddTicks(3942), new DateTime(2022, 3, 13, 9, 30, 55, 419, DateTimeKind.Local).AddTicks(7277), "Leslie99@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Martin Turner", 13, "680.516.9793 x36674", "Aufderhar, Funk and Bernier", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 215, new DateTime(2022, 9, 5, 23, 31, 19, 350, DateTimeKind.Local).AddTicks(4588), new DateTime(2022, 3, 27, 14, 58, 13, 536, DateTimeKind.Local).AddTicks(9568), "Audrey.Rolfson@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Candace Beer", 56, "(651) 338-8295", "Nitzsche LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 217, new DateTime(2022, 9, 2, 15, 9, 30, 26, DateTimeKind.Local).AddTicks(1149), new DateTime(2022, 3, 11, 6, 22, 29, 55, DateTimeKind.Local).AddTicks(6068), "Rosie.Walter@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sophia Sawayn", 99, "1-340-205-7451 x019", "Feeney, Simonis and Ratke", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 219, new DateTime(2022, 11, 7, 20, 37, 20, 336, DateTimeKind.Local).AddTicks(8591), new DateTime(2022, 4, 19, 8, 39, 52, 9, DateTimeKind.Local).AddTicks(948), "Emma.Konopelski@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Titus Green", 15, "(547) 825-3523 x2956", "Mosciski LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 221, new DateTime(2022, 4, 25, 13, 33, 28, 557, DateTimeKind.Local).AddTicks(6623), new DateTime(2022, 11, 20, 6, 9, 26, 935, DateTimeKind.Local).AddTicks(8104), "Deanna72@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Moises Hoppe", 87, "939.995.0684", "O'Connell, Koch and Mann", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 223, new DateTime(2022, 10, 12, 10, 2, 57, 410, DateTimeKind.Local).AddTicks(5299), new DateTime(2022, 7, 17, 18, 28, 58, 889, DateTimeKind.Local).AddTicks(5943), "Rosemarie94@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jeremy Nolan", 20, "938-964-4803 x02906", "Hessel Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 225, new DateTime(2022, 5, 5, 14, 27, 6, 969, DateTimeKind.Local).AddTicks(6029), new DateTime(2022, 6, 11, 16, 57, 55, 658, DateTimeKind.Local).AddTicks(5035), "Samuel61@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Austen Nader", 17, "(592) 581-9796", "Towne, Kautzer and Lehner", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 227, new DateTime(2022, 12, 10, 5, 12, 22, 203, DateTimeKind.Local).AddTicks(2382), new DateTime(2023, 1, 15, 19, 35, 17, 583, DateTimeKind.Local).AddTicks(379), "Wendell.Cruickshank@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Aubrey Gutkowski", 41, "(500) 623-1662 x3188", "Okuneva - Luettgen", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 229, new DateTime(2022, 9, 11, 21, 29, 15, 419, DateTimeKind.Local).AddTicks(5668), new DateTime(2022, 11, 22, 15, 46, 24, 633, DateTimeKind.Local).AddTicks(8288), "Anne.Harber@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bella Quitzon", 7, "398-424-4360", "Barton, Daniel and Dach", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 231, new DateTime(2022, 2, 8, 2, 51, 53, 87, DateTimeKind.Local).AddTicks(4274), new DateTime(2022, 8, 16, 16, 54, 48, 934, DateTimeKind.Local).AddTicks(5708), "Christie81@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bernhard Olson", 23, "(978) 335-6413 x665", "Satterfield and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 233, new DateTime(2022, 11, 20, 18, 16, 42, 954, DateTimeKind.Local).AddTicks(3738), new DateTime(2022, 8, 6, 12, 16, 6, 129, DateTimeKind.Local).AddTicks(3971), "Dustin40@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bethany Bergnaum", 62, "434.758.5688", "Cartwright, Goodwin and O'Reilly", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 207, new DateTime(2022, 6, 16, 3, 13, 28, 20, DateTimeKind.Local).AddTicks(506), new DateTime(2022, 6, 24, 5, 28, 17, 719, DateTimeKind.Local).AddTicks(2971), "Ora_Johnson@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Karli Daniel", 23, "258-308-3750", "Funk Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 235, new DateTime(2022, 5, 17, 9, 44, 40, 744, DateTimeKind.Local).AddTicks(962), new DateTime(2022, 12, 4, 0, 49, 16, 658, DateTimeKind.Local).AddTicks(5572), "Lila.Schinner@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Elton Leffler", 56, "730-576-4444 x2375", "Schamberger LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 239, new DateTime(2022, 3, 13, 5, 58, 10, 54, DateTimeKind.Local).AddTicks(6591), new DateTime(2022, 12, 6, 2, 15, 58, 963, DateTimeKind.Local).AddTicks(7942), "Daisy1@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tia Green", 85, "695.711.3989 x266", "Weimann LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 241, new DateTime(2022, 11, 14, 3, 30, 12, 536, DateTimeKind.Local).AddTicks(1284), new DateTime(2023, 1, 7, 8, 28, 42, 59, DateTimeKind.Local).AddTicks(7278), "Joan.Huel@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "D'angelo Bergstrom", 55, "(388) 258-6184 x5381", "Hickle, Altenwerth and Emmerich", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 243, new DateTime(2023, 1, 29, 0, 43, 10, 754, DateTimeKind.Local).AddTicks(9755), new DateTime(2022, 10, 31, 23, 17, 13, 200, DateTimeKind.Local).AddTicks(6309), "Angelica_Runolfsson78@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Fay Cremin", 60, "989.204.8043 x43280", "Sawayn, Kassulke and Schultz", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 245, new DateTime(2022, 4, 6, 10, 56, 44, 51, DateTimeKind.Local).AddTicks(1764), new DateTime(2022, 11, 2, 17, 58, 2, 140, DateTimeKind.Local).AddTicks(7448), "Paul_Prohaska2@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Maud Yundt", 14, "822-530-7300", "Kuhic, Gutmann and Sawayn", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 247, new DateTime(2022, 4, 23, 6, 28, 7, 98, DateTimeKind.Local).AddTicks(5382), new DateTime(2022, 9, 25, 5, 17, 52, 573, DateTimeKind.Local).AddTicks(6753), "Anne_Hickle@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Taya Schuster", 62, "(580) 538-4935 x9193", "Carroll, Walsh and Kihn", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 249, new DateTime(2022, 2, 21, 12, 17, 11, 235, DateTimeKind.Local).AddTicks(8063), new DateTime(2022, 10, 14, 23, 3, 43, 341, DateTimeKind.Local).AddTicks(9025), "Nettie.Zulauf@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tessie Zieme", 91, "(701) 810-0928 x0787", "Lynch Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 251, new DateTime(2022, 7, 28, 8, 20, 29, 134, DateTimeKind.Local).AddTicks(9422), new DateTime(2023, 1, 14, 20, 40, 54, 409, DateTimeKind.Local).AddTicks(312), "Mercedes_OConnell0@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Margaret Rodriguez", 80, "1-742-664-3752 x59138", "Ratke, Huels and Kuhlman", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 253, new DateTime(2022, 3, 8, 6, 20, 17, 616, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 6, 14, 20, 10, 1, 34, DateTimeKind.Local).AddTicks(1097), "Louise_Fadel@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Brionna Berge", 52, "706.458.1279", "Ferry - Ebert", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 255, new DateTime(2023, 1, 17, 20, 50, 58, 167, DateTimeKind.Local).AddTicks(4957), new DateTime(2022, 8, 20, 14, 56, 59, 852, DateTimeKind.Local).AddTicks(423), "Clifton.Moen36@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Foster Ruecker", 43, "277.541.5445 x70851", "Mayert, Hudson and Marvin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 257, new DateTime(2022, 2, 21, 16, 35, 36, 704, DateTimeKind.Local).AddTicks(3373), new DateTime(2023, 1, 15, 5, 38, 13, 203, DateTimeKind.Local).AddTicks(3359), "Jeremy84@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Lysanne Bergnaum", 33, "981-257-1229", "Boyer, Jakubowski and Hickle", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 259, new DateTime(2023, 1, 10, 22, 16, 18, 185, DateTimeKind.Local).AddTicks(7526), new DateTime(2022, 12, 9, 15, 3, 54, 189, DateTimeKind.Local).AddTicks(6879), "Virgil.Carroll19@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Carroll Konopelski", 17, "1-487-812-9699 x62936", "Sawayn - O'Connell", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 261, new DateTime(2022, 10, 9, 9, 14, 49, 51, DateTimeKind.Local).AddTicks(3723), new DateTime(2022, 4, 29, 4, 2, 54, 250, DateTimeKind.Local).AddTicks(9282), "Gilberto.Labadie4@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jon Huels", 8, "1-387-824-3799 x182", "Fahey, Stehr and Kemmer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 263, new DateTime(2022, 3, 5, 8, 52, 57, 958, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 9, 16, 4, 55, 55, 459, DateTimeKind.Local).AddTicks(1020), "Bernadette.Price69@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tad Barrows", 58, "1-248-902-5250 x944", "Cronin Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 237, new DateTime(2022, 6, 30, 3, 12, 21, 919, DateTimeKind.Local).AddTicks(6685), new DateTime(2022, 12, 17, 22, 30, 50, 377, DateTimeKind.Local).AddTicks(5848), "Kristie17@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kaitlyn Stroman", 48, "510.336.3553 x666", "MacGyver - Thiel", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 205, new DateTime(2022, 8, 17, 8, 34, 51, 366, DateTimeKind.Local).AddTicks(509), new DateTime(2022, 12, 3, 23, 44, 19, 666, DateTimeKind.Local).AddTicks(3560), "Dennis.Green@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Gustave Weimann", 32, "1-451-507-4831 x752", "Macejkovic Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 203, new DateTime(2022, 9, 24, 14, 39, 0, 934, DateTimeKind.Local).AddTicks(8694), new DateTime(2022, 9, 29, 21, 22, 48, 840, DateTimeKind.Local).AddTicks(9385), "Marianne_King@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Liza Kemmer", 38, "(731) 340-7577", "Yost, Reinger and Pacocha", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 201, new DateTime(2022, 11, 7, 11, 36, 56, 764, DateTimeKind.Local).AddTicks(9359), new DateTime(2022, 11, 2, 1, 36, 56, 582, DateTimeKind.Local).AddTicks(535), "Laurie97@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sammy Haley", 37, "(343) 972-8001 x4658", "Lang - Auer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 143, new DateTime(2022, 5, 22, 21, 59, 12, 691, DateTimeKind.Local).AddTicks(692), new DateTime(2022, 9, 11, 18, 21, 38, 343, DateTimeKind.Local).AddTicks(9303), "Opal.Quitzon1@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jordane Shanahan", 99, "518.409.9118 x54922", "Kutch - Schimmel", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 145, new DateTime(2022, 12, 31, 13, 36, 12, 921, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 5, 14, 4, 48, 53, 287, DateTimeKind.Local).AddTicks(5823), "Jack.Greenfelder@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Yvette Streich", 45, "(394) 891-0648 x65880", "Braun, Nitzsche and Nader", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 147, new DateTime(2022, 8, 31, 21, 5, 54, 385, DateTimeKind.Local).AddTicks(4101), new DateTime(2022, 11, 22, 20, 42, 53, 78, DateTimeKind.Local).AddTicks(6137), "Josefina.Cummerata1@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Carol Gleichner", 94, "866.342.3719", "Stoltenberg - Hintz", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 149, new DateTime(2023, 1, 16, 10, 47, 30, 307, DateTimeKind.Local).AddTicks(5969), new DateTime(2022, 9, 13, 18, 47, 18, 381, DateTimeKind.Local).AddTicks(263), "Rosemary_Ziemann@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Reid Walsh", 42, "1-338-820-4834 x481", "Rippin LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 151, new DateTime(2022, 11, 7, 4, 55, 55, 610, DateTimeKind.Local).AddTicks(1860), new DateTime(2022, 11, 7, 4, 3, 43, 499, DateTimeKind.Local).AddTicks(6752), "Miranda15@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jadyn Daniel", 41, "1-601-622-8048 x93047", "Von, Jacobson and D'Amore", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 153, new DateTime(2022, 2, 15, 16, 15, 9, 743, DateTimeKind.Local).AddTicks(344), new DateTime(2023, 2, 1, 16, 51, 7, 728, DateTimeKind.Local).AddTicks(8830), "Martha_Watsica41@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Wilber Dach", 34, "1-367-218-7418", "Heller LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 155, new DateTime(2022, 7, 20, 2, 33, 59, 691, DateTimeKind.Local).AddTicks(2294), new DateTime(2022, 7, 31, 8, 58, 46, 770, DateTimeKind.Local).AddTicks(3634), "Armando71@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Agustin Yundt", 71, "825.551.5190", "Franecki LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 157, new DateTime(2022, 10, 26, 10, 58, 29, 939, DateTimeKind.Local).AddTicks(6379), new DateTime(2023, 1, 16, 8, 26, 9, 393, DateTimeKind.Local).AddTicks(8455), "Joann82@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tommie Reynolds", 24, "501.678.3681", "Beahan - Franecki", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 159, new DateTime(2022, 12, 22, 22, 38, 47, 976, DateTimeKind.Local).AddTicks(9896), new DateTime(2022, 5, 20, 7, 20, 51, 437, DateTimeKind.Local).AddTicks(5300), "Aaron.Hermann@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Caden McCullough", 58, "857.545.7522", "Grant Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 161, new DateTime(2022, 12, 6, 16, 25, 51, 778, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 12, 26, 10, 48, 20, 962, DateTimeKind.Local).AddTicks(4618), "Joanna_Zemlak3@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Anthony Waelchi", 43, "344-628-6562", "McLaughlin - Smith", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 163, new DateTime(2022, 6, 18, 0, 25, 57, 191, DateTimeKind.Local).AddTicks(5089), new DateTime(2022, 9, 18, 11, 13, 17, 542, DateTimeKind.Local).AddTicks(1043), "Wanda.Block98@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rahsaan Goldner", 44, "740.232.1261", "Rutherford and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 165, new DateTime(2022, 6, 24, 23, 59, 51, 940, DateTimeKind.Local).AddTicks(3874), new DateTime(2022, 11, 30, 22, 12, 30, 180, DateTimeKind.Local).AddTicks(5791), "Edgar_Klocko66@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Chandler Cummerata", 64, "1-308-303-2944 x979", "Hettinger, Welch and Crist", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 167, new DateTime(2022, 12, 6, 13, 8, 47, 112, DateTimeKind.Local).AddTicks(7064), new DateTime(2022, 12, 5, 2, 26, 16, 211, DateTimeKind.Local).AddTicks(6604), "Abraham45@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Junius Littel", 0, "943.207.6272 x844", "Jakubowski - Hamill", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 169, new DateTime(2022, 5, 21, 19, 39, 30, 962, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 1, 26, 21, 26, 24, 115, DateTimeKind.Local).AddTicks(6112), "Bethany95@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Elaina Lehner", 81, "(754) 531-4400 x458", "Harvey, Bechtelar and Graham", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 171, new DateTime(2023, 1, 14, 21, 33, 48, 445, DateTimeKind.Local).AddTicks(9554), new DateTime(2022, 4, 9, 9, 2, 22, 805, DateTimeKind.Local).AddTicks(1833), "Wade.Hodkiewicz@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Emery Okuneva", 36, "465.989.5139 x767", "Block, Harvey and Schmeler", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 173, new DateTime(2022, 3, 20, 17, 37, 45, 60, DateTimeKind.Local).AddTicks(9932), new DateTime(2022, 5, 29, 19, 2, 52, 465, DateTimeKind.Local).AddTicks(312), "Damon72@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Dusty Corwin", 80, "794.491.8037 x090", "Welch Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 175, new DateTime(2022, 6, 16, 11, 19, 25, 783, DateTimeKind.Local).AddTicks(6758), new DateTime(2022, 8, 16, 6, 5, 22, 115, DateTimeKind.Local).AddTicks(5691), "Jerald19@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Brooks Grant", 43, "(288) 378-1628 x49308", "Kovacek, Marvin and Larson", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 177, new DateTime(2022, 11, 6, 8, 55, 14, 454, DateTimeKind.Local).AddTicks(7253), new DateTime(2022, 3, 26, 23, 22, 16, 772, DateTimeKind.Local).AddTicks(748), "Nathaniel.Stanton@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Candace Weissnat", 51, "818.332.0204", "Tremblay Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 179, new DateTime(2022, 4, 21, 7, 3, 25, 253, DateTimeKind.Local).AddTicks(8941), new DateTime(2022, 4, 7, 13, 25, 50, 886, DateTimeKind.Local).AddTicks(5852), "Van_Jakubowski@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Herminio Treutel", 10, "460-724-1403 x9669", "Boyer, Streich and Pacocha", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 181, new DateTime(2022, 11, 4, 7, 40, 12, 606, DateTimeKind.Local).AddTicks(1914), new DateTime(2022, 7, 19, 3, 32, 45, 591, DateTimeKind.Local).AddTicks(4489), "Kerry_Zemlak@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kayleigh Leuschke", 4, "720.759.0136", "Jacobson Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 183, new DateTime(2022, 3, 15, 9, 19, 47, 441, DateTimeKind.Local).AddTicks(6982), new DateTime(2022, 5, 2, 1, 8, 38, 475, DateTimeKind.Local).AddTicks(3976), "Heather_Cruickshank@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rachael Zboncak", 13, "1-351-592-8656", "Durgan - Krajcik", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 185, new DateTime(2022, 12, 14, 10, 1, 27, 823, DateTimeKind.Local).AddTicks(8266), new DateTime(2022, 6, 20, 5, 14, 55, 409, DateTimeKind.Local).AddTicks(1140), "Dominic_Wiegand10@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Lola Klein", 59, "519.215.0777", "O'Conner, Grimes and Bergstrom", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 187, new DateTime(2022, 7, 3, 13, 30, 16, 325, DateTimeKind.Local).AddTicks(107), new DateTime(2022, 10, 9, 19, 0, 50, 447, DateTimeKind.Local).AddTicks(5760), "Jo45@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Waldo Lowe", 94, "(239) 944-2242", "Yost - Pacocha", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 189, new DateTime(2022, 4, 19, 22, 22, 37, 75, DateTimeKind.Local).AddTicks(4460), new DateTime(2022, 7, 8, 21, 49, 48, 915, DateTimeKind.Local).AddTicks(9430), "Lloyd95@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tess Heaney", 68, "900.601.2490 x7065", "Keebler Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 191, new DateTime(2022, 8, 9, 23, 15, 30, 332, DateTimeKind.Local).AddTicks(1831), new DateTime(2022, 6, 28, 15, 39, 2, 944, DateTimeKind.Local).AddTicks(2145), "Janis_Lockman@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Daphne Bergnaum", 94, "515-563-6447 x5102", "Bernhard, Auer and Beahan", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 193, new DateTime(2022, 2, 17, 19, 11, 15, 365, DateTimeKind.Local).AddTicks(9844), new DateTime(2022, 8, 26, 8, 47, 49, 980, DateTimeKind.Local).AddTicks(8980), "Julius33@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Letha Braun", 81, "1-389-264-0011 x1431", "Veum - Bins", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 195, new DateTime(2022, 2, 15, 18, 12, 42, 893, DateTimeKind.Local).AddTicks(9502), new DateTime(2022, 12, 1, 8, 29, 3, 671, DateTimeKind.Local).AddTicks(2221), "Joann55@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Concepcion Langworth", 72, "446.758.5230", "Schmidt - Wyman", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 197, new DateTime(2022, 2, 14, 13, 11, 26, 379, DateTimeKind.Local).AddTicks(1057), new DateTime(2022, 11, 2, 12, 26, 56, 283, DateTimeKind.Local).AddTicks(2769), "Sandra_Bashirian7@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Cheyanne Nitzsche", 5, "739.495.1817", "Ward, Schroeder and Yundt", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 199, new DateTime(2022, 8, 16, 9, 28, 45, 794, DateTimeKind.Local).AddTicks(8541), new DateTime(2022, 9, 2, 0, 53, 16, 558, DateTimeKind.Local).AddTicks(5511), "Kenny56@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Olin Goldner", 32, "711.366.4169", "Pagac Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 139, new DateTime(2022, 2, 25, 4, 7, 40, 600, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 1, 10, 3, 50, 9, 950, DateTimeKind.Local).AddTicks(3600), "Joyce80@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Sherman Emard", 72, "867.609.9842 x8056", "Hilpert Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 11, new DateTime(2022, 9, 8, 23, 33, 29, 172, DateTimeKind.Local).AddTicks(8324), new DateTime(2022, 11, 21, 4, 38, 35, 326, DateTimeKind.Local).AddTicks(3515), "Katrina94@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Franco Herzog", 39, "540.432.1195 x249", "Bernhard - Kilback", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2022, 8, 22, 2, 8, 3, 197, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 6, 17, 18, 35, 34, 104, DateTimeKind.Local).AddTicks(6064), "Jennifer9@gmail.com", "Ricky Williamson", 75, "357-270-9332 x15350", "Olson LLC" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2022, 9, 3, 1, 59, 19, 104, DateTimeKind.Local).AddTicks(2484), new DateTime(2022, 5, 15, 0, 41, 49, 381, DateTimeKind.Local).AddTicks(9397), "Jared_Williamson45@yahoo.com", "Tyrique Johnson", 2, "(583) 565-6511", "Bernhard, Kuhlman and Waters" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2022, 11, 7, 2, 10, 30, 675, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 4, 5, 3, 41, 20, 265, DateTimeKind.Local).AddTicks(4063), "Spencer_Ernser33@yahoo.com", "Beulah Bauch", 28, "876-351-5030 x064", "Schinner - Grady" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2022, 10, 11, 8, 59, 24, 209, DateTimeKind.Local).AddTicks(4104), new DateTime(2022, 10, 9, 6, 0, 13, 937, DateTimeKind.Local).AddTicks(1747), "Rolando_Bayer36@yahoo.com", "Laney Hyatt", 87, "837-631-4263", "Steuber and Sons" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "DataEvento", "Email", "Local", "QtdPessoas", "Telefone", "Tema" },
                values: new object[] { new DateTime(2023, 1, 10, 1, 44, 3, 900, DateTimeKind.Local).AddTicks(5857), new DateTime(2022, 10, 3, 21, 59, 5, 456, DateTimeKind.Local).AddTicks(186), "Meredith.Bradtke@gmail.com", "Horacio Reichert", 82, "651-634-6952 x083", "Erdman, Kohler and Mohr" });
        }
    }
}
