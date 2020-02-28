﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.Repository
{
    public class LabourGradeRepository : IDataRepository<LabourGrade>
    {
        private readonly ApplicationDbContext _labourGradeContext;

        public LabourGradeRepository(ApplicationDbContext context)
        {
            this._labourGradeContext = context;
        }

        public Task<bool> Add(LabourGrade entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckIfExists(LabourGrade entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(LabourGrade entity)
        {
            throw new NotImplementedException();
        }

        public async Task<LabourGrade> Get(int id)
        {
            return await _labourGradeContext.LabourGrades.FindAsync(id);
        }

        public Task<IEnumerable<LabourGrade>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LabourGrade> GetLastId()
        {
            throw new NotImplementedException();
        }

        public Task Update(LabourGrade entity)
        {
            throw new NotImplementedException();
        }
    }
}
