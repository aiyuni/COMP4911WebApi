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

            //if (_jobTitleContext.JobTitle.Any(p => p.JobTitleId == entity.JobTitleId) == false)
            //{
            //    System.Diagnostics.Debug.WriteLine("record doesnt exist, adding new job title...");
            //    _jobTitleContext.JobTitle.Add(entity);
            //    success = true;
            //}
            //else
            //{
            //    System.Diagnostics.Debug.Write("record already exists, updating existing job title...");
            //    JobTitle existingJobTitle = _jobTitleContext.JobTitle.FirstOrDefault(p => p.JobTitleId == entity.JobTitleId);
            //    await this.Update(existingJobTitle, entity);
            //    success = false;
            //}

            _jobTitleContext.JobTitles.Add(entity);
            await _jobTitleContext.SaveChangesAsync();
            _jobTitleContext.Entry(entity).State = EntityState.Detached;

            return true;
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
