using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.NascimentoService.Commands.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.NascimentoService.Query
{
    public class ConsultarNascimentoQuery : IConsultarNascimentoQuery
    {
        private readonly INascimentoRepository _nascimentoRepository;

        public ConsultarNascimentoQuery(INascimentoRepository nascimentoRepository)
        {
            _nascimentoRepository = nascimentoRepository;
        }

        public async Task<List<QueryNascimento>> ObterTodos()
        {
            var resultado = await _nascimentoRepository.ObterTodos();
            List<QueryNascimento> nascimentos = new List<QueryNascimento>();
            resultado.ForEach(t =>
            {
                QueryNascimento nascimento = new QueryNascimento();
                nascimento.CpfDoPai = t.DocPai.Cpf;
                nascimento.CpfDaMae = t.DocMae.Cpf;
                nascimento.DataNascimento = t.RecemNascido.Data;
                nascimento.DataRegistro = t.DataRegistro;
                nascimento.Id = t.Id;
                nascimento.NomeDoPai = t.Pai.Nome;
                nascimento.NomeDaMae = t.Mae.Nome;
                nascimento.NomeDoRegistrado = t.RecemNascido.Nome;

                nascimentos.Add(nascimento);
            });
            return nascimentos;
        }
    }
}
