using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            return await _workPackageContext.WorkPackages.ToListAsync();
        }

        public int GetIdByCode(string code)
        {
            try
            {
                return _workPackageContext.WorkPackages.First(wp => wp.WorkPackageCode.Equals(code))
                    .WorkPackageId;
            }
            catch (Exception e)
            {
                throw new Exception("The code: " + code + " cannot be converted to ID: " + e.ToString());
            }
        }

        public Task<WorkPackage> GetLastId()
        {
            throw new NotImplementedException();
        }

        public async Task Update(WorkPackage entity)
        {
            WorkPackage dbEntity = await _workPackageContext.WorkPackages.FindAsync(entity.WorkPackageId);
            _workPackageContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _workPackageContext.SaveChangesAsync();
            Debug.WriteLine("Updated Work Package...");
        }
    }
}
