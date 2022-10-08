using RegistroAtos.Domain.Entidade;
using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.Interface;

namespace RegistroDeAtos.Services
{   
        public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
        {
            private readonly IBaseRepository<TEntity> _baseRepository;

            public BaseService(IBaseRepository<TEntity> baseRepository)
            {
                _baseRepository = baseRepository;
            }

        public async Task<TEntity> Create(TEntity entity)
        {
            await _baseRepository.Create(entity);
            return entity;
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
    }
}