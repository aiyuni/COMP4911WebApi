using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class WorkPackageLabourGradeAssignmentRepository : IDataRepository<WorkPackageLabourGradeAssignment>
    {
        private readonly ApplicationDbContext _workPackageLabourGradeContext;

        public WorkPackageLabourGradeAssignmentRepository(ApplicationDbContext context)
        {
            this._workPackageLabourGradeContext = context;
        }

        public async Task<bool> Add(WorkPackageLabourGradeAssignment entity)
        {
            try
            {
                _workPackageLabourGradeContext.Add(entity);
                await _workPackageLabourGradeContext.SaveChangesAsync();
                _workPackageLabourGradeContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to add WorkPackageLabourGradeAssignment: " + e.ToString());
            }
        }

        public Task<bool> CheckIfExists(WorkPackageLabourGradeAssignment entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(WorkPackageLabourGradeAssignment entity)
        {
            throw new NotImplementedException();
        }

        public async Task<WorkPackageLabourGradeAssignment> Get(int id)
        {
            return await _workPackageLabourGradeContext.WorkPackageLabourGradeAssignment.FindAsync(id);
        }

        public async Task<IEnumerable<WorkPackageLabourGradeAssignment>> GetAll()
        {
            return await _workPackageLabourGradeContext.WorkPackageLabourGradeAssignment.ToListAsync();
        }

        public Task<WorkPackageLabourGradeAssignment> GetLastId()
        {
            throw new NotImplementedException();
        }

        public async Task Update(WorkPackageLabourGradeAssignment entity)
        {
            WorkPackageLabourGradeAssignment dbEntity =
                await _workPackageLabourGradeContext.FindAsync<WorkPackageLabourGradeAssignment>(entity.WorkPackageId, entity.LabourGradeId);
            _workPackageLabourGradeContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _workPackageLabourGradeContext.SaveChangesAsync();
            Debug.WriteLine("Updated WorkPackageLabourGradeAssignments...");
        }
    }
}
