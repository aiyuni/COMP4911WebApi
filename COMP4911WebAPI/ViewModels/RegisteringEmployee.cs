using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    public class RegisteringEmployee
    {
        public string EmpUsername { get; set; }
        public string EmpPassword { get; set; }
        public int EmpCode { get; set; }
        public int JobTitleId { get; set; }
        public int LabourGradeId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public int? TimesheetApproverId { get; set; }
        public int? SupervisorId { get; set; }
        public bool isProjectManager { get; set; }
        public bool isAdmin { get; set; }
        public bool isHumanResources { get; set; }

        public RegisteringEmployee()
        {

        }

        public RegisteringEmployee(string empUsername, string empPassword, int jobTitleId, int labourGradeId, string empFirstName, string empLastName,
            int? timesheetApproverId, int? supervisorId, bool isProjectManager, bool isAdmin, bool isHumanResources, int empCode)
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
        }
    }
}
