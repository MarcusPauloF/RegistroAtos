using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public class Casamento : BaseEntity
    {
        public DateTime DataCasamento { get; set; }
        public Guid ConjUmId { get; }
        public Guid ConjDoisId { get; }

        public virtual Conjuge ConjUm { get; set; }
        public virtual Conjuge ConjDois  { get; set; }

    } 
}
