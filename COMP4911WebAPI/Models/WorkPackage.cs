using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class WorkPackage
    {
        public int WorkPackageId { get; set; }
        public int ProjectId { get; set; }

        public string WorkPackageName { get; set; }
        public string WorkPackageDescription { get; set; }
        public double? WorkPackageCost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Purpose { get; set; }
        public int ResponsibleEngineerId { get; set; } 
        public string Contractor { get; set; }
        public string Inputs { get; set; }
        public string Activities { get; set; }
        public string Outputs { get; set; }

        [ForeignKey("ParentWorkPackage")]
        public int? ParentWorkPackageId { get; set; }
        public virtual WorkPackage ParentWorkPackage { get; set; }
        public virtual IList<WorkPackage> ChildrenWorkPackages { get; set; }

        public Project Project { get; set; }

        public IList<TimesheetRow> TimesheetRows { get; set; }
        public IList<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}
