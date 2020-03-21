using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace COMP4911WebAPI.ViewModels
{

    public class WorkPackageReportGetViewModel
    {
        public string WorkPackageName { get; set; }
        public int WorkPackageId { get; set; }
        public string WorkPackageCode { get; set; }
        public int ProjectId { get; set; }
        public int ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int WorkPackageReportId { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EmployeeReportViewModel ProjectManager { get; set; }
        public EmployeeReportViewModel ResponsibleEngineer { get; set; }
        public List<EmployeeReportViewModel> Engineers { get; set; }
        public string Comment { get; set; }
        public string WorkAccomplished { get; set; }
        public string WorkPlanned { get; set; }
        public string ProblemsThisPeriod { get; set; }
        public string ProblemsAnticipated { get; set; }
        public List<WorkPackageReportDetailsViewModel> Details { get; set; }

        public WorkPackageReportGetViewModel() 
        {

        }

        public WorkPackageReportGetViewModel(WorkPackageReport workPackageReport, 
            WorkPackage workPackage, Project project, Employee projectManager, 
            Employee responsibleEngineer, List<EmployeeReportViewModel> engineers, 
            List<WorkPackageReportDetailsViewModel> details)
        {
            this.WorkPackageName = workPackage.Name;
            this.WorkPackageId = workPackageReport.WorkPackageId;
            this.WorkPackageCode = workPackage.WorkPackageCode;
            this.ProjectId = workPackage.ProjectId;
            this.ProjectCode = project.ProjectCode;
            this.ProjectName = project.ProjectName;
            this.WorkPackageReportId = workPackageReport.WorkPackageReportId;
            this.ReportDate = workPackageReport.ReportDate;
            this.StartDate = workPackageReport.StartDate;
            this.EndDate = workPackageReport.EndDate;
            this.ProjectManager = new EmployeeReportViewModel(projectManager);
            this.ResponsibleEngineer = new EmployeeReportViewModel(responsibleEngineer);
            this.Engineers = engineers;
            this.Comment = workPackageReport.Comment;
            this.WorkAccomplished = workPackageReport.WorkAccomplished;
            this.WorkPlanned = workPackageReport.WorkPlanned;
            this.ProblemsThisPeriod = workPackageReport.ProblemsThisPeriod;
            this.ProblemsAnticipated = workPackageReport.ProblemsAnticipated;
            this.Details = details;
        }
    }

    public class EmployeeReportViewModel
    {
        public int EmployeeId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public LabourGradeViewModel LabourGrade { get; set; }

        public EmployeeReportViewModel(Employee employee)
        {
            this.EmployeeId = employee.EmployeeId;
            this.EmpFirstName = employee.EmployeeFirstName;
            this.EmpLastName = employee.EmployeeLastName;
            this.LabourGrade = new LabourGradeViewModel(employee.LabourGrade);
        }
    }

}
