using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Repository
{
    public interface IDataRepository<TEntity>
    {
        Task<TEntity> Get(int id);
        Task<bool> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);

        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetLastId();
        Task<bool> CheckIfExists(TEntity entity);

    }
}
