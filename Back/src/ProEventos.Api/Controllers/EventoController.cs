using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        [HttpGet]
        [Route("/api/evento")]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState); //if modelstave not valide return BadRequest

            try
            {
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}