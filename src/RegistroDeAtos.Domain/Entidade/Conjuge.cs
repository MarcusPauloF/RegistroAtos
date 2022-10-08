using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public class Conjuge : Registro
    {
        public Guid PaiId { get; set; }
        public Guid MaeId { get; set; }
        public Guid DocPaiId { get; set; }
        public Guid DocMaeId { get; set; }
        public Guid DocumentoId { get; set; }

        public PessoaFisica Pai { get; set; }
        public PessoaFisica Mae { get; set; }
        public Documento DocPai { get; set; }
        public Documento DocMae { get; set; }
        public Documento Documento { get; set; }

        public virtual ICollection<Casamento> CasamentosConjugesUm { get; set; } = new HashSet<Casamento>();
        public virtual ICollection<Casamento> CasamentosConjugesDois { get; set; } = new HashSet<Casamento>();

    }
}
