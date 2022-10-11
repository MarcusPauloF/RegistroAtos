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
                QueryCasamento casameto = new QueryCasamento();
                casameto.CpfConjugeDois = t.ConjDois.Documento.Cpf;
                casameto.CpfConjugeUm = t.ConjUm.Documento.Cpf;
                casameto.DataNascimentoConjugeDois = t.ConjDois.Data;
                casameto.DataNascimentoConjugeUm = t.ConjUm.Data;
                casameto.DataRegistro = t.DataRegistro;
                casameto.Id = t.Id;
                casameto.NomeConjugeDois = t.ConjDois.Nome;
                casameto.NomeConjugeUm = t.ConjUm.Nome;
                casameto.NomeMaeConjugeUm = t.ConjUm.Mae.Nome;
                casameto.NomePaiConjugeUm = t.ConjUm.Pai.Nome;

                casameto.NomePaiConjugeDois = t.ConjDois.Pai.Nome;
                casameto.NomeMaeConjugeDois = t.ConjDois.Mae.Nome;

                casamentos.Add(casameto);
            });
            return casamentos;
        }
    }
}
