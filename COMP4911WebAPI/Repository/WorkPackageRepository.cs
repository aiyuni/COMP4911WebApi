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
            try
            {
                _workPackageContext.WorkPackages.Add(entity);
                await _workPackageContext.SaveChangesAsync();
                _workPackageContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to add Work Package: " + e.ToString());
            }
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

            //workPackages = await _workPackageContext.WorkPackages.ToListAsync();
            
            //return await _workPackageContext.WorkPackages.ToListAsync();

            List<WorkPackage> workPackages = new List<WorkPackage>();
            foreach (WorkPackage item in await _workPackageContext.WorkPackages.ToListAsync())
            {
                item.ChildrenWorkPackages = null;
                workPackages.Add(item);
            }
            return workPackages;

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
