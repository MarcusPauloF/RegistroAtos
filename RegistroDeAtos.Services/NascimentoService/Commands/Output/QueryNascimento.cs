using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.NascimentoService.Commands.Output
{
    public class QueryNascimento
    {
        public Guid Id { get; set; }
        public DateTime DataNascimento { get; set; } 
        public DateTime DataRegistro { get; set; }

        public string NomeDoRegistrado { get; set; }
        public string NomeDoPai { get; set; }
        public string NomeDaMae { get; set; }
        public string CpfDoPai { get; set; }
        public string CpfDaMae { get; set; }
    }
}
