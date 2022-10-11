using RegistroAtos.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Repositorio
{
    public interface ICasamentoRepository : IBaseRepository<Casamento>
    {
        Task<List<Casamento>> ObterTodos();
    }
}
