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
    public class ProjectRepository : IDataRepository<Project>
    {
        private readonly ApplicationDbContext _projectContext;

        public ProjectRepository(ApplicationDbContext context)
        {
            this._projectContext = context;
        }

        public async Task<bool> Add(Project entity)
        {
            try
            {
                _projectContext.Add(entity);
                await _projectContext.SaveChangesAsync();
                _projectContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Failed to add project: " + e.ToString());
            }
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

        public int GetIdByCode(int code)
        {
            try
            {
                return _projectContext.Projects.First(p => p.ProjectCode == code).ProjectId;
            }
            catch (Exception e)
            {
                throw new Exception("The code: " + code + " cannot be converted to ID: " + e.ToString());
            }
        }

        public Task<Project> GetLastId()
        {
            throw new NotImplementedException();
        }

        public Task Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Project entity)
        {
            Project dbEntity = await _projectContext.Projects.FindAsync(entity.ProjectId);
            _projectContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _projectContext.SaveChangesAsync();
            Debug.WriteLine("updated projects...");
        }

        public async Task<bool> CheckIfProjectCodeExists(int id)
        {
            bool exists = await _projectContext.Projects.AnyAsync(p => p.ProjectCode == id);
            return exists;
        }
    }
}
