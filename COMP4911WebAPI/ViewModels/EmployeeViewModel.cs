using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    /**Model to represent the employee view for post/put */
    public class EmployeeViewModel
    {
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public string EmpUsername { get; set; }

        [Required]
        public string EmpPassword { get; set; }

        [Required]
        [Range(0, Int32.MaxValue)]
        public int EmpCode { get; set; }

        public int JobTitleId { get; set; }

        [Required]
        public int LabourGradeId { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z]+")]
        public string EmpFirstName { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z]+")]
        public string EmpLastName { get; set; }

        public int? TimesheetApproverId { get; set; }

        public int? SupervisorId { get; set; }

        [Required]
        public bool isProjectManager { get; set; }

        [Required]
        public bool isAdmin { get; set; }

        [Required]
        public bool isHumanResources { get; set; }

        [Required]
        public bool isActivated { get; set; }

        public EmployeeNameViewModel TimesheetApprover { get; set; }
        public EmployeeNameViewModel Supervisor { get; set; }

        public EmployeeViewModel()
        {

        }

        public EmployeeViewModel(string empUsername, string empPassword, int jobTitleId, int labourGradeId, string empFirstName, string empLastName,
            int? timesheetApproverId, int? supervisorId, bool isProjectManager, bool isAdmin, bool isHumanResources, int empCode, bool isActive)
        {
            this.EmpUsername = empUsername;
            this.EmpPassword = empPassword;
            this.JobTitleId = jobTitleId;
            this.LabourGradeId = labourGradeId;
            this.EmpFirstName = empFirstName;
            this.EmpLastName = empLastName;
            this.TimesheetApproverId = timesheetApproverId;
            this.SupervisorId = supervisorId;
            this.isProjectManager = isProjectManager;
            this.isAdmin = isAdmin;
            this.isHumanResources = isHumanResources;
            this.EmpCode = empCode;
            this.isActivated = isActive;
        }
    }
}
