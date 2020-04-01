using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP4911WebAPI.Models
{
    public class WorkPackageReportSnapshot
    {
        //A snapshot of the work package data at the time the report is run 
        //the purpose is to allow historical reports to be run again even if details on work
        //packages change later 

        [Key]
        public int WorkPackageReportSnapshotId { get; set; }
        public int WorkPackageId { get; set; }
        public int ProjectReportId { get; set; }
        public string WorkPackageCode { get; set; }
        public string WorkPackageTitle { get; set; } //workPackageName
        public double WorkPackageResponsibleEngineerBudget { get; set; } //wpReBudget
        public double WorkPackageActualSpends { get; set; }
        public double WorkPackageResponsibleEngineerEstimateAtCompletion { get; set; }
        public double WorkPackageProjectManagerEstimateAtCompletion { get; set; }
        public double LabourGradeWage { get; set; }
        public bool IsHighWorkPackage { get; set; } //whether or not the work package is high or low
        public DateTime WorkPackageReportSnapshotDate { get; set; }
        public double TotalWpHours { get; set; }
        public double wpReVariance { get; set; }
        public double wpPmVariance { get; set; }
        public double wpReCompletion { get; set; }
        public double wpPmCompletion { get; set; }
        public bool isClosed { get; set; }
        public string engineerInitials { get; set; }
        public const double HoursInDay = 8.0;

        //Constructor for WorkPackageReportSnapshot
        public WorkPackageReportSnapshot()
        {

            WorkPackageReportSnapshotDate = DateTime.Now;
        }

        // //CalculateWpResponsibleEngineerEstimateAtCompletion
        // //wpReEAC: summation of all the ReEAC (again, in days) values for each labour grade in the workpackage.  
        // //Formula is days * labour grade wage * 8
        // public double CalculateWpResponsibleEngineerEstimateAtCompletion(List<WorkPackage> workPackages)
        // {
        //     double total = 0.0;

        //     foreach (WorkPackage lwp in lowWorkPackages)
        //     {
        //         total += lwp.wpReEAC * lwp.LabourGradeWage * HoursInDay;
        //     }

        //     return total;
        // }

    }
}