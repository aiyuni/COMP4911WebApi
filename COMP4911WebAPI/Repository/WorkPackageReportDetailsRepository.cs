using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class WorkPackageReportDetailsRepository : IDataRepository<WorkPackageReportDetails>
    {
        private readonly ApplicationDbContext _workPackageReportDetailsContext;

        public WorkPackageReportDetailsRepository(ApplicationDbContext context)
        {
            _workPackageReportDetailsContext = context;
        }

        public async Task<bool> Add(WorkPackageReportDetails entity)
        {
            try
            {
                await _workPackageReportDetailsContext.AddAsync(entity);
                await _workPackageReportDetailsContext.SaveChangesAsync();
                _workPackageReportDetailsContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            {
                //throw new Exception("Failed to add work package details: " + e.ToString());
                return true;
            }
        }

        public async Task<WorkPackageReportDetails> Get(int id)
        {
            return await _workPackageReportDetailsContext.WorkPackageReportDetails.FindAsync(id);
        }

        public async Task<IEnumerable<WorkPackageReportDetails>> GetAll()
        {
            return await _workPackageReportDetailsContext.WorkPackageReportDetails.ToListAsync();
        }

        public Task<WorkPackageReportDetails> GetLastId()
        {
            throw new NotImplementedException();
        }

        //Need to check this -- do we need this feature?
        public async Task Update(WorkPackageReportDetails entity)
        {
            WorkPackageReportDetails dbEntity = await _workPackageReportDetailsContext.WorkPackageReportDetails.FindAsync(entity.WorkPackageReportDetailsId);
            _workPackageReportDetailsContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _workPackageReportDetailsContext.SaveChangesAsync();
            Debug.WriteLine("updated work package report...");
        }

        public Task<bool> CheckIfExists(WorkPackageReportDetails entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(WorkPackageReportDetails entity)
        {
            throw new NotImplementedException();
        }

    }
}
