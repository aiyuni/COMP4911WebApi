using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class EmployeeWorkPackageAssignment
    {
        public int EmployeeId { get; set; }
        public int? WorkPackageId { get; set; }
        public int ProjectId { get; set; }

        public Employee Employee { get; set; }
        public WorkPackage WorkPackage { get; set; }
    }
}
