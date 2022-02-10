using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Local = table.Column<string>(type: "TEXT", nullable: true),
                    DataEvento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Tema = table.Column<string>(type: "TEXT", nullable: true),
                    QtdPessoas = table.Column<int>(type: "INTEGER", nullable: false),
                    ImagemURL = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Palestrantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    MiniCurriculo = table.Column<string>(type: "TEXT", nullable: true),
                    ImagemURL = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palestrantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataIncio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    EventoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lotes_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PalestranteEvento",
                columns: table => new
                {
                    PalestranteId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalestranteEvento", x => new { x.EventoId, x.PalestranteId });
                    table.ForeignKey(
                        name: "FK_PalestranteEvento_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PalestranteEvento_Palestrantes_PalestranteId",
                        column: x => x.PalestranteId,
                        principalTable: "Palestrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RedeSociais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    URL = table.Column<string>(type: "TEXT", nullable: true),
                    EventoId = table.Column<int>(type: "INTEGER", nullable: true),
                    PalestranteId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedeSociais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedeSociais_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RedeSociais_Palestrantes_PalestranteId",
                        column: x => x.PalestranteId,
                        principalTable: "Palestrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 6, 22, 17, 38, 31, 830, DateTimeKind.Local).AddTicks(1254), new DateTime(2022, 4, 3, 8, 47, 21, 635, DateTimeKind.Local).AddTicks(9013), "Wm.Kozey14@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Albin Batz", 90, "499.904.0326 x5701", "Roberts, Casper and Turner", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 203, new DateTime(2022, 7, 15, 17, 53, 28, 533, DateTimeKind.Local).AddTicks(3723), new DateTime(2022, 5, 7, 22, 59, 5, 752, DateTimeKind.Local).AddTicks(3277), "Kirk.Boehm@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Heath Kshlerin", 14, "314.306.4474 x311", "Heaney, Sanford and Buckridge", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 201, new DateTime(2022, 12, 13, 23, 24, 6, 757, DateTimeKind.Local).AddTicks(8028), new DateTime(2022, 10, 24, 7, 13, 4, 968, DateTimeKind.Local).AddTicks(2152), "Shane.Pouros@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Karlie McCullough", 1, "539.351.3081 x3945", "Torp, Sauer and Bradtke", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 199, new DateTime(2022, 5, 19, 2, 53, 38, 294, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 6, 28, 7, 54, 33, 505, DateTimeKind.Local).AddTicks(7745), "Genevieve.Fay@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Zachary Lueilwitz", 100, "1-388-655-6004 x1875", "Prosacco LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 197, new DateTime(2022, 7, 25, 7, 28, 54, 275, DateTimeKind.Local).AddTicks(1671), new DateTime(2022, 8, 3, 2, 52, 3, 442, DateTimeKind.Local).AddTicks(4009), "Darren.Kub56@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Chad O'Reilly", 85, "(401) 976-5817 x328", "Toy LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 195, new DateTime(2022, 6, 16, 23, 50, 32, 570, DateTimeKind.Local).AddTicks(6658), new DateTime(2022, 10, 15, 19, 56, 47, 280, DateTimeKind.Local).AddTicks(6004), "Lynn30@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rosemarie O'Hara", 24, "(738) 884-5445", "Gorczany Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 193, new DateTime(2022, 5, 30, 18, 56, 0, 324, DateTimeKind.Local).AddTicks(2473), new DateTime(2022, 11, 2, 7, 53, 29, 488, DateTimeKind.Local).AddTicks(5858), "Denise.Schuster@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bill Roob", 100, "360.670.0737 x0488", "Wintheiser, Strosin and Keebler", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 191, new DateTime(2022, 3, 13, 14, 53, 37, 902, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 1, 25, 3, 24, 48, 885, DateTimeKind.Local).AddTicks(4970), "Kayla_Hagenes40@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Amani Adams", 18, "949-981-6125 x92202", "Stark, Berge and Hammes", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 189, new DateTime(2022, 12, 17, 17, 46, 20, 721, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 7, 3, 7, 49, 55, 238, DateTimeKind.Local).AddTicks(6524), "Inez_Kunze@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Emil Hettinger", 78, "(895) 782-4356", "Jast Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 187, new DateTime(2022, 10, 15, 10, 57, 12, 925, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 1, 10, 9, 8, 56, 853, DateTimeKind.Local).AddTicks(4507), "Marianne.Kiehn97@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Katrina Stark", 31, "1-941-329-4350 x1963", "Lueilwitz LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 185, new DateTime(2022, 6, 13, 1, 30, 13, 198, DateTimeKind.Local).AddTicks(7376), new DateTime(2022, 12, 11, 20, 36, 19, 585, DateTimeKind.Local).AddTicks(7277), "Rudolph.OKon@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Madison Grady", 76, "330-412-2908 x933", "Senger, Pacocha and Weber", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 183, new DateTime(2022, 8, 11, 23, 56, 33, 923, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 12, 8, 14, 29, 21, 686, DateTimeKind.Local).AddTicks(1575), "Lana_Kertzmann71@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Brian Wuckert", 8, "712.413.8416", "Kunde Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 181, new DateTime(2022, 11, 16, 6, 12, 15, 163, DateTimeKind.Local).AddTicks(6749), new DateTime(2022, 5, 31, 9, 44, 28, 640, DateTimeKind.Local).AddTicks(3075), "Rolando.Barrows53@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Oswald Kuhn", 75, "550.430.6878", "Weissnat - Muller", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 179, new DateTime(2022, 7, 21, 4, 41, 58, 597, DateTimeKind.Local).AddTicks(4533), new DateTime(2022, 9, 24, 8, 58, 42, 561, DateTimeKind.Local).AddTicks(1738), "Gretchen.Cruickshank5@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Selina Ledner", 15, "491-816-6106 x82862", "Marquardt - Maggio", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 177, new DateTime(2022, 12, 25, 22, 20, 4, 416, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 6, 27, 20, 9, 56, 75, DateTimeKind.Local).AddTicks(9881), "Joel55@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Salvatore Ledner", 96, "1-589-508-2384", "Kshlerin - Greenholt", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 175, new DateTime(2022, 8, 30, 5, 53, 38, 482, DateTimeKind.Local).AddTicks(5047), new DateTime(2022, 6, 2, 7, 31, 53, 826, DateTimeKind.Local).AddTicks(109), "Irving_Considine@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bernard Parker", 4, "645-952-0345 x87877", "Oberbrunner, Lockman and Barrows", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 173, new DateTime(2022, 11, 4, 7, 10, 40, 400, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 1, 21, 2, 17, 34, 154, DateTimeKind.Local).AddTicks(2259), "Kirk_Powlowski@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Litzy Reynolds", 6, "831-246-1718 x37593", "Collier, Rau and Feil", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 171, new DateTime(2022, 12, 11, 20, 46, 47, 991, DateTimeKind.Local).AddTicks(880), new DateTime(2022, 8, 30, 8, 18, 15, 694, DateTimeKind.Local).AddTicks(9726), "Lynne.McKenzie93@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rickey Schamberger", 64, "(689) 798-7947", "Skiles Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 143, new DateTime(2023, 1, 5, 6, 21, 8, 208, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 2, 23, 18, 28, 6, 871, DateTimeKind.Local).AddTicks(3115), "Jonathon.Haley1@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Martina Mayert", 72, "(889) 812-5023", "Tillman, Durgan and Mayer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 145, new DateTime(2022, 5, 25, 16, 6, 6, 603, DateTimeKind.Local).AddTicks(1341), new DateTime(2022, 9, 4, 1, 54, 35, 429, DateTimeKind.Local).AddTicks(8864), "Spencer.Kassulke53@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Keanu McCullough", 54, "229.255.4787 x5222", "Mitchell Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 147, new DateTime(2022, 4, 21, 6, 21, 23, 908, DateTimeKind.Local).AddTicks(6442), new DateTime(2022, 9, 25, 19, 44, 37, 626, DateTimeKind.Local).AddTicks(6188), "Harvey_Kautzer40@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Darren Orn", 20, "288.835.8495 x199", "Langosh - Hauck", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 149, new DateTime(2022, 11, 20, 7, 10, 38, 696, DateTimeKind.Local).AddTicks(1025), new DateTime(2022, 3, 20, 3, 40, 27, 460, DateTimeKind.Local).AddTicks(9715), "Angel79@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Nash Glover", 43, "737-420-1257 x228", "Bartoletti and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 151, new DateTime(2022, 9, 20, 7, 30, 30, 985, DateTimeKind.Local).AddTicks(7789), new DateTime(2022, 12, 27, 7, 13, 5, 753, DateTimeKind.Local).AddTicks(283), "Armando.Homenick57@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Mallie Heathcote", 51, "1-406-787-7116 x5422", "Cartwright Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 153, new DateTime(2023, 1, 13, 1, 49, 43, 319, DateTimeKind.Local).AddTicks(6467), new DateTime(2022, 5, 1, 2, 45, 4, 458, DateTimeKind.Local).AddTicks(7152), "Minnie_Powlowski@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Tatum Rosenbaum", 3, "(875) 853-5323 x22246", "Jerde, Hirthe and Morar", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 205, new DateTime(2022, 5, 15, 14, 47, 30, 378, DateTimeKind.Local).AddTicks(8775), new DateTime(2022, 10, 24, 1, 20, 55, 44, DateTimeKind.Local).AddTicks(3830), "Helen.Flatley@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Fay Zulauf", 67, "626-332-4919", "Bradtke - Welch", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 155, new DateTime(2022, 12, 7, 0, 40, 50, 130, DateTimeKind.Local).AddTicks(912), new DateTime(2022, 12, 10, 18, 27, 10, 904, DateTimeKind.Local).AddTicks(9893), "Pat_Nader5@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Eveline Ferry", 86, "1-822-375-4278 x26489", "Hartmann - Schultz", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 159, new DateTime(2023, 2, 1, 23, 2, 28, 812, DateTimeKind.Local).AddTicks(548), new DateTime(2022, 8, 26, 8, 52, 26, 638, DateTimeKind.Local).AddTicks(2119), "Lori31@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alphonso Kovacek", 43, "567.345.7267 x3588", "Connelly, Nikolaus and Boyer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 161, new DateTime(2022, 8, 3, 2, 34, 48, 249, DateTimeKind.Local).AddTicks(6010), new DateTime(2022, 6, 11, 14, 37, 12, 33, DateTimeKind.Local).AddTicks(5106), "Kerry.Tremblay62@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Geovanny Gleason", 24, "(565) 910-6784 x770", "Herman - Waters", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 163, new DateTime(2022, 12, 22, 8, 21, 49, 371, DateTimeKind.Local).AddTicks(6215), new DateTime(2022, 12, 14, 4, 46, 59, 173, DateTimeKind.Local).AddTicks(4132), "Claude.McClure@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Deshaun Cassin", 99, "282.264.3078 x976", "McGlynn Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 165, new DateTime(2022, 3, 7, 14, 34, 15, 357, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 4, 14, 12, 2, 26, 164, DateTimeKind.Local).AddTicks(6014), "Dominic6@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Joany Rice", 33, "824.445.1787 x62335", "Braun - Dickens", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 167, new DateTime(2023, 2, 1, 12, 35, 1, 25, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 12, 2, 17, 51, 59, 152, DateTimeKind.Local).AddTicks(445), "Austin.Schinner57@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Eva Heller", 20, "909-535-0392 x61322", "Walter, Jerde and Bartell", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 169, new DateTime(2022, 9, 4, 3, 36, 45, 56, DateTimeKind.Local).AddTicks(1714), new DateTime(2022, 6, 12, 22, 43, 43, 382, DateTimeKind.Local).AddTicks(6982), "Tabitha.Gutkowski@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alverta Ryan", 40, "224.363.8239 x6427", "Prohaska, Ankunding and Breitenberg", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 157, new DateTime(2023, 1, 18, 14, 4, 6, 327, DateTimeKind.Local).AddTicks(8719), new DateTime(2022, 3, 10, 9, 34, 37, 291, DateTimeKind.Local).AddTicks(3993), "Terry97@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Erwin Harber", 86, "(440) 526-9980 x810", "Blanda - Wiegand", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 141, new DateTime(2022, 11, 5, 0, 56, 2, 338, DateTimeKind.Local).AddTicks(2289), new DateTime(2022, 11, 24, 4, 8, 2, 442, DateTimeKind.Local).AddTicks(4238), "Ralph_Jones@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Albertha Armstrong", 9, "1-424-926-7241", "Fadel, Gulgowski and Haag", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 207, new DateTime(2022, 6, 10, 20, 41, 43, 605, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 5, 22, 12, 13, 47, 261, DateTimeKind.Local).AddTicks(5797), "Myra_Heaney@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alek Jenkins", 27, "265-267-5254", "Rowe, Turner and Pfeffer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 211, new DateTime(2022, 5, 19, 23, 52, 51, 882, DateTimeKind.Local).AddTicks(1437), new DateTime(2022, 8, 1, 8, 32, 11, 957, DateTimeKind.Local).AddTicks(5580), "Gary_Willms91@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ken Rolfson", 47, "(214) 506-1084 x78910", "Batz, Johns and Dooley", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 273, new DateTime(2022, 10, 29, 10, 15, 26, 392, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 3, 27, 15, 32, 45, 524, DateTimeKind.Local).AddTicks(1900), "Lance.Berge22@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jadyn Swaniawski", 54, "877-312-3151 x554", "Pollich Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 271, new DateTime(2022, 12, 25, 3, 14, 31, 157, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 6, 5, 5, 10, 20, 903, DateTimeKind.Local).AddTicks(6828), "Constance_Rippin@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Hallie Lubowitz", 52, "674.283.9156 x5110", "Murphy LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 269, new DateTime(2023, 1, 10, 20, 44, 58, 134, DateTimeKind.Local).AddTicks(8774), new DateTime(2022, 5, 2, 6, 18, 17, 889, DateTimeKind.Local).AddTicks(4500), "Omar19@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Arlie Walker", 21, "(239) 675-8457 x0368", "Orn LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 267, new DateTime(2022, 5, 6, 1, 42, 24, 168, DateTimeKind.Local).AddTicks(9202), new DateTime(2022, 5, 25, 7, 43, 11, 305, DateTimeKind.Local).AddTicks(864), "Ebony98@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "General Collier", 81, "783-274-6535 x34285", "Torp - Nikolaus", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 265, new DateTime(2022, 6, 21, 17, 41, 24, 601, DateTimeKind.Local).AddTicks(241), new DateTime(2022, 4, 3, 10, 43, 0, 585, DateTimeKind.Local).AddTicks(4319), "Jessica_Crist@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Chesley Wunsch", 66, "(433) 306-9764", "Huels, Dickens and Ullrich", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 263, new DateTime(2022, 10, 2, 8, 52, 20, 482, DateTimeKind.Local).AddTicks(5407), new DateTime(2022, 7, 30, 18, 17, 22, 973, DateTimeKind.Local).AddTicks(2345), "Percy_Bednar15@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Leonor Cronin", 54, "217-305-4832 x0773", "Jakubowski - Jacobs", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 261, new DateTime(2022, 12, 1, 17, 47, 9, 666, DateTimeKind.Local).AddTicks(4457), new DateTime(2022, 7, 13, 14, 13, 3, 257, DateTimeKind.Local).AddTicks(1182), "Shari.Herzog46@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Henry Fay", 96, "996-966-5100", "Cremin, Brekke and Mayer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 259, new DateTime(2022, 4, 27, 15, 17, 29, 661, DateTimeKind.Local).AddTicks(4152), new DateTime(2022, 6, 16, 12, 31, 41, 81, DateTimeKind.Local).AddTicks(6832), "Gail11@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Erik Purdy", 56, "(546) 797-3181", "Kutch and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 257, new DateTime(2022, 10, 30, 2, 29, 29, 941, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 4, 27, 15, 0, 22, 70, DateTimeKind.Local).AddTicks(1350), "Emmett10@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Melvin Stoltenberg", 84, "(646) 776-5262 x04932", "Fadel, Abshire and Nikolaus", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 255, new DateTime(2022, 12, 29, 20, 31, 14, 496, DateTimeKind.Local).AddTicks(6627), new DateTime(2022, 10, 15, 4, 46, 21, 868, DateTimeKind.Local).AddTicks(4949), "Brittany74@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Stuart Heidenreich", 75, "1-992-211-2049", "Ward, Zieme and Moen", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 253, new DateTime(2022, 8, 6, 14, 38, 53, 450, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 9, 26, 14, 57, 16, 654, DateTimeKind.Local).AddTicks(8413), "Roman.Rodriguez19@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Easton Rogahn", 90, "1-333-223-1198", "Cummings, Pfannerstill and Rice", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 251, new DateTime(2022, 2, 20, 5, 9, 21, 872, DateTimeKind.Local).AddTicks(4556), new DateTime(2022, 2, 27, 17, 16, 32, 126, DateTimeKind.Local).AddTicks(2927), "Patsy_Von47@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alisha Cassin", 53, "(308) 567-2988 x0748", "Tremblay - Schneider", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 249, new DateTime(2023, 1, 12, 0, 35, 51, 876, DateTimeKind.Local).AddTicks(7177), new DateTime(2022, 5, 28, 8, 26, 40, 456, DateTimeKind.Local).AddTicks(325), "Oliver.Moen37@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Betty Littel", 34, "717.849.1968", "Brown - Osinski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 247, new DateTime(2022, 11, 12, 22, 48, 15, 649, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 5, 4, 13, 39, 26, 95, DateTimeKind.Local).AddTicks(904), "Randal.Walter87@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Darion Gutkowski", 94, "460-933-5129 x626", "Terry and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 245, new DateTime(2022, 7, 11, 22, 17, 53, 496, DateTimeKind.Local).AddTicks(8808), new DateTime(2022, 5, 15, 16, 21, 11, 968, DateTimeKind.Local).AddTicks(213), "Derrick_Smitham@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Amanda Block", 86, "1-438-814-3250 x5670", "Erdman Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 243, new DateTime(2022, 8, 9, 16, 38, 58, 980, DateTimeKind.Local).AddTicks(6956), new DateTime(2022, 2, 10, 6, 41, 51, 746, DateTimeKind.Local).AddTicks(9755), "Sonya.Cummerata@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Manuela Hermiston", 72, "864.533.6341 x6443", "Torp - Halvorson", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 241, new DateTime(2022, 6, 27, 11, 44, 25, 676, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 7, 17, 7, 47, 48, 995, DateTimeKind.Local).AddTicks(8181), "Jared20@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Colby Fritsch", 56, "925-570-0595 x50769", "Mills - Hane", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 213, new DateTime(2022, 8, 6, 6, 21, 22, 200, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 9, 3, 11, 52, 37, 234, DateTimeKind.Local).AddTicks(1057), "Myron.Conroy@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Cara Koepp", 82, "662-328-9665 x6528", "Kling - Pouros", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 215, new DateTime(2022, 11, 20, 11, 47, 40, 309, DateTimeKind.Local).AddTicks(97), new DateTime(2023, 1, 26, 15, 22, 39, 103, DateTimeKind.Local).AddTicks(1530), "Brad.Hudson37@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kailey Olson", 91, "539.297.3868", "Klocko and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 217, new DateTime(2023, 1, 23, 0, 49, 32, 417, DateTimeKind.Local).AddTicks(4244), new DateTime(2022, 12, 16, 10, 8, 11, 262, DateTimeKind.Local).AddTicks(640), "Helen_Yost@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Luz Ziemann", 91, "229-744-5080", "Brakus, Pagac and McGlynn", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 219, new DateTime(2022, 9, 13, 17, 37, 52, 878, DateTimeKind.Local).AddTicks(7915), new DateTime(2022, 12, 5, 6, 0, 9, 627, DateTimeKind.Local).AddTicks(6637), "Della_Lind@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Agnes Wolff", 47, "(950) 361-6142", "Lebsack, Thiel and Monahan", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 221, new DateTime(2022, 12, 26, 23, 23, 42, 250, DateTimeKind.Local).AddTicks(8939), new DateTime(2022, 7, 14, 15, 16, 18, 379, DateTimeKind.Local).AddTicks(9718), "Clara82@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Matt Glover", 0, "296.508.8987 x0480", "Zemlak, Marquardt and Langosh", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 223, new DateTime(2022, 3, 9, 1, 23, 44, 372, DateTimeKind.Local).AddTicks(5479), new DateTime(2022, 4, 30, 19, 5, 55, 717, DateTimeKind.Local).AddTicks(9813), "Marta_Wolf@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Thalia Hickle", 30, "979.293.1585", "Wisoky Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 209, new DateTime(2022, 5, 19, 6, 51, 19, 747, DateTimeKind.Local).AddTicks(4449), new DateTime(2022, 8, 13, 2, 13, 5, 991, DateTimeKind.Local).AddTicks(4086), "Francisco.Breitenberg@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Micheal Shanahan", 0, "847.358.1211 x1532", "Farrell, Heaney and Walsh", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 225, new DateTime(2022, 9, 7, 17, 7, 49, 628, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 1, 25, 8, 31, 34, 303, DateTimeKind.Local).AddTicks(1949), "Lester.Franecki45@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Carolanne Wiegand", 55, "871-216-0607 x15596", "Rogahn Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 229, new DateTime(2022, 3, 25, 12, 55, 52, 422, DateTimeKind.Local).AddTicks(5991), new DateTime(2022, 10, 4, 9, 56, 8, 814, DateTimeKind.Local).AddTicks(9629), "Max.Doyle31@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Dandre Ullrich", 68, "900.678.1065 x7965", "Grant, Walter and Grimes", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 231, new DateTime(2022, 3, 10, 0, 4, 36, 338, DateTimeKind.Local).AddTicks(741), new DateTime(2022, 7, 31, 21, 15, 0, 256, DateTimeKind.Local).AddTicks(4), "Arthur61@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jaylon Waelchi", 89, "401.874.4578 x217", "Lowe - Kirlin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 233, new DateTime(2022, 2, 22, 2, 33, 56, 398, DateTimeKind.Local).AddTicks(530), new DateTime(2022, 9, 19, 10, 43, 36, 311, DateTimeKind.Local).AddTicks(2572), "Gerard74@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Emmy Klein", 6, "1-289-957-3051 x7303", "Purdy Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 235, new DateTime(2022, 2, 23, 20, 45, 37, 238, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 9, 4, 7, 49, 18, 82, DateTimeKind.Local).AddTicks(2835), "Cecil_Dickens99@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Dariana Hoeger", 33, "570-220-4534 x5351", "McKenzie - Hodkiewicz", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 237, new DateTime(2022, 6, 4, 14, 58, 2, 982, DateTimeKind.Local).AddTicks(6856), new DateTime(2022, 4, 29, 15, 37, 1, 323, DateTimeKind.Local).AddTicks(5710), "Melissa11@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bennie Beer", 98, "583.519.6410 x458", "Sipes, Pacocha and Renner", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 239, new DateTime(2022, 6, 12, 3, 1, 40, 451, DateTimeKind.Local).AddTicks(4647), new DateTime(2022, 9, 13, 0, 52, 54, 120, DateTimeKind.Local).AddTicks(6128), "Ginger.Schamberger61@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Marge Ullrich", 52, "(571) 732-6149 x8841", "Hermann - Bode", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 227, new DateTime(2022, 11, 18, 21, 40, 39, 507, DateTimeKind.Local).AddTicks(2652), new DateTime(2022, 4, 3, 18, 26, 35, 322, DateTimeKind.Local).AddTicks(9537), "Jeremiah92@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jazmin Paucek", 8, "(426) 898-0821 x47345", "Herman - Mueller", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 275, new DateTime(2022, 3, 6, 2, 25, 13, 278, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 9, 13, 11, 55, 44, 663, DateTimeKind.Local).AddTicks(8559), "Dennis.Von19@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Constance Lueilwitz", 51, "(880) 724-9877 x8261", "Weissnat - Pagac", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 139, new DateTime(2022, 12, 2, 5, 20, 2, 358, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 2, 6, 13, 19, 3, 371, DateTimeKind.Local).AddTicks(6639), "Todd_Halvorson@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kendra Hilpert", 15, "917.846.5322", "Mayert Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 135, new DateTime(2022, 11, 7, 21, 27, 9, 697, DateTimeKind.Local).AddTicks(9154), new DateTime(2022, 3, 5, 12, 13, 44, 184, DateTimeKind.Local).AddTicks(5677), "Joy_Yost63@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Aidan Hartmann", 85, "307.583.3642 x92515", "Trantow - Mraz", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 63, new DateTime(2022, 2, 13, 1, 0, 15, 812, DateTimeKind.Local).AddTicks(4465), new DateTime(2022, 11, 30, 5, 50, 18, 634, DateTimeKind.Local).AddTicks(1985), "Glenda_Moore@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Edwardo Brekke", 24, "1-689-251-5466 x1595", "Rutherford, Mosciski and Zboncak", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 61, new DateTime(2023, 2, 1, 7, 56, 28, 211, DateTimeKind.Local).AddTicks(3606), new DateTime(2022, 5, 30, 2, 43, 2, 784, DateTimeKind.Local).AddTicks(878), "Tasha70@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Amira Schiller", 73, "1-831-518-2812 x832", "Walsh - Lesch", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 59, new DateTime(2022, 7, 18, 22, 28, 45, 174, DateTimeKind.Local).AddTicks(1269), new DateTime(2022, 2, 11, 8, 2, 3, 38, DateTimeKind.Local).AddTicks(1297), "Jan.Bernier@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Pierre Shanahan", 78, "(688) 785-5232", "Wolf - Casper", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 57, new DateTime(2022, 2, 14, 1, 21, 50, 755, DateTimeKind.Local).AddTicks(4396), new DateTime(2022, 5, 12, 18, 23, 38, 510, DateTimeKind.Local).AddTicks(5277), "Amelia90@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Oswald Muller", 55, "638-672-7703", "Dach, Rowe and Rohan", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 55, new DateTime(2022, 4, 9, 0, 19, 10, 496, DateTimeKind.Local).AddTicks(9821), new DateTime(2023, 1, 19, 7, 29, 23, 548, DateTimeKind.Local).AddTicks(7418), "Hope.Nolan9@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Yasmin Greenholt", 51, "1-228-374-9714 x918", "Beatty Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 53, new DateTime(2022, 7, 21, 6, 36, 46, 179, DateTimeKind.Local).AddTicks(6171), new DateTime(2022, 10, 16, 2, 9, 53, 608, DateTimeKind.Local).AddTicks(7106), "Leo.Feeney@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rowland Lind", 87, "358-879-7632 x884", "Stracke Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 51, new DateTime(2023, 2, 1, 0, 48, 35, 279, DateTimeKind.Local).AddTicks(9198), new DateTime(2022, 8, 21, 17, 45, 18, 306, DateTimeKind.Local).AddTicks(3039), "Salvatore_Hyatt@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Shawna Moore", 44, "946-797-9805 x57660", "Jaskolski, Donnelly and Mann", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 49, new DateTime(2022, 12, 10, 9, 56, 25, 21, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 10, 22, 0, 35, 22, 45, DateTimeKind.Local).AddTicks(332), "Lonnie_Gottlieb@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alphonso Toy", 48, "225-776-9939 x85418", "Hand - Labadie", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 47, new DateTime(2022, 9, 17, 17, 27, 27, 29, DateTimeKind.Local).AddTicks(8648), new DateTime(2022, 10, 29, 2, 32, 42, 79, DateTimeKind.Local).AddTicks(3138), "Jordan.Nader@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Freda MacGyver", 9, "1-443-935-1723 x3324", "Ziemann, Kutch and Jacobs", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 45, new DateTime(2022, 8, 4, 21, 53, 28, 551, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 2, 5, 9, 17, 10, 469, DateTimeKind.Local).AddTicks(7814), "Lorene_Bode@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Brielle Cummings", 36, "225-781-3470 x7233", "Reichert, Kulas and Wehner", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 43, new DateTime(2023, 1, 23, 19, 36, 29, 556, DateTimeKind.Local).AddTicks(7256), new DateTime(2022, 12, 8, 9, 39, 49, 994, DateTimeKind.Local).AddTicks(185), "Phillip_Kessler@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Hazel Luettgen", 54, "1-867-569-8807 x51518", "Kuhic, Gottlieb and Padberg", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 41, new DateTime(2022, 10, 12, 22, 35, 6, 834, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 3, 15, 5, 10, 44, 442, DateTimeKind.Local).AddTicks(499), "Derrick.Hackett@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Lacey Bradtke", 61, "1-798-658-6995 x16569", "Kuvalis Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 39, new DateTime(2022, 5, 1, 15, 32, 14, 601, DateTimeKind.Local).AddTicks(1814), new DateTime(2022, 7, 9, 2, 11, 39, 303, DateTimeKind.Local).AddTicks(7783), "Nancy.OReilly37@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alisha Ullrich", 33, "964-758-4074", "Toy and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 37, new DateTime(2022, 3, 6, 8, 11, 52, 635, DateTimeKind.Local).AddTicks(2627), new DateTime(2022, 10, 4, 4, 37, 47, 798, DateTimeKind.Local).AddTicks(7507), "Emanuel_Schowalter33@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Maya Hackett", 3, "1-379-504-9203 x01424", "Lehner - Waters", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 35, new DateTime(2022, 9, 13, 0, 14, 22, 944, DateTimeKind.Local).AddTicks(7279), new DateTime(2022, 10, 24, 17, 2, 23, 425, DateTimeKind.Local).AddTicks(1591), "Sophia_Trantow22@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Will Wilkinson", 70, "1-797-836-6459", "O'Reilly LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 33, new DateTime(2023, 1, 16, 1, 15, 54, 201, DateTimeKind.Local).AddTicks(1246), new DateTime(2022, 4, 6, 1, 43, 34, 552, DateTimeKind.Local).AddTicks(2499), "Marlon11@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Athena Olson", 72, "1-702-848-5532 x02701", "Graham, Yost and Hahn", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 31, new DateTime(2022, 3, 12, 14, 58, 43, 427, DateTimeKind.Local).AddTicks(317), new DateTime(2022, 11, 8, 17, 50, 57, 111, DateTimeKind.Local).AddTicks(8398), "Julie11@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Ari Kris", 75, "1-462-368-1449 x2379", "Koch Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 3, new DateTime(2022, 6, 23, 13, 11, 13, 848, DateTimeKind.Local).AddTicks(1400), new DateTime(2023, 1, 21, 21, 56, 42, 593, DateTimeKind.Local).AddTicks(5638), "Amber5@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Garnett Morar", 86, "674-653-0503 x305", "Olson, Gislason and Parisian", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 5, new DateTime(2022, 9, 24, 0, 10, 57, 649, DateTimeKind.Local).AddTicks(5789), new DateTime(2022, 11, 9, 8, 31, 55, 677, DateTimeKind.Local).AddTicks(4228), "Omar_Kreiger@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Felton Blanda", 79, "933-498-8889", "Lynch Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 7, new DateTime(2022, 6, 26, 11, 13, 7, 583, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 5, 20, 4, 3, 19, 457, DateTimeKind.Local).AddTicks(6174), "Joy_Douglas@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Karina McClure", 39, "337.267.9703", "Turcotte, Abshire and Wyman", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 9, new DateTime(2022, 10, 28, 4, 54, 31, 619, DateTimeKind.Local).AddTicks(9495), new DateTime(2022, 9, 25, 5, 4, 39, 50, DateTimeKind.Local).AddTicks(3798), "Earnest_Bernhard@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Zachariah Jacobs", 28, "408-472-7184 x53293", "Schmitt Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 11, new DateTime(2022, 11, 8, 4, 19, 37, 362, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 8, 10, 6, 23, 18, 103, DateTimeKind.Local).AddTicks(5728), "Bobbie.Tromp@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Shannon McCullough", 99, "1-479-564-7462 x11376", "Fahey, Doyle and Johns", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 13, new DateTime(2022, 11, 24, 11, 17, 37, 341, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 9, 13, 10, 21, 4, 152, DateTimeKind.Local).AddTicks(6616), "Edna26@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alexane Abshire", 1, "809-567-3743 x80212", "Ruecker, Wunsch and Koch", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 65, new DateTime(2022, 12, 1, 15, 17, 3, 76, DateTimeKind.Local).AddTicks(5568), new DateTime(2022, 4, 20, 15, 15, 58, 215, DateTimeKind.Local).AddTicks(8698), "Terrance.Stoltenberg16@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Einar Paucek", 82, "1-321-348-4736 x0292", "Morar LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 15, new DateTime(2022, 11, 13, 11, 37, 41, 436, DateTimeKind.Local).AddTicks(9279), new DateTime(2022, 4, 4, 10, 19, 6, 2, DateTimeKind.Local).AddTicks(5054), "Shawn69@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Colton Kling", 74, "1-771-246-3128 x8603", "Lebsack - Pollich", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 19, new DateTime(2022, 12, 20, 17, 50, 2, 989, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 6, 24, 4, 39, 19, 878, DateTimeKind.Local).AddTicks(2397), "John.Ullrich3@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Virgil Bernhard", 17, "(406) 971-1522", "Kling, Stoltenberg and Koelpin", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 21, new DateTime(2023, 1, 2, 4, 6, 28, 361, DateTimeKind.Local).AddTicks(9729), new DateTime(2022, 2, 25, 19, 43, 37, 611, DateTimeKind.Local).AddTicks(2807), "Oliver.Beahan9@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kaden Lindgren", 4, "271-846-2097 x571", "Armstrong - Kiehn", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 23, new DateTime(2022, 10, 14, 22, 26, 51, 627, DateTimeKind.Local).AddTicks(1130), new DateTime(2022, 2, 12, 7, 5, 30, 620, DateTimeKind.Local).AddTicks(4970), "Emilio75@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Heloise Wisoky", 37, "(438) 285-9213 x1675", "Labadie LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 25, new DateTime(2022, 9, 22, 20, 53, 15, 321, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 6, 28, 8, 25, 13, 228, DateTimeKind.Local).AddTicks(7356), "Frederick.Lind@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Syble O'Reilly", 58, "378.751.1669 x33046", "Stoltenberg - Hodkiewicz", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 27, new DateTime(2022, 4, 6, 20, 52, 15, 630, DateTimeKind.Local).AddTicks(9441), new DateTime(2022, 4, 24, 22, 11, 55, 347, DateTimeKind.Local).AddTicks(9147), "Robert33@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Erik Huel", 54, "1-914-493-0160 x2737", "Friesen, Sawayn and Orn", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 29, new DateTime(2022, 10, 20, 6, 15, 7, 592, DateTimeKind.Local).AddTicks(3702), new DateTime(2022, 12, 10, 20, 34, 22, 392, DateTimeKind.Local).AddTicks(9769), "Reginald.Pacocha19@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alene King", 24, "342-701-7102 x061", "Hoppe - McKenzie", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 17, new DateTime(2022, 7, 18, 4, 53, 7, 774, DateTimeKind.Local).AddTicks(9129), new DateTime(2022, 8, 4, 11, 20, 18, 341, DateTimeKind.Local).AddTicks(3933), "Nichole_Effertz76@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kenna Huel", 5, "653.388.7046", "Ruecker, Haley and Mohr", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 137, new DateTime(2022, 4, 2, 9, 12, 58, 619, DateTimeKind.Local).AddTicks(7041), new DateTime(2022, 10, 24, 0, 8, 6, 876, DateTimeKind.Local).AddTicks(5028), "Lance_Schmitt36@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Lelia Emmerich", 87, "1-778-855-1435 x5745", "Mann, Kub and Kulas", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 67, new DateTime(2022, 4, 13, 20, 38, 40, 631, DateTimeKind.Local).AddTicks(1582), new DateTime(2022, 9, 8, 20, 36, 43, 495, DateTimeKind.Local).AddTicks(5716), "Julia_Rohan99@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Adolph Cruickshank", 1, "553.284.0109", "Zulauf, Harris and Fadel", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 71, new DateTime(2022, 3, 14, 6, 52, 10, 587, DateTimeKind.Local).AddTicks(4440), new DateTime(2022, 11, 2, 11, 33, 41, 676, DateTimeKind.Local).AddTicks(8689), "Katie.Kilback@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Stuart Paucek", 85, "1-388-878-4155 x49516", "Kling, Walker and Keebler", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 133, new DateTime(2022, 5, 10, 5, 49, 24, 597, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 7, 31, 10, 10, 11, 359, DateTimeKind.Local).AddTicks(9244), "Kristi14@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Nellie Deckow", 74, "(663) 402-3783 x758", "Hilpert Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 131, new DateTime(2022, 5, 15, 12, 50, 55, 526, DateTimeKind.Local).AddTicks(1548), new DateTime(2022, 5, 26, 23, 19, 22, 953, DateTimeKind.Local).AddTicks(586), "Carole.Kunde84@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rubye Kreiger", 86, "1-630-489-7996 x289", "Okuneva, Hoeger and Zemlak", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 129, new DateTime(2022, 5, 23, 4, 27, 27, 966, DateTimeKind.Local).AddTicks(1808), new DateTime(2022, 2, 23, 3, 51, 4, 745, DateTimeKind.Local).AddTicks(6187), "Nora_Miller@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Velma Sipes", 48, "898-378-1518 x398", "Langworth and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 127, new DateTime(2023, 2, 8, 16, 42, 4, 180, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 11, 2, 8, 25, 50, 245, DateTimeKind.Local).AddTicks(8996), "Alexis.Wuckert74@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Aaliyah Kirlin", 98, "1-660-642-6543", "Johnston - Klein", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 125, new DateTime(2022, 8, 16, 16, 27, 28, 389, DateTimeKind.Local).AddTicks(4023), new DateTime(2022, 5, 24, 12, 42, 43, 752, DateTimeKind.Local).AddTicks(1688), "Margaret_Terry@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Bettie Barton", 89, "(292) 409-2398 x8287", "Murazik, Graham and Stark", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 123, new DateTime(2022, 8, 27, 13, 0, 44, 457, DateTimeKind.Local).AddTicks(2987), new DateTime(2022, 5, 10, 4, 36, 37, 636, DateTimeKind.Local).AddTicks(9889), "Cristina_Lind63@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Peggie Dickinson", 86, "1-390-251-9799 x760", "Volkman and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 121, new DateTime(2022, 8, 23, 17, 32, 10, 245, DateTimeKind.Local).AddTicks(3642), new DateTime(2022, 7, 27, 22, 42, 10, 968, DateTimeKind.Local).AddTicks(8595), "Krystal.Jacobi5@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Kim Carter", 57, "323.350.3092 x492", "O'Conner, Bergnaum and Nitzsche", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 119, new DateTime(2022, 11, 11, 10, 24, 5, 363, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 5, 26, 22, 32, 1, 772, DateTimeKind.Local).AddTicks(6500), "Martha_Cassin@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Marlee Douglas", 65, "679-296-6069", "Pfeffer, Hauck and Hermiston", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 117, new DateTime(2022, 10, 17, 20, 21, 35, 597, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 11, 22, 22, 4, 59, 252, DateTimeKind.Local).AddTicks(5517), "Cathy_Boehm52@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Fausto Shanahan", 20, "211.380.3873", "Rutherford, Ratke and Bins", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 115, new DateTime(2022, 7, 7, 9, 52, 55, 855, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 2, 27, 12, 37, 30, 88, DateTimeKind.Local).AddTicks(6999), "Karla71@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Joshuah Johnson", 10, "1-401-617-7563", "Lakin, Ryan and Kilback", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 113, new DateTime(2022, 12, 1, 21, 5, 57, 298, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 1, 17, 16, 41, 43, 791, DateTimeKind.Local).AddTicks(5860), "Paul.Stoltenberg@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Rhett Weissnat", 50, "330.692.3087 x03239", "Russel, Veum and Dibbert", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 111, new DateTime(2022, 5, 22, 1, 47, 9, 92, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 7, 30, 2, 14, 25, 202, DateTimeKind.Local).AddTicks(58), "Darrin_Lynch@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Seth Hagenes", 92, "543.334.7879 x459", "Quigley - Gusikowski", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 109, new DateTime(2022, 4, 24, 10, 0, 16, 405, DateTimeKind.Local).AddTicks(9931), new DateTime(2022, 3, 9, 5, 59, 54, 67, DateTimeKind.Local).AddTicks(3083), "Marguerite28@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jadon Moen", 76, "517-462-7775 x38520", "O'Keefe LLC", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 107, new DateTime(2022, 3, 31, 19, 42, 34, 463, DateTimeKind.Local).AddTicks(7822), new DateTime(2022, 11, 22, 7, 43, 39, 576, DateTimeKind.Local).AddTicks(1711), "Wade_Morar@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Halie Windler", 43, "986.596.5538", "Gislason, Roberts and Kemmer", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 105, new DateTime(2022, 12, 17, 0, 10, 15, 466, DateTimeKind.Local).AddTicks(3611), new DateTime(2022, 5, 16, 5, 12, 53, 392, DateTimeKind.Local).AddTicks(563), "Sylvia20@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Casimer Bogan", 99, "(885) 625-1652 x82460", "Collier - Greenfelder", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 103, new DateTime(2022, 8, 23, 7, 14, 43, 626, DateTimeKind.Local).AddTicks(4217), new DateTime(2022, 3, 5, 10, 47, 56, 117, DateTimeKind.Local).AddTicks(8119), "Robyn.Pouros17@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Delaney Lemke", 16, "898-898-6696", "Harber - Murray", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 101, new DateTime(2022, 6, 15, 12, 5, 26, 609, DateTimeKind.Local).AddTicks(4067), new DateTime(2022, 2, 25, 2, 31, 35, 166, DateTimeKind.Local).AddTicks(3208), "Karl.Reichert@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Alvena Hane", 38, "1-896-836-6138 x861", "Heathcote - Heidenreich", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 73, new DateTime(2022, 9, 30, 7, 51, 16, 390, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 6, 19, 19, 10, 23, 57, DateTimeKind.Local).AddTicks(3335), "Sabrina.Quigley99@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Johnathon McCullough", 45, "1-974-519-8614", "Schneider, Marks and Feest", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 75, new DateTime(2022, 12, 8, 2, 27, 22, 372, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 1, 15, 0, 28, 28, 765, DateTimeKind.Local).AddTicks(4814), "Scott_Medhurst@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Eloisa Shields", 90, "(548) 460-2745 x0222", "Nitzsche - Pacocha", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 77, new DateTime(2022, 10, 18, 4, 12, 4, 201, DateTimeKind.Local).AddTicks(2469), new DateTime(2022, 2, 27, 0, 36, 33, 79, DateTimeKind.Local).AddTicks(3327), "Ricky74@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Matteo Bechtelar", 6, "720.828.1492", "Toy, Bartoletti and Hackett", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 79, new DateTime(2022, 4, 24, 10, 0, 30, 753, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 6, 18, 13, 58, 16, 642, DateTimeKind.Local).AddTicks(9806), "Bob4@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jaylin Funk", 7, "(379) 751-4928 x50814", "Paucek, Tremblay and Schiller", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 81, new DateTime(2022, 7, 16, 12, 31, 11, 430, DateTimeKind.Local).AddTicks(6944), new DateTime(2022, 12, 28, 12, 48, 58, 834, DateTimeKind.Local).AddTicks(5080), "Jan_Murphy@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jennie Bogan", 95, "1-369-394-7242", "Weimann - Durgan", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 83, new DateTime(2022, 7, 28, 11, 29, 13, 840, DateTimeKind.Local).AddTicks(7973), new DateTime(2022, 4, 15, 1, 28, 18, 357, DateTimeKind.Local).AddTicks(7659), "Dawn28@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Houston Hartmann", 34, "1-408-975-4724 x503", "Fisher and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 69, new DateTime(2022, 5, 23, 21, 52, 2, 568, DateTimeKind.Local).AddTicks(8681), new DateTime(2022, 10, 4, 7, 19, 20, 255, DateTimeKind.Local).AddTicks(1075), "Roger.Walker@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Aiden Rempel", 48, "229-228-6133", "Boyle - Boehm", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 85, new DateTime(2022, 8, 20, 15, 1, 18, 178, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 10, 20, 22, 34, 55, 542, DateTimeKind.Local).AddTicks(1119), "Neil12@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jack Nolan", 48, "868.521.3701", "Howell Inc", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 89, new DateTime(2022, 9, 26, 22, 34, 13, 960, DateTimeKind.Local).AddTicks(6184), new DateTime(2022, 6, 13, 6, 29, 38, 730, DateTimeKind.Local).AddTicks(5846), "Terrell.Hauck6@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Art Smith", 55, "1-730-839-0308 x49074", "Harris, Gerhold and Turcotte", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 91, new DateTime(2022, 3, 13, 18, 41, 52, 560, DateTimeKind.Local).AddTicks(9011), new DateTime(2022, 4, 2, 23, 26, 36, 790, DateTimeKind.Local).AddTicks(9089), "Phil_Harvey92@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Jayce Gulgowski", 69, "(673) 674-7265 x386", "Rath, Crist and Schultz", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 93, new DateTime(2022, 9, 9, 21, 5, 38, 508, DateTimeKind.Local).AddTicks(807), new DateTime(2022, 7, 24, 19, 0, 16, 868, DateTimeKind.Local).AddTicks(9910), "Angie67@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Reta Padberg", 47, "1-286-986-0634 x987", "Mills and Sons", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 95, new DateTime(2023, 1, 23, 14, 42, 5, 199, DateTimeKind.Local).AddTicks(8303), new DateTime(2022, 2, 16, 1, 25, 5, 360, DateTimeKind.Local).AddTicks(4887), "Kristina15@yahoo.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Wanda Kshlerin", 81, "1-451-256-6825 x31740", "Larson - Macejkovic", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 97, new DateTime(2022, 4, 21, 18, 3, 21, 459, DateTimeKind.Local).AddTicks(7134), new DateTime(2022, 4, 6, 11, 22, 30, 955, DateTimeKind.Local).AddTicks(2844), "Luther.Turner@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Nicklaus Kunze", 39, "825-864-1716 x0155", "Von - Donnelly", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 99, new DateTime(2022, 4, 18, 6, 7, 16, 187, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 7, 30, 6, 35, 33, 701, DateTimeKind.Local).AddTicks(4456), "Billy54@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Delfina Bogan", 33, "702.448.8209 x25708", "Quitzon, Botsford and Hartmann", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 87, new DateTime(2022, 9, 2, 9, 2, 23, 973, DateTimeKind.Local).AddTicks(3777), new DateTime(2022, 7, 27, 7, 13, 45, 408, DateTimeKind.Local).AddTicks(4427), "Garrett11@gmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Elenor Rath", 36, "(787) 609-3766 x57155", "Fritsch Group", null });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "CreateAt", "DataEvento", "Email", "ImagemURL", "Local", "QtdPessoas", "Telefone", "Tema", "UpdateAt" },
                values: new object[] { 277, new DateTime(2022, 4, 13, 11, 39, 11, 640, DateTimeKind.Local).AddTicks(1500), new DateTime(2022, 5, 12, 18, 54, 53, 936, DateTimeKind.Local).AddTicks(4035), "James.Metz73@hotmail.com", "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E", "Elliot Harvey", 15, "(536) 696-7016", "Smitham - Hartmann", null });

            migrationBuilder.CreateIndex(
                name: "IX_Lotes_EventoId",
                table: "Lotes",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_PalestranteEvento_PalestranteId",
                table: "PalestranteEvento",
                column: "PalestranteId");

            migrationBuilder.CreateIndex(
                name: "IX_RedeSociais_EventoId",
                table: "RedeSociais",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_RedeSociais_PalestranteId",
                table: "RedeSociais",
                column: "PalestranteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lotes");

            migrationBuilder.DropTable(
                name: "PalestranteEvento");

            migrationBuilder.DropTable(
                name: "RedeSociais");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Palestrantes");
        }
    }
}
