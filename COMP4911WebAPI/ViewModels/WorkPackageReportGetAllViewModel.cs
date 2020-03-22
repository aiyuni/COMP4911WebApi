using System;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    public class WorkPackageReportGetAllViewModel
    {

        public DateTime ReportDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkPackageReportId { get; set; }
        public WorkPackageReportGetAllViewModel(WorkPackageReport wpr) {
            this.ReportDate = wpr.ReportDate;
            this.StartDate = wpr.StartDate;
            this.EndDate = wpr.EndDate;
            this.WorkPackageReportId = wpr.WorkPackageReportId;
        }
        
    }
}