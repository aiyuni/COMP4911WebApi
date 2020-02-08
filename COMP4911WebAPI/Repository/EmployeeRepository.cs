using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
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
            try
            {
                _employeeContext.Employees.Add(entity);
                await _employeeContext.SaveChangesAsync();
                _employeeContext.Entry(entity).State = EntityState.Detached;
                return true;
            }
            catch (Exception e )
            {
                throw new Exception("Failed to add Employee: " + e.ToString());
            }
        }

        public async Task<bool> CheckIfEmpCodeExists(int code)
        {
            bool exists = await _employeeContext.Employees.AnyAsync(e => e.EmployeeCode == code);
            return exists;
        }

        public async Task<Employee> Get(int id)
        {
            return await _employeeContext.Employees.FirstAsync(e => e.EmployeeId == id);  //investigate difference between toListAsync
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _employeeContext.Employees.ToListAsync();
        }

        public async Task Update(Employee entity)
        {
            Employee dbEntity = await _employeeContext.Employees.FindAsync(entity.EmployeeId);
            _employeeContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _employeeContext.SaveChangesAsync();
            System.Diagnostics.Debug.Write("Updated employee...");
        }

        public async Task Delete(Employee entity)
        {
            throw new NotImplementedException("Why are you trying to delete evidence...");
        }

        public Task<bool> CheckIfExists(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetLastId()
        {
            throw new NotImplementedException();
        }

    }
}
