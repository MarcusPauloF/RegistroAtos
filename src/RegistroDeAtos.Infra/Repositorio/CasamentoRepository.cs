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
    public class CasamentoRepository : BaseRepository<Casamento>, ICasamentoRepository
    {
        public CasamentoRepository(Context db) : base(db)
        {
        }
        public async Task<List<Casamento>> ObterTodos() => await _db.Casamentos
             .Include(t => t.ConjUm)
            .Include(t => t.ConjUm.Documento)
            .Include(t => t.ConjUm.Pai)
            .Include(t => t.ConjUm.Mae)
            .Include(t => t.ConjUm.DocPai)
            .Include(t => t.ConjUm.DocMae)
            .Include(t => t.ConjDois)
            .Include(t => t.ConjDois.Documento)
            .Include(t => t.ConjDois.Mae)
            .Include(t => t.ConjDois.Pai)
            .Include(t => t.ConjDois.DocPai)
            .Include(t => t.ConjDois.DocMae)

            .ToListAsync();
    }
}
