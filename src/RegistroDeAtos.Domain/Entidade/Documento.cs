using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public class Documento : BaseEntity
    {
        public string Cpf { get; set; }
        public virtual Nascimento NascimentoPai { get; set; }
        public virtual Nascimento NascimentoMae { get; set; }

        public virtual Conjuge ConjugePai { get; set; } 
        public virtual Conjuge ConjugeMae { get; set; } 
        public virtual Conjuge Conjuge { get; set; } 

    }
}
