using Microsoft.EntityFrameworkCore;
using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroAtos.Infra.DataBase;
using RegistroDeAtos.Services.ObitoService.Commands.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Infra.Repositorio
{
    public class ObitoRepository : BaseRepository<Obito>, IObitoRepository
    {
        public ObitoRepository(Context db) : base(db)
        {
            
        }

       public async Task<List<Obito>> ObterTodos() => await _db.Obitos
            .Include(t => t.Pai.Nome)
            .Include(t => t.Mae.Nome)
            .Include(t => t.Falecido.Nome)
            .Include(t => t.Falecido.Data)
            .Include(t => t.DataObito)

            .ToListAsync();
    }
}
