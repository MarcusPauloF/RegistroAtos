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
    public class ObitoMap : BaseMap<Obito>
    {
        public override void Configure(EntityTypeBuilder<Obito> builder)
        {
            builder.ToTable(nameof(Obito));

            base.Configure(builder);

 
            builder.Property(t => t.DataObito);

            builder.HasOne(t => t.Falecido).WithOne(t => t.ObitoFalecido).HasForeignKey<Obito>(t => t.FalecidoId);
            builder.HasOne(t => t.Pai).WithMany(t => t.ObitoPai).HasForeignKey(t => t.PaiId);
            builder.HasOne(t => t.Mae).WithMany(t => t.ObitoMae).HasForeignKey(t => t.MaeId);

        }
    }
}
