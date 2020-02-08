using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Repository
{
    /**All Repository classes will implement this interface */
    public interface IDataRepository<TEntity>
    {
        //Basic CRUD Methods
        Task<TEntity> Get(int id);
        Task<bool> Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);

        //Other important methods
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetLastId();
        Task<bool> CheckIfExists(TEntity entity);
    }
}
