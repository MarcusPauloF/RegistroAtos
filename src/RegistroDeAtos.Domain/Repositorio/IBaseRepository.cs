using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Repositorio
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
      Task<TEntity> Get(TEntity entity);
      Task<TEntity> Update(TEntity entity);
      Task<TEntity> Delete(int id);
      Task Create(TEntity entity);
        Task<bool> Commit();
    }
}
