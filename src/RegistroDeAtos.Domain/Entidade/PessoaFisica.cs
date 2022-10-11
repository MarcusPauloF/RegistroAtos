using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public class PessoaFisica : Registro
    {

        public virtual ICollection<Obito> ObitoPai { get; set; } = new HashSet<Obito>();
        public virtual ICollection<Obito> ObitoMae { get; set; } = new HashSet<Obito>();
        public virtual Obito ObitoFalecido { get; set; } 

        public virtual ICollection<Nascimento> NascimentoPai { get; set; } = new HashSet<Nascimento>();
        public virtual ICollection<Nascimento> NascimentoMae { get; set; } = new HashSet<Nascimento>();
        public virtual Nascimento NascimentoRecemNascido { get; set; } 

        public virtual ICollection<Conjuge> ConjugePai { get; set; } = new HashSet<Conjuge>();
        public virtual ICollection<Conjuge> ConjugeMae { get; set; } = new HashSet<Conjuge>();


    }
}
