using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace COMP4911WebAPI.ViewModels
{
    public class WorkPackageReportViewModel
    {
        public string WorkPackageCode { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }
        public string WorkAccomplished { get; set; }
        public string WorkPlanned { get; set; }
        public string ProblemsThisPeriod { get; set; }
        public string ProblemsAnticipated { get; set; }
        public List<WorkPackageReportDetailsViewModel> Details { get; set; }

    }

    public class WorkPackageReportDetailsViewModel
    {
        public int LabourGradeId { get; set; }
        public string LabourGradeName { get; set; }
        public double ReBudgetDay { get; set; }
        public double TotalDays { get; set; }
        public double ReETC { get; set; }
        public double ReEAC { get; set; }
        public double Variance { get; set; }
        public double Complete { get; set; }

        public WorkPackageReportDetailsViewModel()
        {

        }

        public WorkPackageReportDetailsViewModel(WorkPackageReportDetails _workPackageReportDetails)
        {
            this.LabourGradeId = _workPackageReportDetails.LabourGradeId;
            this.LabourGradeName = _workPackageReportDetails.LabourGradeName;
            this.ReBudgetDay = _workPackageReportDetails.ResponsibleEngineerBudgetInDays;
            this.TotalDays = _workPackageReportDetails.TotalDays;
            this.ReETC = _workPackageReportDetails.ReEstimateToCompletion;
            this.ReEAC = _workPackageReportDetails.ReEstimateAtCompletion;
            this.Variance = _workPackageReportDetails.VariancePercent;
            this.Complete = _workPackageReportDetails.CompletionPercent;
        }
    }
}
