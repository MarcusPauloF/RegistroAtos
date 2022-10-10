using RegistroAtos.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.Interface
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> Get(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(int id);
        Task<TEntity> Create(TEntity entity);
    }
}
