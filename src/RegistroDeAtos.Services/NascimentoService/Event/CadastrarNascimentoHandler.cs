using MediatR;
using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.CasamentoService.Commands.Input;
using RegistroDeAtos.Services.Comum;
using RegistroDeAtos.Services.NascimentoService.Commands.Input;
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
            nascimento.RecemNascido.Data = request.RecemNascido.Data;
            nascimento.RecemNascido.Nome = request.RecemNascido.Nome;
            nascimento.Pai.Nome = request.Pai.Nome;
            nascimento.Mae.Nome = request.Mae.Nome;
            nascimento.Pai.Data = request.Pai.Data;
            nascimento.Mae.Data = request.Mae.Data;
            nascimento.DocPai.Cpf = request.DocPai.Cpf;
            nascimento.DocMae.Cpf = request.DocMae.Cpf;

            await _nascimentoRepository.Create(nascimento);
            bool cadastrado = await _nascimentoRepository.Commit();
            return cadastrado;

            
        }
    }
}
