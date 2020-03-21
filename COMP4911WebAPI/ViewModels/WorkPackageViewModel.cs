using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore.Migrations;

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
        public string ParentWorkPackageCode { get; set; }
        public IList<EmployeeNameViewModel> Employees { get; set; }
        public IList<PmPlanningViewModel> PmPlannings { get; set; }

        public WorkPackageViewModel()
        {

        }

        //Used for GET,PUT,POST
        public WorkPackageViewModel(WorkPackage wp, string parentWpCode, Project proj, EmployeeNameViewModel re, IList<EmployeeNameViewModel> emps,
            IList<PmPlanningViewModel> pmPlannings)
        {
            this.WorkPackageId = wp.WorkPackageId;
            this.ProjectCode = proj.ProjectCode;
            this.ProjectName = proj.ProjectName;
            this.WorkPackageCode = wp.WorkPackageCode;
            this.WorkPackageTitle = wp.Name;
            this.Contractor = wp.Contractor;
            this.IssueDate = wp.IssueDate;
            this.IsClosed = wp.IsClosed;
            this.ParentWorkPackageCode = parentWpCode;
            this.ResponsibleEngineer = re;
            this.Employees = emps;
            this.PmPlannings = pmPlannings;

        }

        //Used for getAllWpByProjectId
        public WorkPackageViewModel(WorkPackage wp, string parentWpCode, Project proj)
        {
            this.WorkPackageId = wp.WorkPackageId;
            this.ProjectCode = proj.ProjectCode;
            this.ProjectName = proj.ProjectName;
            this.WorkPackageCode = wp.WorkPackageCode;
            this.WorkPackageTitle = wp.Name;
            this.Contractor = wp.Contractor;
            this.IssueDate = wp.IssueDate;
            this.IsClosed = wp.IsClosed;
            this.ParentWorkPackageCode = parentWpCode;
        }

        //Used for getAllWpByEmpId
        public WorkPackageViewModel(WorkPackage wp, string parentWpCode, Project proj, EmployeeNameViewModel re)
        {
            this.WorkPackageId = wp.WorkPackageId;
            this.ProjectCode = proj.ProjectCode;
            this.ProjectName = proj.ProjectName;
            this.WorkPackageCode = wp.WorkPackageCode;
            this.WorkPackageTitle = wp.Name;
            this.Contractor = wp.Contractor;
            this.IssueDate = wp.IssueDate;
            this.IsClosed = wp.IsClosed;
            this.ParentWorkPackageCode = parentWpCode;
            this.ResponsibleEngineer = re;
        }
    }

    public class PmPlanningViewModel
    {
        public int LabourGradeId { get; set; }
        public double? PmEAC { get; set; }
        public double? ReBudget { get; set; }

        public PmPlanningViewModel()
        {

        }

        public PmPlanningViewModel(WorkPackageLabourGradeAssignment param)
        {
            this.LabourGradeId = param.LabourGradeId;
            this.PmEAC = param.pmEAC;
            this.ReBudget = param.reBudget;
        }
    }
}
