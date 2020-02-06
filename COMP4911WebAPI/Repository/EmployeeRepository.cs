﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Repository
{
    public class EmployeeRepository : IDataRepository<Employee>
    {
        private readonly ApplicationDbContext _employeeContext;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this._employeeContext = context;
        }

        public async Task<bool> Add(Employee entity)
        {
            bool success = false;
            if (_employeeContext.Employees.Any(p => p.EmployeeId == entity.EmployeeId) == false)
            {
                System.Diagnostics.Debug.WriteLine("record doesnt exist, adding...");
                _employeeContext.Employees.Add(entity);
                success = true;
            }
            else
            {
                System.Diagnostics.Debug.Write("record already exists, updating...");
                Employee existingEmployee = _employeeContext.Employees.FirstOrDefault(p => p.EmployeeId == entity.EmployeeId);
                await this.Update(entity);
                success = false;
            }

            await _employeeContext.SaveChangesAsync();  
            _employeeContext.Entry(entity).State = EntityState.Detached;

            return success;
        }

        public Task<bool> CheckIfExists(Employee entity)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> Get(int id)
        {
            return await _employeeContext.Employees.FirstAsync(e => e.EmployeeId == id);  //investigate difference between toListAsync
        }

        //public async Task<Employee> Get(string id)
        //{
        //    return await _employeeContext.Employees.FirstAsync(e => e.EmployeeId == id);
        //}

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _employeeContext.Employees.ToListAsync();
        }

        public Task<Employee> GetLastId()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Employee entity)
        {
            Employee dbEntity = await _employeeContext.Employees.FindAsync(entity.EmployeeId);
            _employeeContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _employeeContext.SaveChangesAsync();
            System.Diagnostics.Debug.Write("Updated employee...");
        }
    }
}
