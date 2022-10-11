using RegistroAtos.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Repositorio
{
    public interface INascimentoRepository : IBaseRepository<Nascimento>
    {
        Task<List<Nascimento>> ObterTodos();
    }
}
