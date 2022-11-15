using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Interfaces;
using ProEventos.Services.Dtos;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("/eventos")]
    public class EventoController : BaseController
    {
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

        [HttpGet("/tema/{tema}")]
        public async Task<IActionResult> GetByTema([FromServices] IEventoService _eventoService, string tema)
        {
            var eventos = await _eventoService.GetAllEventosByTemaAsync(tema, true);
            if (eventos == null) return NoContent();

            return Ok(eventos);
        }

        [HttpPost]
        public async Task<IActionResult> InsertEvento([FromServices] IEventoService _eventoService, EventoDto evento)
        {
            var eventos = await _eventoService.AddEvento(evento);
            return Ok(eventos);

        }

        [HttpDelete("/{id}")]
        public async Task<IActionResult> DeletarEvento([FromServices] IEventoService _eventoService, int id)
        {
            var eventos = await _eventoService.DeleteEvento(id);
            return Ok("Deletado");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEvento([FromServices] IEventoService _eventoService, int eventoId, EventoDto evento)
        {
            var eventos = await _eventoService.DeleteEvento(eventoId);
            if (!eventos) BadRequest("Erro ao atualizar evento");

            return Ok(eventos);
        }
    }
}
