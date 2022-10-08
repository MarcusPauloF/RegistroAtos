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
    public class ConjugeMap : BaseMap<Conjuge>
    {
        public override void Configure(EntityTypeBuilder<Conjuge> builder)
        {
            builder.ToTable(nameof(Conjuge));

            base.Configure(builder);


            builder.Property(t => t.TipoPessoa);
            builder.Property(t => t.Data);
            builder.Property(t => t.Nome).HasMaxLength(255);


            builder.HasOne(t => t.Mae).WithMany(t => t.ConjugeMae).HasForeignKey(t => t.MaeId);
            builder.HasOne(t => t.Pai).WithMany(t => t.ConjugePai).HasForeignKey(t => t.PaiId);

            builder.HasOne(t => t.DocMae).WithOne(t => t.ConjugeMae).HasForeignKey<Conjuge>(t => t.DocMaeId);
            builder.HasOne(t => t.DocPai).WithOne(t => t.ConjugePai).HasForeignKey<Conjuge>(t => t.DocPaiId);

            builder.HasOne(t => t.Documento).WithOne(t => t.Conjuge).HasForeignKey<Conjuge>(t => t.DocumentoId);
        }
    }
}
