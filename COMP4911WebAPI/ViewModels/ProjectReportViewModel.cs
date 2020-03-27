using System;
using System.Collections.Generic;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    public class ProjectReportViewModel
    {
        //Data members for ProjectReportViewModel
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
        public const double HoursInDay = 8.0;


        //Constructor for ProjectReportViewModel
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

            //Inner class totals
            Totals totals = new Totals(LowWpStatus);

        }

        //Inner class LowWorkPackage
        public class LowWorkPackage
        {
            //Data members for LowWorkPackage
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

            //below data members not needed for frontend but needed for calculating dervived values
            public double LabourGradeWage { get; set; }
            public double TotalWpHours { get; set; }


            //Constructor for LowWorkPackage
            public LowWorkPackage(WorkPackageReportSnapshot workPackage)
            {
                //all workpackage fields in format we need them



            }
        }

        //Inner class HighWorkPackage
        public class HighWorkPackage
        {
            //Data members for HighWorkPackage
            public string workPackageCode { get; set; }
            public string workPackageName { get; set; } //workPackageTitle
            public double wpReBudget { get; set; } //workPackageResponsibleEngineerBudget
            public double wpActualSpends { get; set; } //WorkPackageActualSpends
            public double wpPmEAC { get; set; } //WorkPackageProjectManagerEstimateAtCompletion
            public double wpPmVariance { get; set; }
            public double wpPmCompletion { get; set; }
            public bool isClosed { get; set; }
            public string engineerInitials { get; set; }


            //Constructor for HighWorkPackage
            public HighWorkPackage(WorkPackageReportSnapshot workPackage)
            {

            }
        }

        //inner class Totals to hold the totals
        public class Totals
        {
            //Data members for Totals
            public double wpReBudget { get; set; } //workPackageResponsibleEngineerBudget
            public double wpActualSpends { get; set; } //WorkPackageActualSpends

            public double wpReEAC { get; set; } //WorkPackageResponsibleEngineerEstimateAtCompletion
            public double wpPmEAC { get; set; } //WorkPackageProjectManagerEstimateAtCompletion
            public double wpReVariance { get; set; } //workPackageResponsibleEngineerVariance
            public double wpPmVariance { get; set; } //workPackageProjectManagerVariance
            public double wpReCompletion { get; set; } //workPackageResponsibleEngineerCompletion
            public double wpPmCompletion { get; set; } //workPackageProjectManagerCompletion

            //Constructor for Totals
            public Totals(List<LowWorkPackage> lowWorkPackages)
            {
                this.wpReBudget = CalculateWpReBudget(lowWorkPackages);
                this.wpActualSpends = CalculateWpActualSpends(lowWorkPackages);
                this.wpReEAC = CalculateWpResponsibleEngineerEstimateAtCompletion(lowWorkPackages);
                this.wpPmEAC = CalculateWpProductManagerEstimateAtCompletion(lowWorkPackages);
                this.wpReVariance = CalculateReVariance();
                this.wpPmVariance = CalculatePmVariance();
                this.wpReCompletion = CalculateReCompletion();
                this.wpPmCompletion = CalculatePmCompletion();
            }

            //CalculateWpReBudget
            //Convert all ReBudget values to dollars
            //Add them to total
            //Return total
            //The formula for conversation of each Rebudget days to hours is ReBudget (which is in days) * labour grade wage * 8
            public double CalculateWpReBudget(List<LowWorkPackage> lowWorkPackages)
            {
                double totalReBudget = 0.0;

                foreach (LowWorkPackage lwp in lowWorkPackages)
                {

                    totalReBudget += lwp.wpReBudget * lwp.LabourGradeWage * HoursInDay;
                }

                return totalReBudget;
            }

            //CalculateWpActualSpends
            //summation of all the hours of each day in each timesheet, converted to $$$. 
            //The formula is hours * labour grade wage *. 
            public double CalculateWpActualSpends(List<LowWorkPackage> lowWorkPackages)
            {
                double actualSpends = 0.0;

                foreach (LowWorkPackage lwp in lowWorkPackages)
                {
                    actualSpends += lwp.TotalWpHours * lwp.LabourGradeWage;
                }

                return actualSpends;
            }

            //CalculateWpResponsibleEngineerEstimateAtCompletion
            //wpReEAC: summation of all the ReEAC (again, in days) values for each labour grade in the workpackage.  
            //Formula is days * labour grade wage * 8
            public double CalculateWpResponsibleEngineerEstimateAtCompletion(List<LowWorkPackage> lowWorkPackages)
            {
                double total = 0.0;

                foreach (LowWorkPackage lwp in lowWorkPackages)
                {
                    total += lwp.wpReEAC * lwp.LabourGradeWage * HoursInDay;
                }

                return total;
            }

            //CalculateWpProductManagerEstimateAtCompletion
            //wpReEAC: summation of all the PmEAC (again, in days) values for each labour grade in the workpackage.  
            //Formula is days * labour grade wage * 8
            public double CalculateWpProductManagerEstimateAtCompletion(List<LowWorkPackage> lowWorkPackages)
            {

                double total = 0.0;

                foreach (LowWorkPackage lwp in lowWorkPackages)
                {
                    total = lwp.wpPmEAC * lwp.LabourGradeWage * HoursInDay;
                }

                return total;
            }

            //CalculateReVariance
            //wpReVariance: a derived column using the above derived fields, the formula is (wpReEAC - wpReBudget) / wpReBudget
            public double CalculateReVariance()
            {
                double reVariance = 0.0;

                reVariance = (wpReEAC - wpReBudget) / wpReBudget;

                return reVariance;
            }

            //CalculatePmVariance
            //wpPmVariance: a derived column using the above derived fields, the formula is (wpPmEAC - wpPmBudget) / wpPmBudget
            public double CalculatePmVariance()
            {
                double pmVariance = (wpPmEAC - wpReBudget) / wpReBudget;
                return pmVariance;
            }

            //CalculateReCompletion
            //wpReCompletion: a derived column using the above derived fields, the formula is wpActualSpends/reEAC
            public double CalculateReCompletion()
            {
                double reCompletion = wpActualSpends / wpReEAC;
                return reCompletion;
            }


            //CalculatePmCompletion
            //wpPmCompletion: a derived column using the above derived fields, the formula is wpActualSpends/pmEAC
            public double CalculatePmCompletion()
            {
                double pmCompletion = wpActualSpends / wpPmEAC;
                return pmCompletion;
            }


        }
    }
}
