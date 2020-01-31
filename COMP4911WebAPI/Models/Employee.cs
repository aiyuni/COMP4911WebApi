using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [ForeignKey("JobId")]
        public int JobId { get; set; }

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

        public Timesheet Timesheet { get; set; }

        public IList<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; }
        public IList<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }

        public string Row_Lst_Upd_Uid { get; set; }
        public DateTime Row_Lst_Upd_Ts { get; set; }

        public Employee()
        {

        }
        public Employee(int jobId, string firstName, string lastName, int? timesheetApproverId, int? supervisorId, bool isActivated,
            bool isProjectManager, bool isAdmin, bool isHumanResources)
        {
            JobId = jobId;
            EmployeeFirstName = firstName;
            EmployeeLastName = lastName;
            TimesheetApproverId = timesheetApproverId;
            SupervisorId = supervisorId;
            this.IsActivated = isActivated;
            this.IsProjectManager = isProjectManager;
            this.IsAdmin = isAdmin;
            this.IsHumanResources = isHumanResources;
            this.Row_Lst_Upd_Ts = DateTime.Now;
            this.Row_Lst_Upd_Uid = System.Environment.UserName.ToString();
        }
    }
}
