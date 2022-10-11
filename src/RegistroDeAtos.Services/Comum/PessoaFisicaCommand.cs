using RegistroAtos.Domain.Entidade;

namespace RegistroDeAtos.Services.Comum
{
    public class PessoaFisicaCommand
    {
        public DateTime Data { get; set; } = DateTime.UtcNow;
        public string Nome { get; set; }
        public EnumTipoPessoa TipoPessoa { get; set; }
    }
}