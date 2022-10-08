using RegistroDeAtos.Core.Mensagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.NascimentoService.Commands
{
    public class NascimentoCommand : Command
    {
        public DateTime DataNascimento { get; set; } = new DateTime();
        public DateTime DataRegistro { get; set; } = new DateTime();

        public string NomeDoRegistrado { get; set; }
        public string NomeDoPai { get; set; }
        public string NomeDaMae { get; set; }
        public DateTime DataNascimentoPai { get; set; } = new DateTime();
        public DateTime DataNascimentoMae { get; set; } = new DateTime();
        public String CpfDoPai { get; set; }
        public string CpfDaMae { get; set; }

    }
}
