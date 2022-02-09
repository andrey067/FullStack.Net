namespace ProEventos.Domain.Entities
{
    public class RedeSocial : BaseEntity
    {
        public string Nome { get; set; }
        public string URL { get; set; }
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}