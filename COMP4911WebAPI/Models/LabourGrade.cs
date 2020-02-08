using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Models
{
    public class LabourGrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LabourGradeId { get; set; }

        public string LabourGradeCode { get; set; }
        public double Multiplier { get; set; }

        public IList<Employee> Employee { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public LabourGrade()
        {

        }

        //For seeding
        public LabourGrade(int id, string code, double multiplier)
        {
            this.LabourGradeId = id;
            this.LabourGradeCode = code;
            this.Multiplier = multiplier;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = "seeded";
        }
    }
}
