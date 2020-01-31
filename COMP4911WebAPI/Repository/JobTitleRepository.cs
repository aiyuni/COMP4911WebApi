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

        public void Add(JobTitle entity)
        {
            if (_jobTitleContext.JobTitle.Any(p => p.JobTitleId == entity.JobTitleId) == false)
            {
                System.Diagnostics.Debug.WriteLine("record doesnt exist, adding new job title...");
                _jobTitleContext.JobTitle.Add(entity);
            }
            else
            {
                System.Diagnostics.Debug.Write("record already exists, updating existing job title...");
                JobTitle existingJobTitle = _jobTitleContext.JobTitle.FirstOrDefault(p => p.JobTitleId == entity.JobTitleId);
                this.Update(existingJobTitle, entity);
            }

            _jobTitleContext.SaveChanges();
            _jobTitleContext.Entry(entity).State = EntityState.Detached;
        }

        public void Delete(JobTitle entity)
        {
            throw new NotImplementedException();
        }

        public JobTitle Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobTitle> GetAll()
        {
            return _jobTitleContext.JobTitle.ToList();
        }

        public void Update(JobTitle dbEntity, JobTitle entity)
        {
            _jobTitleContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            System.Diagnostics.Debug.Write("Updated credentials...");
        }
    }
}
