using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace COMP4911WebAPI.ViewModels
{
    /**Model to represent a list of projects belonging to an Employee*/
    public class EmployeeProjectListViewModel
    {
        public int EmployeeId { get; set; }
        public int EmployeeCode { get; set; }
        public IList<Project> ProjectList { get; set; }

        public EmployeeProjectListViewModel(int empId, int code, IList<Project> list)
        {
            this.EmployeeId = empId;
            this.EmployeeCode = code;
            this.ProjectList = list;

            //Prevent unnecessary details
            foreach (var item in this.ProjectList)
            {
                item.EmployeeProjectAssignments = null;
            }
        }

    }
}
