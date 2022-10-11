using MediatR;
using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.CasamentoService.Commands.Input;

namespace RegistroDeAtos.Services.CasamentoService.Event
{
    public class CadastrarCasamentoHandler :
        IRequestHandler<CasamentoCommand,bool>
    {
        public readonly ICasamentoRepository _casamentoRepository;
        public CadastrarCasamentoHandler(ICasamentoRepository casamentoRepository)
        {
            _casamentoRepository = casamentoRepository;
        }

        public async Task<bool> Handle(CasamentoCommand request, CancellationToken cancellationToken)
        {
            Casamento casamento = new Casamento();
            casamento.ConjUm = new Conjuge();
            casamento.ConjUm.Nome = request.ConjUm.Nome;
            casamento.ConjUm.Data = request.ConjUm.DataNascimento;
            casamento.ConjUm.Documento = new Documento();
            casamento.ConjUm.Documento.Cpf = request.ConjUm.Documento.Cpf;
            casamento.ConjUm.DataRegistro = DateTime.UtcNow;
            casamento.ConjUm.Mae = new PessoaFisica();
            casamento.ConjUm.Mae.Nome = request.ConjUm.Mae.Nome;
            casamento.ConjUm.Mae.Data = request.ConjUm.Mae.Data;
            casamento.ConjUm.Mae.TipoPessoa = EnumTipoPessoa.Mae;
            casamento.ConjUm.Pai = new PessoaFisica();
            casamento.ConjUm.Pai.Nome = request.ConjUm.Pai.Nome;
            casamento.ConjUm.Pai.TipoPessoa = EnumTipoPessoa.Pai;
            casamento.ConjUm.Pai.Data = request.ConjUm.Pai.Data;
            casamento.ConjUm.DocMae = new Documento();
            casamento.ConjUm.DocMae.Cpf = request.ConjUm.DocMae.Cpf;
            casamento.ConjUm.DocPai = new Documento();
            casamento.ConjUm.DocPai.Cpf = request.ConjUm.DocPai.Cpf;

            casamento.ConjDois = new Conjuge();
            casamento.ConjDois.Nome = request.ConjDois.Nome;
            casamento.ConjDois.Data = request.ConjDois.DataNascimento;
            casamento.ConjDois.Documento = new Documento();
            casamento.ConjDois.Documento.Cpf = request.ConjDois.Documento.Cpf;
            casamento.ConjDois.DataRegistro = DateTime.UtcNow;
            casamento.ConjDois.Mae = new PessoaFisica();
            casamento.ConjDois.Mae.Nome = request.ConjDois.Mae.Nome;
            casamento.ConjDois.Mae.Data = request.ConjDois.Mae.Data;
            casamento.ConjDois.Pai = new PessoaFisica();
            casamento.ConjDois.Pai.Nome = request.ConjDois.Pai.Nome;
            casamento.ConjDois.Pai.Data = request.ConjDois.Pai.Data;
            casamento.ConjDois.DocMae = new Documento();
            casamento.ConjDois.DocMae.Cpf = request.ConjDois.DocMae.Cpf;
            casamento.ConjDois.DocPai = new Documento();
            casamento.ConjDois.DocPai.Cpf = request.ConjDois.DocPai.Cpf;

            await _casamentoRepository.Create(casamento);
            bool cadastrado = await _casamentoRepository.Commit();
            return cadastrado;
        }

    }
}