using RegistroAtos.Domain.Entidade;
using RegistroDeAtos.Core.Mensagens;
using RegistroDeAtos.Services.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.NascimentoService.Commands.Input
{
    public class NascimentoCommand : Command
    {

        public DateTime DataRegistro { get; set; } = new DateTime();
        public PessoaFisicaCommand Pai { get; set; } = new PessoaFisicaCommand();
        public PessoaFisicaCommand Mae { get; set; } = new PessoaFisicaCommand();
        public PessoaFisicaCommand RecemNascido { get; set; } = new PessoaFisicaCommand();
        public DocumentoCommand DocPai { get; set; } = new DocumentoCommand();
        public DocumentoCommand DocMae { get; set; } = new DocumentoCommand();
    }
}
