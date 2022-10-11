using RegistroDeAtos.Services.NascimentoService.Commands.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.NascimentoService.Query
{
    public interface IConsultarNascimentoQuery
    {
        Task<List<QueryNascimento>> ObterTodos();
    }
}
