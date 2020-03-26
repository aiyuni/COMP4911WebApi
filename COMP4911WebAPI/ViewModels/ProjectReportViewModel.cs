using System;
using System.Collections.Generic;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    public class ProjectReportViewModel
    {
        public int ProjectReportId { get; set; }

        public int ProjectId { get; set; }
        public int ProjectCode { get; set; }

        public string ProjectName { get; set; }
        public DateTime ReportDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public EmployeeNameViewModel ProjectManager { get; set; } //employees

        public List<EmployeeNameViewModel> Engineers { get; set; } //employees

        public List<LowWorkPackage> LowWpStatus { get; set; } //workpackagesnapshots

        public List<HighWorkPackage> HighWpStatus { get; set; } //workpackagesnapshots

        public const double HoursInDay =8.0;


        //takes in a projectreport record, 2x lists of employees, 2x lists of workpackagesnapshots, inner class totals
        public ProjectReportViewModel(ProjectReport projectReport, EmployeeNameViewModel projectManager,
        List<EmployeeNameViewModel> engineers, List<WorkPackageReportSnapshot> lowWpStatus, List<WorkPackageReportSnapshot> highWpStatus)
        {

            ProjectReportId = projectReport.ProjectReportId;
            ProjectId = projectReport.ProjectId;
            ProjectCode = projectReport.ProjectCode;
            ProjectName = projectReport.ProjectName;
            ReportDate = DateTime.Now;
            StartDate = projectReport.StartDate;
            EndDate = projectReport.EndDate;
            ProjectManager = projectManager;
            Engineers = engineers;

            foreach (WorkPackageReportSnapshot wp in lowWpStatus)
            {
                LowWpStatus.Add(new LowWorkPackage(wp));
            }

            foreach (WorkPackageReportSnapshot wp in highWpStatus)
            {
                HighWpStatus.Add(new HighWorkPackage(wp));
            }
            Totals totals = new Totals(LowWpStatus);

        }

        public class LowWorkPackage
        {

            public string workPackageCode { get; set; }
            public string workPackageName { get; set; } //workPackageTitle
            public double wpReBudget { get; set; } //workPackageResponsibleEngineerBudget
            public double wpActualSpends { get; set; } //WorkPackageActualSpends
            public double wpReEAC { get; set; } //WorkPackageResponsibleEngineerEstimateAtCompletion
            public double wpPmEAC { get; set; } //WorkPackageProjectManagerEstimateAtCompletion
            public double wpReVariance { get; set; }
            public double wpPmVariance { get; set; }
            public double wpReCompletion { get; set; }
            public double wpPmCompletion { get; set; }
            public bool isClosed { get; set; }
            public string engineerInitials { get; set; }

            public double LabourGradeWage { get; set; } //extra field not needed for front end but needed for calculating dervived values
            public LowWorkPackage(WorkPackageReportSnapshot workPackage)
            {
                //all workpackage fields in format we need them



            }
        }

        public class HighWorkPackage
        {
            public string workPackageCode { get; set; }
            public string workPackageName { get; set; } //workPackageTitle
            public double wpReBudget { get; set; } //workPackageResponsibleEngineerBudget
            public double wpActualSpends { get; set; } //WorkPackageActualSpends
            public double wpPmEAC { get; set; } //WorkPackageProjectManagerEstimateAtCompletion

            public double wpPmVariance { get; set; }
            public double wpPmCompletion { get; set; }
            public bool isClosed { get; set; }
            public string engineerInitials { get; set; }
            public HighWorkPackage(WorkPackageReportSnapshot workPackage)
            {

            }
        }

        //inner class Totals to hold the totals
        public class Totals
        {
            public double wpReBudget { get; set; } //workPackageResponsibleEngineerBudget
            public double wpActualSpends { get; set; } //WorkPackageActualSpends

            public double wpReEAC { get; set; } //WorkPackageResponsibleEngineerEstimateAtCompletion
            public double wpPmEAC { get; set; } //WorkPackageProjectManagerEstimateAtCompletion
            public double wpReVariance { get; set; } //workPackageResponsibleEngineerVariance
            public double wpPmVariance { get; set; } //workPackageProjectManagerVariance
            public double wpReCompletion { get; set; } //workPackageResponsibleEngineerCompletion
            public double wpPmCompletion { get; set; } //workPackageProjectManagerCompletion
            public Totals(List<LowWorkPackage> lowWorkPackages)
            {
                this.wpReBudget = CalculateWpReBudget(lowWorkPackages);
            }

            //CalculateWpReBudget
            //Convert all ReBudget values to dollars
            //Add them to total
            //Return total
            //The formula for conversation of each Rebudget days to hours is ReBudget (which is in days) * labour grade wage * 8
            public double CalculateWpReBudget(List<LowWorkPackage> lowWorkPackages)
            {
                double totalReBudget = 0.0;
                foreach(LowWorkPackage lwp in lowWorkPackages){

                    totalReBudget += lwp.wpReBudget * lwp.LabourGradeWage * HoursInDay; 
                }
                return totalReBudget;
            }


            // public double CalculateWpActualSpends(List<LowWorkPackage> lowWorkPackages){

            // }

            // public double CalculateWpReEAC(List<LowWorkPackage> lowWorkPackages){

            // }

            // public double CalculateWpPmEAC(List<LowWorkPackage> lowWorkPackages){

            // }

            // public double CalculateReVariance(List<LowWorkPackage> lowWorkPackages){
                
            // }

            // public double CalculatePmVariance(List<LowWorkPackage> lowWorkPackages){
                
            // }

            // public double CalculateReCompletion(List<LowWorkPackage> lowWorkPackages){
                
            // }

            // public double CalculatePmCompletion(List<LowWorkPackage> lowWorkPackages){
                
            // }


        }
    }
}
