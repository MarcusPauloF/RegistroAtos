using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.ObitoService.Commands.Output
{
    public class QueryObito
    {
        public Guid Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataObito { get; set; }

        public string NomeDoFalecido { get; set; }
        public string NomeDoPai { get; set; }
        public string NomeDaMae { get; set; }
        public DateTime DataNascimentoPai { get; set; }
        public DateTime DataNascimentoMae { get; set; }
    }
}
