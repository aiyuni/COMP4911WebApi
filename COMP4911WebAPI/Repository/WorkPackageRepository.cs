using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

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
            await _workPackageContext.SaveChangesAsync();
            _workPackageContext.Entry(entity).State = EntityState.Detached;
            return true;
        }

        public Task<bool> CheckIfExists(WorkPackage entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CheckIfWorkPackageCodeExists(string code, int projectId)
        {
            bool value = await _workPackageContext.WorkPackages.AnyAsync(
                wp => wp.ProjectId == projectId && wp.WorkPackageCode.Equals(code));
            return value;
        }

        public Task Delete(WorkPackage entity)
        {
            throw new NotImplementedException();
        }

        public async Task<WorkPackage> Get(int id)
        {
            return await _workPackageContext.WorkPackages.FindAsync(id);
        }


        public async Task<IEnumerable<WorkPackage>> GetAll()
        {
            return await _workPackageContext.WorkPackages.ToListAsync();
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
