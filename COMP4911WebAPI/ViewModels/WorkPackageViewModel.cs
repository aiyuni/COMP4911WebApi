using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    //Used for POST/PUT/GET WorkPackage
    public class WorkPackageViewModel
    {
        public int WorkPackageId { get; set; }
        public int ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string WorkPackageCode { get; set; }
        public string WorkPackageTitle { get; set; }
        public string Contractor { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsClosed { get; set; }
        public EmployeeNameViewModel ResponsibleEngineer { get; set; }
        public string ParentWorkPackageId { get; set; }
        public IList<EmployeeNameViewModel> Employees { get; set; }
        public IList<PmPlanningViewModel> PmPlannings { get; set; }
    }

    public class PmPlanningViewModel
    {
        public int LabourGradeId { get; set; }
        public double PmEAC { get; set; }
        public double ReBudget { get; set; }
    }
}
