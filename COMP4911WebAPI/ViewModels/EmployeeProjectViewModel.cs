using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace COMP4911WebAPI.ViewModels
{
    /**Model to represent a list of projects belonging to an Employee*/
    public class EmployeeProjectViewModel
    {

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public EmployeeNameViewModel ProjectManager { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; }

        public EmployeeProjectViewModel(int projectId, string projectName, EmployeeNameViewModel projectManager,
            DateTime startDate, DateTime endDate, bool isClosed)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.ProjectManager = projectManager;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.IsClosed = isClosed;


        }

    }
}
