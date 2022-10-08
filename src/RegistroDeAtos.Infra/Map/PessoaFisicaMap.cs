using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegistroAtos.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Infra.Map
{
    public class PessoaFisicaMap: BaseMap<PessoaFisica>
    {
        public override void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.ToTable(nameof(PessoaFisica));

            base.Configure(builder);


            builder.Property(t=>t.TipoPessoa);
            builder.Property(t => t.Data);
            builder.Property(t => t.Nome).HasMaxLength(255);

            

        }
    }
}
