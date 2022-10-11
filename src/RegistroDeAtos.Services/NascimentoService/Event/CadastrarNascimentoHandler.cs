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
            nascimento.RecemNascido = new PessoaFisica();
            nascimento.RecemNascido.Data = request.RecemNascido.Data;
            nascimento.RecemNascido.Nome = request.RecemNascido.Nome;
            nascimento.RecemNascido.TipoPessoa = EnumTipoPessoa.RecemNascido;
            nascimento.Pai = new PessoaFisica();
            nascimento.Pai.Nome = request.Pai.Nome;
            nascimento.Pai.Data = request.Pai.Data;
            nascimento.Pai.TipoPessoa = EnumTipoPessoa.Pai;
            nascimento.Mae = new PessoaFisica();
            nascimento.Mae.Nome = request.Mae.Nome;
            nascimento.Mae.Data = request.Mae.Data;
            nascimento.Mae.TipoPessoa = EnumTipoPessoa.Mae;
            nascimento.DocPai = new Documento();
            nascimento.DocPai.Cpf = request.DocPai.Cpf;
            nascimento.DocMae = new Documento();
            nascimento.DocMae.Cpf = request.DocMae.Cpf;

            await _nascimentoRepository.Create(nascimento);
            bool cadastrado = await _nascimentoRepository.Commit();
            return cadastrado;

            
        }
    }
}
