using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class ProjectReportRepository : IDataRepository<ProjectReport>
    {

        private readonly ApplicationDbContext _projectReportContext;

        public ProjectReportRepository(ApplicationDbContext context)
        {
            this._projectReportContext = context;
        }
        public async Task<bool> Add(ProjectReport entity)
        {
            try
            {
                _projectReportContext.ProjectReport.Add(entity);
                await _projectReportContext.SaveChangesAsync();
                _projectReportContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to add Project Report: " + e.ToString());
            }
        }

        public async Task<bool> CheckIfExists(ProjectReport entity)
        {
            return (await _projectReportContext.ProjectReport.FindAsync(entity.ProjectReportId) != null);
        }

        public Task Delete(ProjectReport entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ProjectReport> Get(int id)
        {
            return await _projectReportContext.ProjectReport.FindAsync(id);
        }

        public async Task<System.Collections.Generic.IEnumerable<ProjectReport>> GetAll()
        {
             return await _projectReportContext.ProjectReport.ToListAsync();
        }

        public async Task<ProjectReport> GetLastId()
        {
            return await _projectReportContext.ProjectReport.OrderBy(pr => pr.ProjectReportId).LastOrDefaultAsync();
        }

        public async Task Update(ProjectReport entity)
        {
            ProjectReport dbEntity = await _projectReportContext.ProjectReport.FindAsync(entity.ProjectReportId);
            _projectReportContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _projectReportContext.SaveChangesAsync();
            Debug.WriteLine("Updated Project Report...");
        }
    }
}