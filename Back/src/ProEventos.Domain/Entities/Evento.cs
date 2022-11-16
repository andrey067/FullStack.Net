using System;
using System.Collections.Generic;
using ProEventos.Domain.Validator;

namespace ProEventos.Domain.Entities
{
    public class Evento : BaseEntity
    {
        public Evento() { }
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
            _erros = new();
            Validate();
        }

        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Lote> Lotes { get; set; }
        public List<RedeSocial> RedeSociais { get; set; }
        public List<Palestrante_Evento> PalestrantesEventos { get; set; }

        public bool Validate() => base.Validate(new EventoValidate(), this);
    }
}
