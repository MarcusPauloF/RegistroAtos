using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public class Nascimento : BaseEntity
    {
        public Guid PaiId { get; set; }
        public Guid MaeId { get; set; }
        public Guid DocPaiId { get; set; }
        public Guid DocMaeId { get; set; }
        public Guid RecemNascidoId { get; set; }

        public virtual PessoaFisica Pai { get; set; }
        public virtual PessoaFisica Mae { get; set; }
        public Documento DocPai { get; set; }
        public Documento DocMae { get; set; }
        public virtual PessoaFisica RecemNascido { get; set; }
       

    }



}
