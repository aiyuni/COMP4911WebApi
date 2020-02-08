using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class TimesheetRepository : IDataRepository<Timesheet>
    {
        private readonly ApplicationDbContext _timesheetContext;

        public TimesheetRepository(ApplicationDbContext context)
        {
            this._timesheetContext = context;
        }

        public async Task<bool> Add(Timesheet entity)
        {
            Debug.Write("inside timesheet add...");
            bool exists = await _timesheetContext.Timesheets.
                AnyAsync(ts => ts.TimesheetId == entity.TimesheetId && ts.VersionNumber == entity.VersionNumber &&
                               ts.WeekEndingIn.Equals(entity.WeekEndingIn));
            if (!exists)
            {
                _timesheetContext.Timesheets.Add(entity);
                await _timesheetContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Task<bool> CheckIfExists(Timesheet entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Timesheet entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Timesheet> Get(int id)
        {
            return await _timesheetContext.Timesheets.OrderByDescending(x => x.VersionNumber)
                .Where(x => x.TimesheetId == id).FirstOrDefaultAsync();
    
        }

        public async Task<Timesheet> Get(int id, int versionId)
        {
            return await _timesheetContext.Timesheets.FindAsync(id, versionId);
        }

        public async Task<IEnumerable<Timesheet>> GetAll()
        {
            return await _timesheetContext.Timesheets.ToListAsync();
        }

        public async Task<Timesheet> GetLastId()
        {
            return await _timesheetContext.Timesheets.OrderBy(t => t.TimesheetId).LastOrDefaultAsync();
        }

        public async Task Update(Timesheet entity)
        {
            Timesheet dbEntity = await _timesheetContext.Timesheets.FindAsync(entity.TimesheetId, entity.VersionNumber);
            _timesheetContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _timesheetContext.SaveChangesAsync();
            Debug.Write("updated timesheet...");
        }
    }
}
