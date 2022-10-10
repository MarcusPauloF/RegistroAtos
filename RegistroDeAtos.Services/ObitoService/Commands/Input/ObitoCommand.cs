using RegistroDeAtos.Core.Mensagens;
using RegistroDeAtos.Services.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.ObitoService.Commands.Input
{
    public class ObitoCommand : Command
    {
        public DateTime DataRegistro { get; set; } = new DateTime();
        public DateTime DataObito { get; set; } = new DateTime();
        public PessoaFisicaCommand Pai { get; set; } = new PessoaFisicaCommand();
        public PessoaFisicaCommand Mae { get; set; } = new PessoaFisicaCommand();
        public PessoaFisicaCommand Falecido { get; set; } = new PessoaFisicaCommand();

    }
}
