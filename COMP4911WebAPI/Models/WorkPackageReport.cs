using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Models
{
    public class WorkPackageReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkPackageReportId { get; set; } //internal use.  

        [Required]
        public int WorkPackageId { get; set; }

        [Required]
        public DateTime ReportDate { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string Comment { get; set; }
        public string WorkAccomplished { get; set; } //description
        public string WorkPlanned { get; set; }
        public string ProblemsThisPeriod { get; set; }
        public string ProblemsAnticipated { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public WorkPackage WorkPackage { get; set; }
        public IList<WorkPackageReportDetails> WorkPackageReportDetails { get; set; }

        public WorkPackageReport()
        {
        }

        public WorkPackageReport(WorkPackageReportViewModel viewModel, int wpId)
        {
            this.WorkPackageId = wpId;
            this.ProblemsAnticipated = viewModel.ProblemsAnticipated;
            this.ProblemsThisPeriod = viewModel.ProblemsAnticipated;
            this.WorkPlanned = viewModel.WorkPlanned;
            this.WorkAccomplished = viewModel.WorkAccomplished;
            this.StartDate = viewModel.StartDate;
            this.EndDate = viewModel.EndDate;
            this.ReportDate = viewModel.ReportDate;
            this.Comment = viewModel.Comment;
            this.LastUpdatedBy = System.Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;
        }

        //For seeding
        public WorkPackageReport(int id, int workPackageId, DateTime reportDate, DateTime startDate, DateTime endDate, string comment,
            string workAccomplished, string workPlanned, string problemsThisPeriod, string problemsAnticipated)
        {
            this.WorkPackageReportId = id;
            this.WorkPackageId = workPackageId;
            this.ReportDate = reportDate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Comment = comment;
            this.WorkAccomplished = workAccomplished;
            this.WorkPlanned = workPlanned;
            this.ProblemsThisPeriod = problemsThisPeriod;
            this.ProblemsAnticipated = problemsAnticipated;
            this.LastUpdatedBy = "seeded";
            this.LastUpdatedTime = DateTime.Now;
        }
    }

}
