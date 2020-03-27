using System;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.Repository
{
    // public class ProjectReportRepository : IDataRepository<ProjectReport>
    // {

    //     private readonly ApplicationDbContext _projectReportContext;

    //     public ProjectReportRepository(ApplicationDbContext context)
    //     {
    //         this._projectReportContext = context;
    //     }
    //     public Task<bool> Add(ProjectReport entity)
    //     {
    //         try
    //         {
    //             _projectReportContext.ProjectReport.Add(entity);
    //             await _projectReportContext.SaveChangesAsync();
    //             _projectReportContext.Entry(entity).State = EntityState.Detached;
    //             return true;
    //         }
    //         catch (Exception e)
    //         {
    //             throw new Exception("Failed to add Project Report: " + e.ToString());
    //         }
    //     }

    //     public Task<bool> CheckIfExists(ProjectReport entity)
    //     {
    //         throw new System.NotImplementedException();
    //     }

    //     public Task Delete(ProjectReport entity)
    //     {
    //         throw new System.NotImplementedException();
    //     }

    //     public Task<ProjectReport> Get(int id)
    //     {
    //         return await _projectReportContext.ProjectReport.FindAsync(id);
    //     }

    //     public Task<System.Collections.Generic.IEnumerable<ProjectReport>> GetAll()
    //     {
    //         throw new System.NotImplementedException();
    //     }

    //     public Task<ProjectReport> GetLastId()
    //     {
    //         throw new System.NotImplementedException();
    //     }

    //     public Task Update(ProjectReport entity)
    //     {
    //         throw new System.NotImplementedException();
    //     }
    // }
}