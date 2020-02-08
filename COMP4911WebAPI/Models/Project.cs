using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int ProjectManagerId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IList<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; } 
        public IList<WorkPackage> WorkPackages { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public Project()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        //For seeding
        public Project(int id, string name, string description, int projectManagerId, DateTime startDate, DateTime endDate)
        {
            this.ProjectId = id;
            this.ProjectName = name;
            this.ProjectDescription = description;
            this.ProjectManagerId = projectManagerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = "seeded";
        }

        public Project(string name, string description, int projectManagerId, DateTime startDate, DateTime endDate)
        {
            this.ProjectName = name;
            this.ProjectDescription = description;
            this.ProjectManagerId = projectManagerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }


    }
}
