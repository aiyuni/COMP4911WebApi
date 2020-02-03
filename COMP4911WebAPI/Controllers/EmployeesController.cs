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
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IDataRepository<Employee> _employeeRepository;
        private readonly CredentialRepository _credentialRepository;
        private readonly IDataRepository<EmployeeProjectAssignment> _employeeProjectAssignmentRepository;

        public EmployeesController(IDataRepository<Employee> employeeRepository, IDataRepository<Credential> credentialRepository,
            IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository)
        {
            this._employeeRepository = employeeRepository;
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
                await this.GetFullEmployeeDetails(item);
                employeeList.Add(item);
            }

            return Ok(employeeList);
            //return Ok(await _employeeRepository.GetAll());
        }

        //GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            return Ok(await GetFullEmployeeDetails(await _employeeRepository.Get(id)));
        }

        //Do not delete this. We might need this later.
        ////GET: api/Employees/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetEmployee(string id)
        //{
        //    Credential cred = await _credentialRepository.Get(id);
        //    return Ok(await _employeeRepository.Get(cred.EmployeeId));
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
