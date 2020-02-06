using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class TimesheetRowRepository : IDataRepository<TimesheetRow>
    {
        private readonly ApplicationDbContext _timesheetRowContext;

        public TimesheetRowRepository(ApplicationDbContext context)
        {
            this._timesheetRowContext = context;
        }

        public async Task<bool> Add(TimesheetRow entity)
        {
            await _timesheetRowContext.AddAsync(entity);
            await _timesheetRowContext.SaveChangesAsync();
            return true;
        }

        public Task<bool> CheckIfExists(TimesheetRow entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(TimesheetRow entity)
        {
            throw new NotImplementedException();
        }

        public async Task<TimesheetRow> Get(int id)
        {
            return await _timesheetRowContext.TimesheetRows.FindAsync(id);
        }

        public async Task<IEnumerable<TimesheetRow>> GetAll()
        {
            return await _timesheetRowContext.TimesheetRows.ToListAsync();
        }

        public Task<TimesheetRow> GetLastId()
        {
            throw new NotImplementedException();
        }

        public Task Update(TimesheetRow entity)
        {
            throw new NotImplementedException();
        }
    }
}
