using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using COMP4911WebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly CredentialRepository _credentialRepository;
        private readonly IDataRepository<EmployeeProjectAssignment> _employeeProjectAssignmentRepository;

        public EmployeesController(IDataRepository<Employee> employeeRepository, IDataRepository<Credential> credentialRepository,
            IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository)
        {
            this._employeeRepository = (EmployeeRepository)employeeRepository;
            this._credentialRepository = (CredentialRepository) credentialRepository;
            this._employeeProjectAssignmentRepository = employeeProjectAssignmentRepository;
        }

        //GET: api/Employees/AllEmployees
        [HttpGet("AllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            foreach (Employee item in await _employeeRepository.GetAll())
            {
                employeeList.Add(await this.GetFullEmployeeDetails(item));  
            }
            return Ok(employeeList);
        }

        //GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            return Ok(await GetFullEmployeeDetails(await _employeeRepository.Get(id)));
        }

        //GET: api/Employees/CheckEmployeCodeAvailability/5
        [HttpGet("CheckEmployeeCodeAvailability/{id}")]
        public async Task<IActionResult> GetEmployeeCodeAvailability(int id)
        {
            bool value = await _employeeRepository.CheckIfEmpCodeExists(id);
            return Ok(value);
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(EmployeeViewModel newEmployeeViewModel)
        {
            Credential tempCredential = new Credential(newEmployeeViewModel.EmpUsername, "temp", 1);
            if (!await _credentialRepository.CheckIfExists(tempCredential))
            {
                Console.WriteLine("new employee, adding...");
                Employee emp = new Employee(newEmployeeViewModel);
                await _employeeRepository.Add(emp);
                await _credentialRepository.Add(new Credential(newEmployeeViewModel.EmpUsername, newEmployeeViewModel.EmpPassword, emp.EmployeeId));
            }
            return new OkObjectResult(200);
        }

        // PUT: api/Employees
        [HttpPut]
        public async Task<IActionResult> PutEmployee(EmployeeViewModel emp)
        {
            await _employeeRepository.Update(new Employee(emp));
            await _credentialRepository.Delete(
                (await _credentialRepository.GetAll()).SingleOrDefault(c => c.EmployeeId == emp.EmployeeId));
            await _credentialRepository.Add(new Credential(emp.EmpUsername, emp.EmpPassword, emp.EmployeeId));
            return Ok(emp);
        }

        private async Task<Employee> GetFullEmployeeDetails(Employee emp)
        {
            foreach (EmployeeProjectAssignment item in await _employeeProjectAssignmentRepository.GetAll())
            {
                if (item.EmployeeId == emp.EmployeeId)
                {
                  //  item.Project = null;
                    item.Employee = null;
                    emp.EmployeeProjectAssignments.Add(item);
                }
            }
            return emp;
        }
    }
}
