using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.Repository
{
    public class WorkPackageRepository : IDataRepository<WorkPackage>
    {
        private readonly ApplicationDbContext _workPackageContext;

        public WorkPackageRepository(ApplicationDbContext context)
        {
            this._workPackageContext = context;
        }

        public async Task<bool> Add(WorkPackage entity)
        {
            _workPackageContext.WorkPackages.Add(entity);
            return true;
        }

        public Task<bool> CheckIfExists(WorkPackage entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(WorkPackage entity)
        {
            throw new NotImplementedException();
        }

        public Task<WorkPackage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WorkPackage> Get(int wpId, int projId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkPackage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<WorkPackage> GetLastId()
        {
            throw new NotImplementedException();
        }

        public Task Update(WorkPackage entity)
        {
            throw new NotImplementedException();
        }
    }
}
