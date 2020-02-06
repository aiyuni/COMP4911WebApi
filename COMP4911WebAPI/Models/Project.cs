﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int ProjectManagerId { get; set; }

        //add start date, end date

        public IList<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; }
        public IList<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }
        public IList<WorkPackage> WorkPackages { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public Project()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        public Project(int id, string name, string description, int projectManagerId)
        {
            this.ProjectId = id;
            this.ProjectName = name;
            this.ProjectDescription = description;
            this.ProjectManagerId = projectManagerId;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        public Project(string name, string description, int projectManagerId)
        {
            this.ProjectName = name;
            this.ProjectDescription = description;
            this.ProjectManagerId = projectManagerId;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }


    }
}
