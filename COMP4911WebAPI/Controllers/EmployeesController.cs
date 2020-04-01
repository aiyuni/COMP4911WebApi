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
using Microsoft.AspNetCore.Cors;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeRepository _employeeRepository;
        private readonly CredentialRepository _credentialRepository;
        private readonly IDataRepository<EmployeeProjectAssignment> _employeeProjectAssignmentRepository;
        private readonly IDataRepository<LabourGrade> _labourGradeRepository;

        public EmployeesController(IDataRepository<Employee> employeeRepository, IDataRepository<Credential> credentialRepository,
            IDataRepository<EmployeeProjectAssignment> employeeProjectAssignmentRepository,
            IDataRepository<LabourGrade> labourGradeRepository)
        {
            this._employeeRepository = (EmployeeRepository)employeeRepository;
            this._credentialRepository = (CredentialRepository)credentialRepository;
            this._employeeProjectAssignmentRepository = employeeProjectAssignmentRepository;
            this._labourGradeRepository = labourGradeRepository;
        }

        //GET: api/Employees/AllEmployees
        [HttpGet("AllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            //generate list of employees
            foreach (Employee item in await _employeeRepository.GetAll())
            {
                employeeList.Add(await this.GetFullEmployeeDetails(item));
            }

            List<EmployeeDetailsViewModel> employeeDetailsList = new List<EmployeeDetailsViewModel>();

            //generating list of employee details
            foreach (Employee emp in employeeList)
            {
                Credential empCred = (await _credentialRepository.GetAll()).FirstOrDefault(c => c.EmployeeId == emp.EmployeeId);
                LabourGrade labourGrade = await _labourGradeRepository.Get(emp.LabourGradeId);
                Employee empTimesheetApprover = null;
                Employee empSupervisor = null;
                if (emp.TimesheetApproverId != null)
                {
                    empTimesheetApprover = await _employeeRepository.Get((int)emp.TimesheetApproverId); //cast nullable to int
                }

                if (emp.SupervisorId != null)
                {
                    empSupervisor = await _employeeRepository.Get((int)emp.SupervisorId);
                }
                EmployeeDetailsViewModel thisEmployee = new EmployeeDetailsViewModel(emp, empCred, new LabourGradeViewModel(labourGrade),
                    new EmployeeNameViewModel(empTimesheetApprover), new EmployeeNameViewModel(empSupervisor));
                    employeeDetailsList.Add(thisEmployee);
            }

            return Ok(employeeDetailsList);
        }

        //GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            Employee emp = await _employeeRepository.Get(id);
            Credential empCred = (await _credentialRepository.GetAll()).FirstOrDefault(c => c.EmployeeId == emp.EmployeeId);
            LabourGrade labourGrade = await _labourGradeRepository.Get(emp.LabourGradeId);
            Employee empTimesheetApprover = null;
            Employee empSupervisor = null;
            if (emp.TimesheetApproverId != null)
            {
                empTimesheetApprover = await _employeeRepository.Get((int)emp.TimesheetApproverId); //cast nullable to int
            }

            if (emp.SupervisorId != null)
            {
                empSupervisor = await _employeeRepository.Get((int)emp.SupervisorId);
            }
            EmployeeDetailsViewModel thisEmployee = new EmployeeDetailsViewModel(emp, empCred, new LabourGradeViewModel(labourGrade),
                new EmployeeNameViewModel(empTimesheetApprover), new EmployeeNameViewModel(empSupervisor));

            return Ok(thisEmployee);
        }

        //GET: api/Employees/CheckEmployeCodeAvailability/5
        [HttpGet("CheckEmployeeCodeAvailability/{id}")]
        public async Task<IActionResult> GetEmployeeCodeAvailability(int id)
        {
            bool value = await _employeeRepository.CheckIfEmpCodeExists(id);
            return Ok(!value);
        }

        //For internal use only.
        [HttpGet("GetAllEmployeesByLabourGrade/{id}")]
        public async Task<IEnumerable<Employee>> GetAllEmployeesByLabourGrade(int id)
        {
            return (await _employeeRepository.GetAll()).Where(e => e.LabourGradeId == id);
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(EmployeeViewModel newEmployeeViewModel)
        {
            if (ModelState.IsValid)
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
            else
            {
                Debug.WriteLine("error");
                return new OkObjectResult(402);
            }

        }

        // PUT: api/Employees
        [HttpPut]
        public async Task<IActionResult> PutEmployee(EmployeeViewModel emp)
        {
            await _employeeRepository.Update(new Employee(emp));
            if (emp.EmpPassword != null)
            {
                await _credentialRepository.Delete(
                    (await _credentialRepository.GetAll()).SingleOrDefault(c => c.EmployeeId == emp.EmployeeId));
                await _credentialRepository.Add(new Credential(emp.EmpUsername, emp.EmpPassword, emp.EmployeeId));
            }

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
        
        //GET: api/Employees/getChildren/2   
         [HttpGet("getChildren/{id}")]
        public async Task<IActionResult> GetAllChildrenEmployee(int id)
        {
            List<Employee> employeeListWithFilteredSupervisorId = new List<Employee>();

            //generate list of employees
            foreach (Employee item in await _employeeRepository.GetAll())
            {   
                if(item.SupervisorId == id)
                    employeeListWithFilteredSupervisorId.Add(await this.GetFullEmployeeDetails(item));
            }

            List<EmployeeChildrenListViewModel> employeeDetailsList = new List<EmployeeChildrenListViewModel>();

            //generating list of employee details
            foreach (Employee emp in employeeListWithFilteredSupervisorId)
            {
                Employee empTimesheetApprover = null;
                if (emp.TimesheetApproverId != null)
                {
                    empTimesheetApprover = await _employeeRepository.Get((int)emp.TimesheetApproverId); //cast nullable to int
                }

                
                EmployeeChildrenListViewModel thisEmployee = new EmployeeChildrenListViewModel(emp, new EmployeeNameViewModel(empTimesheetApprover));
                employeeDetailsList.Add(thisEmployee);
            }

            return Ok(employeeDetailsList);
        }

    }
}
