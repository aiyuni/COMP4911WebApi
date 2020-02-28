using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    /** Used for GetEmployees */
    public class EmployeeDetailsViewModel
    {
        public int EmployeeId { get; set; }
        public string EmpUsername { get; set; }
        public int EmpCode { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public bool IsActivated { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsHumanResources { get; set; }
        public LabourGradeViewModel LabourGrade { get; set; } //full obj here
        public EmployeeNameViewModel TimesheetApprover { get; set; } //use the viewmodel
        public EmployeeNameViewModel Supervisor { get; set; }

        public EmployeeDetailsViewModel(Employee emp, Credential cred, LabourGradeViewModel labourGrade,
            EmployeeNameViewModel timesheetApprover, EmployeeNameViewModel supervisor)
        {
            this.EmployeeId = emp.EmployeeId;
            this.EmpUsername = cred.CredentialId;
            this.EmpCode = emp.EmployeeCode;
            this.EmpFirstName = emp.EmployeeFirstName;
            this.EmpLastName = emp.EmployeeLastName;
            this.IsActivated = emp.IsActivated;
            this.IsProjectManager = emp.IsProjectManager;
            this.IsAdmin = emp.IsAdmin;
            this.IsHumanResources = emp.IsHumanResources;
            this.LabourGrade = labourGrade;

            if (timesheetApprover != null)
            {
                this.TimesheetApprover = timesheetApprover;
            }
            if (supervisor != null)
            {
                this.Supervisor = supervisor;
            }
        }
     
    }
}
