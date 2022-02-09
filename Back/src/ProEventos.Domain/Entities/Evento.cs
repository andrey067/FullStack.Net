using System;
using System.Collections.Generic;

namespace ProEventos.Domain.Entities
{
    public class Evento : BaseEntity
    {
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedeSociais { get; set; }
        public IEnumerable<Palestrante_Evento> PalestrantesEventos { get; set; }
    }
}