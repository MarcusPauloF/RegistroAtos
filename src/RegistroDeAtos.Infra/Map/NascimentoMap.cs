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
    public class NascimentoMap : BaseMap<Nascimento>
    {
        public override void Configure(EntityTypeBuilder<Nascimento> builder)
        {
            builder.ToTable(nameof(Nascimento));

            base.Configure(builder);
           

            builder.HasOne(t => t.Pai).WithMany(t => t.NascimentoPai).HasForeignKey(t => t.PaiId);
            builder.HasOne(t => t.Mae).WithMany(t => t.NascimentoMae).HasForeignKey(t => t.MaeId);
            builder.HasOne(t => t.RecemNascido).WithOne(t => t.NascimentoRecemNascido).HasForeignKey<Nascimento>(t => t.RecemNascidoId);
            builder.HasOne(t => t.DocPai).WithOne(t => t.NascimentoPai).HasForeignKey<Nascimento>(t => t.DocPaiId);
            builder.HasOne(t => t.DocMae).WithOne(t => t.NascimentoMae).HasForeignKey<Nascimento>(t => t.DocMaeId);




        }
    }
}
