using System;

namespace ProEventos.Services.Dtos.Eventos
{
    public class CreateEventoDto
    {
        public string Local { get; set; }
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        //public int UserId { get; set; }
        //public UserDto UserDto { get; set; }

        //public IEnumerable<LoteDto> Lotes { get; set; }
        //public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        //public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}
