using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Models
{
    public class WorkPackageReportDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkPackageReportDetailsId { get; set; } //internal use

        [Required]
        public int WorkPackageReportId { get; set; } 

        [Required]
        public int LabourGradeId { get; set; } //this is not a relation

        public string LabourGradeName { get; set; }
        public double ResponsibleEngineerBudgetInDays { get; set; }

        public double TotalDays { get; set; }

        public double ReEstimateAtCompletion { get; set; } //reEAC

        public double ReEstimateToCompletion { get; set; } //reETC

        public double VariancePercent { get; set; }

        public double CompletionPercent { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public WorkPackageReport WorkPackageReport { get; set; }

        public WorkPackageReportDetails(){}

        public WorkPackageReportDetails(WorkPackageReportDetailsViewModel viewModel, int wpId)
        {
            this.LabourGradeId = viewModel.LabourGradeId;
            this.WorkPackageReportId = wpId;
            this.LabourGradeName = viewModel.LabourGradeName;
            this.ResponsibleEngineerBudgetInDays = viewModel.ReBudgetDay;
            this.TotalDays = viewModel.TotalDays;
            this.ReEstimateAtCompletion = viewModel.ReEAC;
            this.ReEstimateToCompletion = viewModel.ReETC;
            this.VariancePercent = viewModel.Variance;
            this.CompletionPercent = viewModel.Complete;
            this.LastUpdatedBy = Environment.UserName;
            this.LastUpdatedTime = DateTime.Now;

        }

        //For seeding
        public WorkPackageReportDetails(int id, int reportId, int labourGradeId, string laboutGradeName,
            double reBudgetInDays, double reETC, double reEAC, double totalDays, double variance, double completion)
        {
            this.WorkPackageReportDetailsId = id;
            this.WorkPackageReportId = reportId;
            this.LabourGradeId = labourGradeId;
            this.LabourGradeName = laboutGradeName;
            this.ResponsibleEngineerBudgetInDays = reBudgetInDays;
            this.ReEstimateAtCompletion = reEAC;
            this.ReEstimateToCompletion = reETC;
            this.TotalDays = totalDays;
            this.VariancePercent = variance;
            this.CompletionPercent = completion;
            this.LastUpdatedBy = "seeded";
            this.LastUpdatedTime = DateTime.Now;
        }
    }
}
