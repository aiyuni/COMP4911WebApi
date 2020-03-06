using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class WorkPackageReportRepository : IDataRepository<WorkPackageReport>
    {
        public readonly ApplicationDbContext _workPackageReportContext;

        public WorkPackageReportRepository(ApplicationDbContext workPackageReportContext)
        {
            this._workPackageReportContext = workPackageReportContext;
        }

        public async Task<bool> Add(WorkPackageReport entity)
        {
            try
            {
                _workPackageReportContext.Add(entity); //create a viewmodel for WorkPackageReport without details...
                await _workPackageReportContext.SaveChangesAsync();
                _workPackageReportContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            {
               // return true;
                throw new Exception("Failed to add Work Package Report: " + e.ToString());
            }
        }

        public async Task<WorkPackageReport> Get(int id)
        {
            return await _workPackageReportContext.WorkPackageReports.FindAsync(id);
        }

        public async Task<IEnumerable<WorkPackageReport>> GetAll()
        {
            return await _workPackageReportContext.WorkPackageReports.ToListAsync();
        }

        public Task<WorkPackageReport> GetLastId()
        {
            throw new NotImplementedException();
        }
        
        //Need to check this -- do we even need this feature?
        public async Task Update(WorkPackageReport entity)
        {
            WorkPackageReport dbEntity = await _workPackageReportContext.WorkPackageReports.FindAsync(entity.WorkPackageReportId);
            _workPackageReportContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _workPackageReportContext.SaveChangesAsync();
            Debug.WriteLine("updated work package report...");
        }

        public Task<bool> CheckIfExists(WorkPackageReport entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(WorkPackageReport entity)
        {
            throw new NotImplementedException("we dont want to delete reports");
        }

    }
}
