using System;
using System.Collections.Generic;
using ProEventos.Domain.Validator;

namespace ProEventos.Domain.Entities
{
    public class Evento : BaseEntity
    {
        protected Evento() { }
        public Evento(string local, DateTime? dataEvento, string tema, int qtdPessoas, string imagemURL, string telefone, string email)
        {
            Local = local;
            DataEvento = dataEvento;
            Tema = tema;
            QtdPessoas = qtdPessoas;
            ImagemURL = imagemURL;
            Telefone = telefone;
            Email = email;
            Lotes = new();
            //RedeSociais = new();
            //PalestrantesEventos = new();
            CreateAt = DateTime.UtcNow;
            _erros = new();
            Validate();
        }

        public string Local { get; private set; }
        public DateTime? DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int QtdPessoas { get; private set; }
        public string ImagemURL { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public List<Lote> Lotes { get; private set; }
        public List<RedeSocial> RedeSociais { get; private set; }
        public List<Palestrante_Evento> PalestrantesEventos { get; private set; }
        public bool Validate() => Validate(new EventoValidate(), this);
    }
}
