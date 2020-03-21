using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        public int ProjectCode { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectDescription { get; set; }

        [Required]
        public double Budget { get; set; }

        [Required]
        public int ProjectManagerId { get; set; }

        [Required]
        public bool IsClosed { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public IList<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; } 
        public IList<WorkPackage> WorkPackages { get; set; }


        public Project()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        //For POST, PUT
        public Project(ProjectViewModel projViewModel)
        {
            this.Budget = projViewModel.Budget;
            this.ProjectName = projViewModel.ProjectName;
            this.ProjectCode = projViewModel.ProjectCode;
            this.StartDate = projViewModel.StartDate;
            this.EndDate = projViewModel.EndDate;
            this.ProjectDescription = projViewModel.Description;
            this.IsClosed = projViewModel.IsClosed;

            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        //For seeding
        public Project(int id, int code, string name, string description, int projectManagerId, DateTime startDate, DateTime endDate, bool isClosed)
        {
            this.ProjectId = id;
            this.ProjectCode = code;
            this.ProjectName = name;
            this.ProjectDescription = description;
            this.ProjectManagerId = projectManagerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = "seeded";
            this.IsClosed = isClosed;
            this.Budget = 1337;
        }

        public Project(int code, string name, string description, int projectManagerId, DateTime startDate, DateTime endDate)
        {
            this.ProjectCode = code;
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
