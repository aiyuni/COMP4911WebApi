using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    public class LabourGradeViewModel
    {
        public int LabourGradeId { get; set; }
        public string LabourGradeName { get; set; }

        public LabourGradeViewModel(LabourGrade lg)
        {
            this.LabourGradeId = lg.LabourGradeId;
            this.LabourGradeName = lg.LabourGradeCode;
        }
    }
}
