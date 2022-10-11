using RegistroDeAtos.Services.CasamentoService.Commands.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.CasamentoService.Query
{
    public interface IConsultarCasamentoQuery
    {
        Task<List<QueryCasamento>> ObterTodos();
    }
}
