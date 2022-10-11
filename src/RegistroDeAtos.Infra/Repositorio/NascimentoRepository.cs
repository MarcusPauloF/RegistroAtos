using Microsoft.EntityFrameworkCore;
using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroAtos.Infra.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Infra.Repositorio
{
    public class NascimentoRepository : BaseRepository<Nascimento>, INascimentoRepository
    {
        public NascimentoRepository(Context db) : base(db)
        {
        }

        public async Task<List<Nascimento>> ObterTodos() => await _db.Nascimentos
            .Include(t => t.RecemNascido)
            .Include(t => t.Pai)
            .Include(t => t.Mae)
            .Include(t => t.DocPai)
            .Include(t => t.DocMae)

            .ToListAsync();
    }
}
