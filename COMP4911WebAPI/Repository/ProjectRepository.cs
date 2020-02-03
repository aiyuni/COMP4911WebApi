using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class ProjectRepository : IDataRepository<Project>
    {
        private readonly ApplicationDbContext _projectContext;

        public ProjectRepository(ApplicationDbContext context)
        {
            this._projectContext = context;
        }

        public async Task<bool> Add(Project entity)
        {
            bool success = false;
            if (_projectContext.Projects.Any(p => p.ProjectId == entity.ProjectId) == false)
            {
                Debug.WriteLine("project record doesnt exist, adding...");
                _projectContext.Add(entity);
                success = true;
            }
            else
            {
                Debug.WriteLine("project record already exists, updating... ");
                Project existingProject = _projectContext.Projects.FirstOrDefault(p => p.ProjectId == entity.ProjectId);
                await this.Update(existingProject, entity);
                success = false;
            }

            await _projectContext.SaveChangesAsync();
            _projectContext.Entry(entity).State = EntityState.Detached;

            return success;
        }

        public async Task<bool> CheckIfExists(Project entity)
        {
            return (await _projectContext.Projects.FindAsync(entity.ProjectId) != null);
        }

        public async Task<Project> GetProjectByName(string name)
        {
            return (await _projectContext.Projects.Where(p => p.ProjectName.Equals(name)).FirstOrDefaultAsync());
        }
        public async Task<Project> Get(int id)
        {
            return  _projectContext.Projects.Find(id);
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _projectContext.Projects.ToListAsync();
        }

        public Task<Project> GetLastId()
        {
            throw new NotImplementedException();
        }

        public Task Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Project dbEntity, Project entity)
        {
            _projectContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            Debug.WriteLine("updated...");
        }
    }
}
