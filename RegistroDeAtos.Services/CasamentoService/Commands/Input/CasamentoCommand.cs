using RegistroDeAtos.Core.Mensagens;
using RegistroDeAtos.Services.Comum;

namespace RegistroDeAtos.Services.CasamentoService.Commands.Input
{
    public class CasamentoCommand : Command
    {
        public DateTime DataCasamento { get; set; }

        public ConjugeCommand ConjUm { get; set; } = new ConjugeCommand();
        public ConjugeCommand ConjDois { get; set; } = new ConjugeCommand();

    }
}