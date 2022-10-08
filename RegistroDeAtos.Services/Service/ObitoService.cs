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
    public class ObitoService : BaseService<Obito>
    {
        private readonly IObitoRepository _obitoRepository;

        public ObitoService(IObitoRepository obitoRepository) : base(obitoRepository)
        {
            _obitoRepository = obitoRepository;
        }
    }
}
