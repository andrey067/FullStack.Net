using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoService _eventoService;

        public EventoController(IEventoService eventoService)
        {
            _eventoService = eventoService;
        }

        [HttpGet]
        [Route("/api/evento")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var eventos = await _eventoService.GetAllEventosAsync(true);
                if (eventos == null) return NotFound("Nenhum evento encontrado");

                return Ok(eventos);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]        
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                var eventos = await _eventoService.GetAllEventosByIdAsync(Id, true);
                if (eventos == null) return NotFound("Nenhum evento encontrado");

                return Ok(eventos);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("{tema}")]
        public async Task<IActionResult> GetByTema(string tema)
        {
            try
            {
                var eventos = await _eventoService.GetAllEventosByTemaAsync(tema, true);
                if (eventos == null) return NotFound("Nenhum evento encontrado");

                return Ok(eventos);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertEvento(int eventoId, Evento evento)
        {
            try
            {
                var eventos = await _eventoService.UpdateEvento(eventoId, evento);
                if (eventos == null) BadRequest("Erro ao inserir evento");

                return Ok(eventos);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPut]
        public async Task<IActionResult> DeletarEvento(Evento evento)
        {
            try
            {
                var eventos = await _eventoService.AddEvento(evento);
                if (eventos == null) BadRequest("Erro ao deletar evento");
                return Ok("Deletado");
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> UpdateEvento(int eventoId)
        {
            try
            {
                var eventos = await _eventoService.DeleteEvento(eventoId);
                if (!eventos) BadRequest("Erro ao atualizar evento");

                return Ok(eventos);
            }
            catch (Exception ex)
            {
                return this.StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}