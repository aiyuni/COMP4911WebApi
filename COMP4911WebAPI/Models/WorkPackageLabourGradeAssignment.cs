using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Models
{
    public class WorkPackageLabourGradeAssignment
    {
        public int WorkPackageId { get; set; }
        public int LabourGradeId { get; set; }
        public double? pmEAC { get; set; }
        public double? reBudget { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public WorkPackage WorkPackage { get; set; }
        public LabourGrade LabourGrade { get; set; }

        public WorkPackageLabourGradeAssignment()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = System.Environment.UserName;
        }

        public WorkPackageLabourGradeAssignment(int wpId, PmPlanningViewModel pmViewModel)
        {
            this.WorkPackageId = wpId;
            this.LabourGradeId = pmViewModel.LabourGradeId;
            this.pmEAC = pmViewModel.PmEAC;
            this.reBudget = pmViewModel.ReBudget;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = System.Environment.UserName;
        }

        //Seeding
        public WorkPackageLabourGradeAssignment(int wpId, int lgId, double eac, double reBudget)
        {
            this.WorkPackageId = wpId;
            this.LabourGradeId = lgId;
            this.pmEAC = eac;
            this.reBudget = reBudget;

            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = "seeded";
        }

    }
}
