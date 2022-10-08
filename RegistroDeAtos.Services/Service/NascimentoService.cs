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
    public class NascimentoService : BaseService<Nascimento>
    {
        private readonly INascimentoRepository _nascimentoRepository;

       public NascimentoService(INascimentoRepository nascimentoRepository) : base(nascimentoRepository)
        {
            _nascimentoRepository = nascimentoRepository;
        }
    }
}
