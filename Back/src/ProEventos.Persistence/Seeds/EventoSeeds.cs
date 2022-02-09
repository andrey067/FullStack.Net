
using System.Collections.Generic;
using Bogus;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;

namespace ProEventos.Persistence.Seeds
{
    public static class EventoSeeds
    {
        public static void Eventos(ModelBuilder modelBuilder)
        {
            var n = Randomizer.Seed.Next(1, 1000);
            List<Evento> eventos = new List<Evento>();
            for (var i = 1; i < n; i++)
            {
                var faker = new Faker<Evento>()
                .RuleFor(id => id.Id, i)
                .RuleFor(l => l.Local, l => l.Name.FullName())
                .RuleFor(d => d.DataEvento, d => d.Date.Future())
                .RuleFor(t => t.Tema, t => t.Company.CompanyName())
                .RuleFor(qtd => qtd.QtdPessoas, qtd => qtd.Random.Number(0, 100))
                .RuleFor(img => img.ImagemURL, img => img.Image.DataUri(150, 200))
                .RuleFor(tel => tel.Telefone, tel => tel.Phone.PhoneNumber())
                .RuleFor(e => e.Email, e => e.Person.Email)
                .RuleFor(create => create.CreateAt, create => create.Date.Future());
                eventos.Add(faker);
                i++;
            }

            eventos.ForEach(e =>

            modelBuilder.Entity<Evento>().HasData(
                new Evento()
                {
                    Id = e.Id,
                    Local = e.Local,
                    DataEvento = e.DataEvento,
                    Tema = e.Tema,
                    QtdPessoas = e.QtdPessoas,
                    ImagemURL = e.ImagemURL,
                    Telefone = e.Telefone,
                    Email = e.Email,
                    CreateAt = e.CreateAt
                })
            );
        }
    }
}