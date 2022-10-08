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
    public class CasamentoMap : BaseMap<Casamento>
    {
        public override void Configure(EntityTypeBuilder<Casamento> builder)
        {
            builder.ToTable(nameof(Casamento));

            base.Configure(builder);

            builder.Property(t => t.DataRegistro).IsRequired();


            builder.HasOne(t => t.ConjDois).WithMany(t => t.CasamentosConjugesDois).HasForeignKey(t => t.ConjDoisId);
            builder.HasOne(t => t.ConjUm).WithMany(t => t.CasamentosConjugesUm).HasForeignKey(t => t.ConjUmId);
        }
    }
}
