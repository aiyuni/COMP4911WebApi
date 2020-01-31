using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class TimesheetRow
    {
        [Key]
        public int TimesheetRowId { get; set; }

        public int TimesheetId { get; set; }
        public int WorkPackageId { get; set; }
        //public int ProjectId { get; set; }  //remove this cuz employees who dont have wp cant have timesheetrows

        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public int Sunday { get; set; }

        public string Row_Lst_Upd_Uid { get; set; }
        public DateTime Row_Lst_Upd_Ts { get; set; }

        public Timesheet Timesheet { get; set; }
        public WorkPackage WorkPackage { get; set; }
        //public Project Project { get; set; }

    }
}
