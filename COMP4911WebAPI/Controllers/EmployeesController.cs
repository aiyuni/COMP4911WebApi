using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IDataRepository<Employee> _employeeRepository;
        private readonly IDataRepository<Credential> _credentialRepository;
        public EmployeesController(IDataRepository<Employee> employeeRepository, IDataRepository<Credential> credentialRepository)
        {
            this._employeeRepository = employeeRepository;
            this._credentialRepository = credentialRepository;
        }

        //GET: api/Employees/AllEmployees
        [HttpGet("AllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _employeeRepository.GetAll());
        }

        [HttpGet("AvailableEmployeeUsername")]
        public async Task<IActionResult> GetAvailableUserName()
        {
            return Ok(await _employeeRepository.GetAll());
        }

        // GET: api/Employees
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        //{
        //    return await _context.Employees.ToListAsync();
        //}

        //// GET: api/Employees/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Employee>> GetEmployee(int id)
        //{
        //    var employee = await _context.Employees.FindAsync(id);

        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return employee;
        //}

        //// PUT: api/Employees/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEmployee(int id, Employee employee)
        //{
        //    if (id != employee.EmployeeId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(employee).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(RegisteringEmployee newEmployee)
        {
            Credential tempCredential = new Credential(newEmployee.EmpUsername, "temp", 1);
            if (!await _credentialRepository.CheckIfExists(tempCredential))
            {
                Console.WriteLine("new employee, adding...");
                Employee emp = new Employee(newEmployee.JobTitleId, newEmployee.EmpFirstName, newEmployee.EmpLastName, (int?)newEmployee.TimesheetApproverId,
                    (int?)newEmployee.SupervisorId, true, newEmployee.isProjectManager, newEmployee.isAdmin, newEmployee.isHumanResources);
                await _employeeRepository.Add(emp);

                Credential credential = new Credential(newEmployee.EmpUsername, newEmployee.EmpPassword, emp.EmployeeId);
                await _credentialRepository.Add(credential);
            }

            return new OkObjectResult(200);
        }

        //// DELETE: api/Employees/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        //{
        //    var employee = await _context.Employees.FindAsync(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Employees.Remove(employee);
        //    await _context.SaveChangesAsync();

        //    return employee;
        //}

        //private bool EmployeeExists(int id)
        //{
        //    return _context.Employees.Any(e => e.EmployeeId == id);
        //}
    }
}
