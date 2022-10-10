using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public class Obito : BaseEntity
    {
        public DateTime DataObito { get; set; } = DateTime.Now;

        public Guid FalecidoId { get; set; }
        public Guid PaiId { get; set; }
        public Guid MaeId { get; set; }

        public virtual PessoaFisica Falecido { get; set; }
        public virtual PessoaFisica Pai { get; set; }
        public virtual PessoaFisica Mae { get; set; }
    }
}
