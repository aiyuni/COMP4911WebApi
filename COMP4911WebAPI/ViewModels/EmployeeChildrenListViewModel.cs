using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    public class EmployeeChildrenListViewModel
    {
        public int EmployeeId { get; set; }
        public int EmpCode { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public EmployeeNameViewModel TimesheetApprover { get; set; }

        public EmployeeChildrenListViewModel(Employee emp, EmployeeNameViewModel timesheetApprover)
        {
            this.EmployeeId = emp.EmployeeId;
            this.EmpCode = emp.EmployeeCode;
            this.EmpFirstName = emp.EmployeeFirstName;
            this.EmpLastName = emp.EmployeeLastName;
            this.TimesheetApprover = timesheetApprover;
        }
     
    }
}