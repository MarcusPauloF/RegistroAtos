using Microsoft.EntityFrameworkCore;
using RegistroAtos.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Infra.DataBase
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<PessoaFisica> PessoasFisicas{ get;  set; }
        public DbSet<Conjuge> Conjuges { get; set; }
        public DbSet<Casamento> Casamentos { get; set; }
        public DbSet<Nascimento>  Nascimentos { get; set; }
        public DbSet<Obito> Obitos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseNpgsql("Server=localhost;Database=RegistroDeAto;Port=5432;User Id=postgres;Password=sa-1234;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            var stringProperties = modelBuilder.Model.GetEntityTypes()
                .SelectMany(_ => _.GetProperties())
                .Where(_ => _.ClrType == typeof(string) && _.GetColumnType() == null);

            foreach (var item in stringProperties)
            {
                item.SetIsUnicode(false);
                if (item.GetMaxLength() == null)
                    item.SetMaxLength(256);
            }

            var decimalProperties = modelBuilder.Model.GetEntityTypes()
                .SelectMany(_ => _.GetProperties())
                .Where(_ => (_.ClrType == typeof(decimal) || _.ClrType == typeof(decimal?)) && _.GetColumnType() == null);

            foreach (var item in decimalProperties)
            {
                if (item.GetPrecision() == null && item.GetScale() == null)
                {
                    item.SetPrecision(18);
                    item.SetScale(4);
                }
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
