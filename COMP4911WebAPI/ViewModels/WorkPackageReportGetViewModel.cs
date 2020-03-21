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
        public String WorkPackageName { get; set; }
        public int WorkPackageId { get; set; }
        public String WorkPackageCode { get; set; }
        public int ProjectId { get; set; }
        public String ProjectName { get; set; }
        public int WorkPackageReportId { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EmployeeReportViewModel ProjectManager { get; set; }
        public EmployeeReportViewModel ResponsibleEngineer { get; set; }
        public List<EmployeeReportViewModel> Engineers { get; set; }
        public String Comment { get; set; }
        public String WorkAccomplished { get; set; }
        public String WorkPlanned { get; set; }
        public String ProblemsThisPeriod { get; set; }
        public String ProblemsAnticipated { get; set; }
        public List<WorkPackageReportDetailsViewModel> Details { get; set; }

        public WorkPackageReportGetViewModel() 
        {

        }

        public WorkPackageReportGetViewModel(WorkPackageReport _workPackageReport, 
            WorkPackage _workPackage, Project _project, Employee _projectManager, 
            Employee _responsibleEngineer, List<EmployeeReportViewModel> _engineers, 
            List<WorkPackageReportDetailsViewModel> _details)
        {
            this.WorkPackageName = _workPackage.Name;
            this.WorkPackageId = _workPackageReport.WorkPackageId;
            this.WorkPackageCode = _workPackage.WorkPackageCode;
            this.ProjectId = _workPackage.ProjectId;
            this.ProjectName = _project.ProjectName;
            this.WorkPackageReportId = _workPackageReport.WorkPackageReportId;
            this.ReportDate = _workPackageReport.ReportDate;
            this.StartDate = _workPackageReport.StartDate;
            this.EndDate = _workPackageReport.EndDate;
            this.ProjectManager = new EmployeeReportViewModel(_projectManager);
            this.ResponsibleEngineer = new EmployeeReportViewModel(_responsibleEngineer);
            this.Engineers = _engineers;
            this.Comment = _workPackageReport.Comment;
            this.WorkAccomplished = _workPackageReport.WorkAccomplished;
            this.WorkPlanned = _workPackageReport.WorkPlanned;
            this.ProblemsThisPeriod = _workPackageReport.ProblemsThisPeriod;
            this.ProblemsAnticipated = _workPackageReport.ProblemsAnticipated;
            this.Details = _details;
        }
    }

    public class EmployeeReportViewModel
    {
        public int EmployeeId { get; set; }
        public String EmpFirstName { get; set; }
        public String EmpLastName { get; set; }
        public LabourGradeViewModel LabourGrade { get; set; }

        public EmployeeReportViewModel(Employee _employee)
        {
            this.EmployeeId = _employee.EmployeeId;
            this.EmpFirstName = _employee.EmployeeFirstName;
            this.EmpLastName = _employee.EmployeeLastName;
            this.LabourGrade = new LabourGradeViewModel(_employee.LabourGrade);
        }
    }

}
