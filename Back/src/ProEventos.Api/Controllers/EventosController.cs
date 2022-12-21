using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Core.Notifications;
using ProEventos.Core.Notifications.Interfaces;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos.Eventos;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("/eventos")]
    public class EventosController : BaseController
    {
        public EventosController(IDomainNotificationHandlerAsync<DomainNotification> notificacaoDeDominio) : base(notificacaoDeDominio) { }

        [HttpGet]
        public async Task<ActionResult<List<EventoDto>>> Get([FromServices] IEventoService _eventoService)
        {
            var eventos = await _eventoService.GetAllEventosAsync(true);
            if (eventos.Count() == 0) return NoContent();

            return Ok(eventos);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<EventoDto>> GetById([FromServices] IEventoService _eventoService, int id)
        {
            var eventos = await _eventoService.Get(id);
            if (eventos == null) return NoContent();
            return Ok(eventos);
        }

        [HttpPost]
        public async Task<ActionResult<EventoDto>> InsertEvento([FromServices] IEventoService _eventoService, CreateEventoDto createEventoDto)
        {
            var eventos = await _eventoService.AddEvento(createEventoDto);
            return Ok(eventos);
        }

        [HttpGet("/tema/{tema}")]
        public async Task<IActionResult> GetByTema([FromServices] IEventoService _eventoService, string tema)
        {
            var eventos = await _eventoService.GetAllEventosByTemaAsync(tema, true);
            if (eventos == null) return NoContent();

            return Ok(eventos);
        }

        [HttpDelete("/{id}")]
        public async Task<IActionResult> DeletarEvento([FromServices] IEventoService _eventoService, int id)
        {
            var deletarEvento = await _eventoService.DeleteEvento(id);

            if (!deletarEvento) return NoContent();

            return Ok(deletarEvento);
        }

        [HttpPut]
        public async Task<ActionResult<EventoDto>> UpdateEvento([FromServices] IEventoService _eventoService, UpdateEventoDto evento)
        {
            var eventoAtualizado = await _eventoService.UpdateEvento(evento);
            if (eventoAtualizado == null) BadRequest("Erro ao atualizar evento");
            return Ok(eventoAtualizado);
        }
    }
}
