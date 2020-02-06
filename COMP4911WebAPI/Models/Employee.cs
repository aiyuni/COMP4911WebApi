using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Models
{
    public class Employee
    {
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [ForeignKey("JobId")]
        public int JobTitleId { get; set; }

        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public bool IsActivated { get; set; }
        public int? TimesheetApproverId { get; set; }
        public int? SupervisorId { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsHumanResources { get; set; }

        public Employee TimesheetApprover { get; set; }
        public Employee Supervisor { get; set; }
        public JobTitle JobTitle { get; set; }

        public IList<Timesheet> Timesheets { get; set; }

        public IList<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; }
        public IList<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public Employee()
        {

        }

        public Employee(RegisteringEmployee emp)
        {
            this.JobTitleId = emp.JobTitleId;
            this.EmployeeFirstName = emp.EmpFirstName;
            this.EmployeeLastName = emp.EmpLastName;
            this.SupervisorId = emp.SupervisorId;
            this.TimesheetApproverId = emp.TimesheetApproverId;
            this.IsActivated = true;
            this.IsAdmin = emp.isAdmin;
            this.IsHumanResources = emp.isHumanResources;
            this.IsProjectManager = emp.isProjectManager;
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;

        }

        //Used for seeding 
        public Employee(int empId, int jobId, string firstName, string lastName, int? timesheetApproverId, int? supervisorId, bool isActivated,
            bool isProjectManager, bool isAdmin, bool isHumanResources)
        {
            this.EmployeeId = empId;
            JobTitleId = jobId;
            EmployeeFirstName = firstName;
            EmployeeLastName = lastName;
            TimesheetApproverId = timesheetApproverId;
            SupervisorId = supervisorId;
            this.IsActivated = isActivated;
            this.IsProjectManager = isProjectManager;
            this.IsAdmin = isAdmin;
            this.IsHumanResources = isHumanResources;
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;
        }

        //Replaced
        /*        public Employee(int jobId, string firstName, string lastName, int? timesheetApproverId, int? supervisorId, bool isActivated,
            bool isProjectManager, bool isAdmin, bool isHumanResources)
        {
            JobTitleId = jobId;
            EmployeeFirstName = firstName;
            EmployeeLastName = lastName;
            TimesheetApproverId = timesheetApproverId;
            SupervisorId = supervisorId;
            this.IsActivated = isActivated;
            this.IsProjectManager = isProjectManager;
            this.IsAdmin = isAdmin;
            this.IsHumanResources = isHumanResources;
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;
        } */
    }
}
