using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.ObitoService.Commands.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.ObitoService.Query
{
    public class ConsultarObitoQuery : IConsultarObitoQuery
    {
        private readonly IObitoRepository _obitoRepository;


        public ConsultarObitoQuery(IObitoRepository obitoRepository)
        {
            _obitoRepository = obitoRepository;
        }


        public async Task<List<QueryObito>> ObterTodos()
        {
            var resultado = await _obitoRepository.ObterTodos();
            List<QueryObito> obitos = new List<QueryObito>();
            resultado.ForEach(t =>
            {
                QueryObito obito = new QueryObito();
                obito.DataNascimentoPai = t.Pai.Data;
                obito.DataNascimentoMae = t.Mae.Data;
                obito.DataNascimento = t.Falecido.Data;
                obito.DataObito= t.DataObito;
                obito.DataRegistro = t.DataRegistro;
                obito.Id = t.Id;
                obito.NomeDoFalecido = t.Falecido.Nome;
                obito.NomeDoPai = t.Pai.Nome;
                obito.NomeDaMae = t.Mae.Nome;

                obitos.Add(obito);
            });
            return obitos;
        }
    }
}
