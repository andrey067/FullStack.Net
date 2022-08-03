using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProEventos.Domain.Entities
{
    public class Lote : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataIncio { get; set; }
        public DateTime DataFim { get; set; }
        public int Quantidade { get; set; }               
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}