using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    /**Simplified Employee view model with just the names */
    public class EmployeeNameViewModel
    {
        public int EmployeeId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }

        public EmployeeNameViewModel(Employee emp)
        {
            if (emp != null)
            {
                this.EmployeeId = emp.EmployeeId;
                this.EmpFirstName = emp.EmployeeFirstName;
                this.EmpLastName = emp.EmployeeLastName;
            }
        }
    }
}
