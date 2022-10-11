using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.CasamentoService.Commands.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.CasamentoService.Query
{
    public class ConsultarCasamentoQuery : IConsultarCasamentoQuery
    {
        private readonly ICasamentoRepository _casamentoRepository;

        public ConsultarCasamentoQuery(ICasamentoRepository casamentoRepository)
        {
            _casamentoRepository = casamentoRepository;
        }

        public async Task<List<QueryCasamento>> ObterTodos()
        {
            var resultado =  await _casamentoRepository.ObterTodos();
            List<QueryCasamento> casamentos = new List<QueryCasamento>();
            resultado.ForEach(t =>
            {
                QueryCasamento casamento = new QueryCasamento();
                casamento.CpfConjugeDois = t.ConjDois.Documento.Cpf;
                casamento.CpfConjugeUm = t.ConjUm.Documento.Cpf;
                casamento.DataNascimentoConjugeDois = t.ConjDois.Data;
                casamento.DataNascimentoConjugeUm = t.ConjUm.Data;
                casamento.DataRegistro = t.DataRegistro;
                casamento.Id = t.Id;
                casamento.NomeConjugeDois = t.ConjDois.Nome;
                casamento.NomeConjugeUm = t.ConjUm.Nome;
                casamento.NomeMaeConjugeUm = t.ConjUm.Mae.Nome;
                casamento.NomePaiConjugeUm = t.ConjUm.Pai.Nome;
                      
                casamento.NomePaiConjugeDois = t.ConjDois.Pai.Nome;
                casamento.NomeMaeConjugeDois = t.ConjDois.Mae.Nome;

                casamentos.Add(casamento);
            });
            return casamentos;
        }
    }
}
