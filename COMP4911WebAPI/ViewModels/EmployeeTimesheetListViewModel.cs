using COMP4911WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    public class EmployeeTimesheetListViewModel
    {
        public int EmployeeId { get; set; }
        public int EmployeeCode { get; set; }

        public IList<TimesheetViewModel> TimesheetList { get; set; }

        public EmployeeTimesheetListViewModel(int empId, int code, IList<TimesheetViewModel> list)
        {
            this.EmployeeId = empId;
            this.EmployeeCode = code;
            this.TimesheetList = list;

            //foreach (var item in this.TimesheetList)
            //{
            //    item.Employee = null;
            //}
        }


    }
}
