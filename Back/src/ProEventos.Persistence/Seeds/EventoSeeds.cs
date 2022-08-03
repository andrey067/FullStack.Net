
using Bogus;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using System;
using System.Collections.Generic;

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
                var fakerEvento = new Faker<Evento>()                
                .RuleFor(l => l.Local, l => l.Name.FullName())
                .RuleFor(d => d.DataEvento, d => d.Date.Future())
                .RuleFor(t => t.Tema, t => t.Company.CompanyName())
                .RuleFor(qtd => qtd.QtdPessoas, qtd => qtd.Random.Number(0, 100))
                .RuleFor(img => img.ImagemURL, img => img.Image.DataUri(150, 200))
                .RuleFor(tel => tel.Telefone, tel => tel.Phone.PhoneNumber())
                .RuleFor(e => e.Email, e => e.Person.Email)
                .RuleFor(e => e.CreateAt, DateTime.Now)
                .RuleFor(e => e.Lotes, new List<Lote>()).Generate();
                eventos.Add(fakerEvento);
            }
            context.AddRange(eventos);
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