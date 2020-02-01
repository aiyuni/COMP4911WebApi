using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class EmployeeProjectAssignment
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public Employee Employee { get; set; }
        public Project Project { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }
    }
}
