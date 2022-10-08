using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public abstract class Registro : BaseEntity
    {
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public EnumTipoPessoa TipoPessoa { get; set; }

    }
}
