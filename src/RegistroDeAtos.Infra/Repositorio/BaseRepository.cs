using Microsoft.EntityFrameworkCore;
using RegistroAtos.Domain.Repositorio;
using RegistroAtos.Infra.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Infra.Repositorio
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private Context _db;

        public BaseRepository(Context db)
        {
            this._db = db;
        }

        public Task<TEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task Create(TEntity entity)
        {
            await _db.AddAsync(entity);
        }
        public async Task<bool> Commit()
        {
            return await _db.SaveChangesAsync() > 0;
        }
    }
}
