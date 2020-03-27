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
        public string WorkPackageTitle { get; set; }
        public double WorkPackageResponsibleEngineerBudget { get; set; } //wpReBudget
        public double WorkPackageActualSpends { get; set; }
        public double WorkPackageResponsibleEngineerEstimateAtCompletion { get; set; }
        public double WorkPackageProjectManagerEstimateAtCompletion { get; set; }
        public double LabourGradeWage { get; set; }
        public bool IsHighWorkPackage { get; set; } //whether or not the work package is high or low
        public DateTime WorkPackageReportSnapshotDate { get; set; }
        public double TotalWpHours { get; set; }

        //Constructor for WorkPackageReportSnapshot
        public WorkPackageReportSnapshot(){

            WorkPackageReportSnapshotDate = DateTime.Now;
        }
        
    }
}