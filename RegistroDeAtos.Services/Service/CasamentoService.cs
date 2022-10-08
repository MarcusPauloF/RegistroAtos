using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.Service
{
    public class CasamentoService : BaseService<Casamento>
    {
        private readonly ICasamentoRepository _casamentoRepository;

        public CasamentoService(ICasamentoRepository casamentoRepository) : base(casamentoRepository)
        {
            _casamentoRepository = casamentoRepository;
        }
    }
}
