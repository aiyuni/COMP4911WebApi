using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class WorkPackageReportSnapshotRepository : IDataRepository<WorkPackageReportSnapshot>
    {

        private readonly ApplicationDbContext _workPackageReportSnapshotContext;

        //Constructor
        public WorkPackageReportSnapshotRepository(ApplicationDbContext context)
        {
            this._workPackageReportSnapshotContext = context;
        }   
        //Add to database
        public async Task<bool> Add(WorkPackageReportSnapshot entity)
        {
            try
            {
                _workPackageReportSnapshotContext.WorkPackageReportSnapshot.Add(entity);
                await _workPackageReportSnapshotContext.SaveChangesAsync();
                _workPackageReportSnapshotContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to add Work Package Snapshot: " + e.ToString());
            }
        }

        //Check if Exists in database
        public async Task<bool> CheckIfExists(WorkPackageReportSnapshot entity)
        {
            return (await _workPackageReportSnapshotContext.WorkPackageReportSnapshot
            .FindAsync(entity.WorkPackageReportSnapshotId) != null);
        }

        //Delete from database not implemented since there is no deletion of this
        public Task Delete(WorkPackageReportSnapshot entity)
        {
            throw new System.NotImplementedException();
        }

        //Retrieve from database based on id
        public async Task<WorkPackageReportSnapshot> Get(int id)
        {
            return await _workPackageReportSnapshotContext.WorkPackageReportSnapshot.FindAsync(id);
        }

        //Retrieve all from database
        public async Task<IEnumerable<WorkPackageReportSnapshot>> GetAll()
        {
            return await _workPackageReportSnapshotContext.WorkPackageReportSnapshot.ToListAsync();
        }

        //Get from database based on the last id
        public async Task<WorkPackageReportSnapshot> GetLastId()
        {
            return await _workPackageReportSnapshotContext.WorkPackageReportSnapshot
            .OrderBy(wprs => wprs.WorkPackageReportSnapshotId).LastOrDefaultAsync();
        }

        //Update database
        public async Task Update(WorkPackageReportSnapshot entity)
        {
            WorkPackageReportSnapshot dbEntity = await _workPackageReportSnapshotContext.WorkPackageReportSnapshot
            .FindAsync(entity.WorkPackageReportSnapshotId);
            _workPackageReportSnapshotContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _workPackageReportSnapshotContext.SaveChangesAsync();
            Debug.WriteLine("Updated Project Report...");
        }
    }
}