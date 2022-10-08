using MediatR;
using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.CasamentoService.Commands.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.NascimentoService.Commands.Event
{
    public class CadastrarNascimentoHandler : IRequestHandler<NascimentoCommand, bool>
    {
        public readonly INascimentoRepository _nascimentoRepository;
        public CadastrarNascimentoHandler(INascimentoRepository nascimentoRepository)
        {
            _nascimentoRepository = nascimentoRepository;
        }

        public async Task<bool> Handle(NascimentoCommand request, CancellationToken cancellationToken)
        {
            Nascimento nascimento = new Nascimento();
            nascimento.DataRegistro = request.DataRegistro;
            nascimento.DocMae = new Documento();
           // nascimento.DocMae.Cpf = request.Documento.Cpf;

            return true;
        }
    }
}
