using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace COMP4911WebAPI.ViewModels
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectCode { get; set; }
        public double Budget { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public EmployeeNameViewModel ProjectManager { get; set; }
        public IList<EmployeeNameViewModel> Employees { get; set; }
        

    }
}
