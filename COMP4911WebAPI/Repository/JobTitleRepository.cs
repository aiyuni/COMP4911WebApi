using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class JobTitleRepository : IDataRepository<JobTitle>
    {
        public readonly ApplicationDbContext _jobTitleContext;

        public JobTitleRepository(ApplicationDbContext context)
        {
            this._jobTitleContext = context;
        }

        public async Task<bool> Add(JobTitle entity)
        {
            try
            {
                _jobTitleContext.JobTitles.Add(entity);
                await _jobTitleContext.SaveChangesAsync();
                _jobTitleContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e)
            { 
                throw new Exception("failed to add job title: " + e.ToString());
            }
        }

        public Task<bool> CheckIfExists(JobTitle entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(JobTitle entity)
        {
            throw new NotImplementedException();
        }

        public async Task<JobTitle> Get(int id)
        {
            return await _jobTitleContext.JobTitles.FindAsync(id);
        }

        public async Task<IEnumerable<JobTitle>> GetAll()
        {
            return await _jobTitleContext.JobTitles.ToListAsync();
        }

        public Task<JobTitle> GetLastId()
        {
            throw new NotImplementedException();
        }

        public async Task Update(JobTitle entity)
        {
            JobTitle dbEntity = await _jobTitleContext.JobTitles.FindAsync(entity.JobTitleId);
            _jobTitleContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _jobTitleContext.SaveChangesAsync();
            System.Diagnostics.Debug.Write("Updated jobTitle...");
        }

        
    }
}
