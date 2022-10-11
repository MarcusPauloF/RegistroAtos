using RegistroDeAtos.Services.ObitoService.Commands.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.ObitoService.Query
{
    public interface IConsultarObitoQuery
    {
        Task<List<QueryObito>> ObterTodos();
    }
}
