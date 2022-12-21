using System.ComponentModel;

namespace ProEventos.Core.Notifications.Enums
{
    public enum TipoDeNotificacao
    {
        [Description("Erro de Dominio")]
        ErroDeDominio,
        [Description("Erro de Serviço")]
        ErroDeServico
    }
}
