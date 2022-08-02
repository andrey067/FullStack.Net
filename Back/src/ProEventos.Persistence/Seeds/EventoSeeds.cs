
using Bogus;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using System.Collections.Generic;

namespace ProEventos.Persistence.Seeds
{
    public static class EventoSeeds
    {
        public static void Eventos(ModelBuilder modelBuilder)
        {
            var n = Randomizer.Seed.Next(1, 20);
            List<Evento> eventos = new List<Evento>();
            //List<Lote> lotes = new List<Lote>();
            for (var i = 1; i < n; i++)
            {
                var fakerEvento = new Faker<Evento>()
                .RuleFor(id => id.Id, i)
                .RuleFor(l => l.Local, l => l.Name.FullName())
                .RuleFor(d => d.DataEvento, d => d.Date.Future())
                .RuleFor(t => t.Tema, t => t.Company.CompanyName())
                .RuleFor(qtd => qtd.QtdPessoas, qtd => qtd.Random.Number(0, 100))
                .RuleFor(img => img.ImagemURL, img => img.Image.DataUri(150, 200))
                .RuleFor(tel => tel.Telefone, tel => tel.Phone.PhoneNumber())
                .RuleFor(e => e.Email, e => e.Person.Email)
                .RuleFor(e => e.Lotes, new List<Lote>())
                .RuleFor(create => create.CreateAt, create => create.Date.Future()).Generate();
                eventos.Add(fakerEvento);
                i++;
            }

            //eventos.ForEach(evento => evento.Lotes.AddRange(GerarLotes(eventos.Count, evento)));

            modelBuilder.Entity<Evento>().HasData(eventos);

            //eventos.ForEach(evento =>
            //{
            //    evento.Lotes.ForEach(lote =>
            //    {                    
            //        modelBuilder.Entity<Lote>().HasData(lote);


            //    });
            //});
        }

        private static IEnumerable<Lote> GerarLotes(int qtd, Evento evento)
        {
            var fakerLote = new Faker<Lote>()
                .RuleFor(id => id.Id, i => i.IndexFaker)
                .RuleFor(l => l.Nome, l => l.Name.FullName())
                .RuleFor(lote => lote.Preco, preco => preco.Random.Decimal(0, 1000))
                .RuleFor(lote => lote.DataIncio, d => d.Date.Future())
                .RuleFor(lote => lote.DataFim, d => d.Date.Future())
                .RuleFor(lote => lote.Quantidade, qtd => qtd.Random.Number(0, 100))
                .RuleFor(lote => lote.EventoId, evento.Id)
                .RuleFor(lote => lote.Evento, evento)
                .Generate(qtd);
            return fakerLote;
        }


        //public string Nome { get; set; }
        //public decimal Preco { get; set; }
        //public DateTime DataIncio { get; set; }
        //public DateTime DataFim { get; set; }
        //public int Quantidade { get; set; }
        //public int EventoId { get; set; }
        //public Evento Evento { get; set; }
    }
}