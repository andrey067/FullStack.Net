﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEventos.Persistence;

namespace ProEventos.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("ProEventos.Domain.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataEvento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Local")
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tema")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Eventos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 2, 2, 6, 15, 51, 821, DateTimeKind.Local).AddTicks(4439),
                            DataEvento = new DateTime(2022, 9, 5, 5, 19, 8, 569, DateTimeKind.Local).AddTicks(5176),
                            Email = "Austin.Brakus53@yahoo.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Malvina Mante",
                            QtdPessoas = 95,
                            Telefone = "424-282-7787",
                            Tema = "Lubowitz - Krajcik"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 6, 29, 6, 8, 56, 463, DateTimeKind.Local).AddTicks(8222),
                            DataEvento = new DateTime(2022, 9, 8, 17, 33, 56, 374, DateTimeKind.Local).AddTicks(6444),
                            Email = "Rolando.Carroll@yahoo.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Jacky Littel",
                            QtdPessoas = 93,
                            Telefone = "(433) 634-5370 x77917",
                            Tema = "Kohler and Sons"
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2022, 11, 16, 2, 14, 2, 39, DateTimeKind.Local).AddTicks(9913),
                            DataEvento = new DateTime(2022, 10, 3, 15, 44, 49, 733, DateTimeKind.Local).AddTicks(8055),
                            Email = "Noah_Pagac@gmail.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Rafaela Yundt",
                            QtdPessoas = 75,
                            Telefone = "571.584.9734",
                            Tema = "McGlynn - Koepp"
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2023, 4, 18, 22, 19, 59, 207, DateTimeKind.Local).AddTicks(5995),
                            DataEvento = new DateTime(2022, 10, 3, 22, 3, 7, 620, DateTimeKind.Local).AddTicks(1842),
                            Email = "Esther_Lubowitz@gmail.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Burdette Blanda",
                            QtdPessoas = 9,
                            Telefone = "573.895.2538 x337",
                            Tema = "Paucek, Fay and Hansen"
                        },
                        new
                        {
                            Id = 9,
                            CreateAt = new DateTime(2023, 6, 26, 8, 3, 29, 529, DateTimeKind.Local).AddTicks(3940),
                            DataEvento = new DateTime(2023, 5, 3, 12, 56, 36, 742, DateTimeKind.Local).AddTicks(1211),
                            Email = "Edgar.Boyle97@gmail.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Morton Raynor",
                            QtdPessoas = 59,
                            Telefone = "952-950-4348 x211",
                            Tema = "Stamm Group"
                        },
                        new
                        {
                            Id = 11,
                            CreateAt = new DateTime(2022, 10, 12, 10, 46, 43, 111, DateTimeKind.Local).AddTicks(5845),
                            DataEvento = new DateTime(2023, 5, 31, 4, 32, 52, 95, DateTimeKind.Local).AddTicks(3598),
                            Email = "Norma46@yahoo.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Rosalyn Anderson",
                            QtdPessoas = 23,
                            Telefone = "982-646-9472 x30814",
                            Tema = "Hettinger Inc"
                        },
                        new
                        {
                            Id = 13,
                            CreateAt = new DateTime(2022, 12, 1, 14, 29, 5, 879, DateTimeKind.Local).AddTicks(5085),
                            DataEvento = new DateTime(2023, 1, 9, 0, 58, 16, 822, DateTimeKind.Local).AddTicks(5682),
                            Email = "Bruce97@hotmail.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Yessenia Kassulke",
                            QtdPessoas = 87,
                            Telefone = "768.848.3319",
                            Tema = "Harber LLC"
                        },
                        new
                        {
                            Id = 15,
                            CreateAt = new DateTime(2023, 4, 16, 9, 53, 59, 242, DateTimeKind.Local).AddTicks(412),
                            DataEvento = new DateTime(2023, 3, 30, 2, 20, 34, 80, DateTimeKind.Local).AddTicks(9477),
                            Email = "Christy_Hayes82@gmail.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Neha Baumbach",
                            QtdPessoas = 7,
                            Telefone = "915-644-2546 x561",
                            Tema = "Walter, Dickens and Franecki"
                        },
                        new
                        {
                            Id = 17,
                            CreateAt = new DateTime(2023, 6, 30, 14, 41, 50, 279, DateTimeKind.Local).AddTicks(2068),
                            DataEvento = new DateTime(2022, 10, 17, 16, 4, 1, 949, DateTimeKind.Local).AddTicks(6061),
                            Email = "Armando_Murazik@yahoo.com",
                            ImagemURL = "data:image/svg+xml;charset=UTF-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20version%3D%221.1%22%20baseProfile%3D%22full%22%20width%3D%22150%22%20height%3D%22200%22%3E%3Crect%20width%3D%22100%25%22%20height%3D%22100%25%22%20fill%3D%22grey%22%2F%3E%3Ctext%20x%3D%2275%22%20y%3D%22100%22%20font-size%3D%2220%22%20alignment-baseline%3D%22middle%22%20text-anchor%3D%22middle%22%20fill%3D%22white%22%3E150x200%3C%2Ftext%3E%3C%2Fsvg%3E",
                            Local = "Miracle Wolf",
                            QtdPessoas = 85,
                            Telefone = "1-772-261-9584 x50961",
                            Tema = "O'Kon - McLaughlin"
                        });
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.Lote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIncio")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.Palestrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiniCurriculo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Palestrantes");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.Palestrante_Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PalestranteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("EventoId", "PalestranteId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("PalestranteEvento");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.RedeSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PalestranteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("RedeSociais");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.Lote", b =>
                {
                    b.HasOne("ProEventos.Domain.Entities.Evento", "Evento")
                        .WithMany("Lotes")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.Palestrante_Evento", b =>
                {
                    b.HasOne("ProEventos.Domain.Entities.Evento", "Evento")
                        .WithMany("PalestrantesEventos")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProEventos.Domain.Entities.Palestrante", "Palestrante")
                        .WithMany("PalestrantesEventos")
                        .HasForeignKey("PalestranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Palestrante");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.RedeSocial", b =>
                {
                    b.HasOne("ProEventos.Domain.Entities.Evento", "Evento")
                        .WithMany("RedeSociais")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProEventos.Domain.Entities.Palestrante", "Palestrante")
                        .WithMany("RedeSociais")
                        .HasForeignKey("PalestranteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Evento");

                    b.Navigation("Palestrante");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.Evento", b =>
                {
                    b.Navigation("Lotes");

                    b.Navigation("PalestrantesEventos");

                    b.Navigation("RedeSociais");
                });

            modelBuilder.Entity("ProEventos.Domain.Entities.Palestrante", b =>
                {
                    b.Navigation("PalestrantesEventos");

                    b.Navigation("RedeSociais");
                });
#pragma warning restore 612, 618
        }
    }
}
