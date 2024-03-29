﻿using System.Collections.Generic;
using Bogus;
using ProEventos.Domain.Entities;

namespace ProEventos.Persistence.Seeds
{
    public static class EventoSeeds
    {
        public static void Eventos(DataContext context)
        {
            var n = Randomizer.Seed.Next(1, 20);
            List<Evento> eventos = new List<Evento>();
            List<Lote> lotes = new();

            for (var i = 1; i < n; i++)
            {
                var fake = new Faker("pt_BR");
                var fakeEvento = new Evento(fake.Name.FullName(),
                                                fake.Date.Future(),
                                                fake.Company.CompanyName(),
                                                fake.Random.Number(0, 100),
                                                fake.Image.DataUri(150, 200),
                                                fake.Phone.PhoneNumber(),
                                                fake.Person.Email);
                eventos.Add(fakeEvento);
            }
            context.Set<Evento>().AddRange(eventos);
            context.SaveChanges();

            eventos.ForEach(evento =>
            {
                for (var ivento = 1; ivento < n; ivento++)
                {
                    var fakerLote = new Faker<Lote>()
                    .RuleFor(l => l.Nome, l => l.Name.FullName())
                    .RuleFor(d => d.Quantidade, d => d.Random.Number(0, 100))
                    .RuleFor(d => d.DataIncio, d => d.Date.Recent())
                    .RuleFor(d => d.DataFim, d => d.Date.Future())
                    .RuleFor(d => d.Preco, d => d.Random.Number(0, 100))
                    .RuleFor(lote => lote.EventoId, evento.Id)
                    .RuleFor(lote => lote.Evento, evento)
                    .Generate();
                    lotes.Add(fakerLote);
                    ivento++;
                }
            });

            context.AddRange(lotes);
            context.SaveChanges();
        }
    }
}
