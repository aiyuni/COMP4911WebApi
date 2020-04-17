using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class EmployeeProjectAssignmentRepository : IDataRepository<EmployeeProjectAssignment>
    {
        private readonly ApplicationDbContext _employeeProjectAssignmentContext;

        public EmployeeProjectAssignmentRepository(ApplicationDbContext employeeProjectAssignmentContext)
        {
            this._employeeProjectAssignmentContext = employeeProjectAssignmentContext;
        }

        public async Task<bool> Add(EmployeeProjectAssignment entity)
        {
            try
            {
                _employeeProjectAssignmentContext.EmployeeProjectAssignments.Add(entity);
                await _employeeProjectAssignmentContext.SaveChangesAsync();
                _employeeProjectAssignmentContext.Entry(entity).State = EntityState.Detached;
                Debug.WriteLine("successfully added an employeeprojectAssignment!");
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Adding an employeeProjectAssignment failed... " + e.ToString());
                return false;
            }
        }

        public async Task<bool> CheckIfExists(EmployeeProjectAssignment entity)
        {
            return ( await _employeeProjectAssignmentContext.EmployeeProjectAssignments.FindAsync(entity.EmployeeId,
                entity.ProjectId) == null);
        }

        public async Task Delete(EmployeeProjectAssignment entity)
        {
            _employeeProjectAssignmentContext.Remove(entity);
            await _employeeProjectAssignmentContext.SaveChangesAsync();
        }

        public Task<EmployeeProjectAssignment> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeProjectAssignment>> GetAll()
        {
            return await _employeeProjectAssignmentContext.EmployeeProjectAssignments.ToListAsync();
        }

        public Task<EmployeeProjectAssignment> GetLastId()
        {
            throw new NotImplementedException();
        }

        public async Task Update(EmployeeProjectAssignment entity)
        {
            Debug.WriteLine("updating employeeProjectAssignment");
            EmployeeProjectAssignment dbEntity = await _employeeProjectAssignmentContext.EmployeeProjectAssignments
                .FindAsync(entity.EmployeeId, entity.ProjectId);
            _employeeProjectAssignmentContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _employeeProjectAssignmentContext.SaveChangesAsync();
            Debug.WriteLine("Updated EmployeeProjectAssignments...");
        }
    }
}
