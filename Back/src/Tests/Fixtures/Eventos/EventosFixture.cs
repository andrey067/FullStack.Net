using Bogus;
using ProEventos.Domain.Entities;
using ProEventos.Services.Dtos;
using ProEventos.Services.Dtos.Eventos;

namespace ProEventos.Fixtures.Eventos
{
    public class EventosFixture
    {
        public static List<EventoDto> GetEventosDto()
        {
            var n = Randomizer.Seed.Next(1, 20);
            List<EventoDto> eventosDto = new();
            List<LoteDto> lotes = new();

            for (var i = 1; i < n; i++)
            {
                var fakerEventodto = new Faker<EventoDto>()
                .RuleFor(l => l.Local, l => l.Name.FullName())
                .RuleFor(d => d.DataEvento, d => d.Date.Future())
                .RuleFor(t => t.Tema, t => t.Company.CompanyName())
                .RuleFor(qtd => qtd.QtdPessoas, qtd => qtd.Random.Number(0, 100))
                .RuleFor(img => img.ImagemURL, img => img.Image.DataUri(150, 200))
                .RuleFor(tel => tel.Telefone, tel => tel.Phone.PhoneNumber())
                .RuleFor(e => e.Email, e => e.Person.Email)
                .RuleFor(e => e.CreateAt, DateTime.Now).Generate();
                //.RuleFor(e => e.Lotes, new List<LoteDto>());
                eventosDto.Add(fakerEventodto);
            }

            //eventosDto.ForEach(evento =>
            //{
            //    for (var ivento = 1; ivento < n; ivento++)
            //    {
            //        var fakerLote = new Faker<LoteDto>()
            //        .RuleFor(l => l.Nome, l => l.Name.FullName())
            //        .RuleFor(d => d.Quantidade, d => d.Random.Number(0, 100))
            //        .RuleFor(d => d.DataIncio, d => d.Date.Recent())
            //        .RuleFor(d => d.DataFim, d => d.Date.Future())
            //        .RuleFor(d => d.Preco, d => d.Random.Number(0, 100))
            //        .RuleFor(lote => lote.EventoId, evento.Id)
            //        .RuleFor(lote => lote.EventoId, evento.Id).Generate();
            //        lotes.Add(fakerLote);
            //        ivento++;
            //    }
            //});

            return eventosDto;
        }

        public static EventoDto GetEventoDto()
        {
            var fakerEventodto = new Faker<EventoDto>()
                .RuleFor(i => i.Id, f => f.IndexFaker)
                .RuleFor(l => l.Local, l => l.Name.FullName())
                .RuleFor(d => d.DataEvento, d => d.Date.Future())
                .RuleFor(t => t.Tema, t => t.Company.CompanyName())
                .RuleFor(qtd => qtd.QtdPessoas, qtd => qtd.Random.Number(0, 100))
                .RuleFor(img => img.ImagemURL, img => img.Image.DataUri(150, 200))
                .RuleFor(tel => tel.Telefone, tel => tel.Phone.PhoneNumber())
                .RuleFor(e => e.Email, e => e.Person.Email).Generate();
            return fakerEventodto;
        }

        public static List<Evento> GetEventos()
        {
            var n = Randomizer.Seed.Next(1, 20);
            List<Evento> eventos = new();
            List<Lote> lotes = new();

            for (var i = 1; i < n; i++)
            {
                var fakerEvento = new Faker<Evento>()
                .RuleFor(l => l.Id, i)
                .RuleFor(l => l.Local, l => l.Name.FullName())
                .RuleFor(d => d.DataEvento, d => d.Date.Future())
                .RuleFor(t => t.Tema, t => t.Company.CompanyName())
                .RuleFor(qtd => qtd.QtdPessoas, qtd => qtd.Random.Number(0, 100))
                .RuleFor(img => img.ImagemURL, img => img.Image.DataUri(150, 200))
                .RuleFor(tel => tel.Telefone, tel => tel.Phone.PhoneNumber())
                .RuleFor(e => e.Email, e => e.Person.Email).Generate();
                eventos.Add(fakerEvento);
            }

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
                    .RuleFor(lote => lote.Evento, evento).Generate();
                    lotes.Add(fakerLote);
                    ivento++;
                }
            });

            return eventos;
        }

        public static (CreateEventoDto, EventoDto) PostEvento()
        {
            var fakerEventodto = new Faker<CreateEventoDto>("pt_BR")
                .RuleFor(l => l.Local, l => l.Name.FullName())
                .RuleFor(d => d.DataEvento, d => d.Date.Future())
                .RuleFor(t => t.Tema, t => t.Company.CompanyName())
                .RuleFor(qtd => qtd.QtdPessoas, qtd => qtd.Random.Number(0, 100))
                .RuleFor(img => img.ImagemURL, img => img.Image.DataUri(150, 200))
                .RuleFor(tel => tel.Telefone, tel => tel.Phone.PhoneNumber())
                .RuleFor(e => e.Email, e => e.Person.Email).Generate();

            var eventoDto = new EventoDto()
            {
                Id = new Faker().Random.Int(1, 100),
                Local = fakerEventodto.Local,
                DataEvento = fakerEventodto.DataEvento,
                Tema = fakerEventodto.Tema,
                QtdPessoas = fakerEventodto.QtdPessoas,
                ImagemURL = fakerEventodto.ImagemURL,
                Telefone = fakerEventodto.Telefone,
                Email = fakerEventodto.Email,
                CreateAt = DateTime.UtcNow
            };

            return (fakerEventodto, eventoDto);
        }

        public static int DeleteEvento() => new Faker().Random.Int(1, 100);

    }
}
