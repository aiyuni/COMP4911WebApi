using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace COMP4911WebAPI.Models
{
    public class TimesheetRow
    {
        [Key]
        public int TimesheetRowId { get; set; }

        public int TimesheetId { get; set; }
        public int TimesheetVersionNumber { get; set; }

        public int WorkPackageId { get; set; }  //FK

        public double Monday { get; set; }
        public double Tuesday { get; set; }
        public double Wednesday { get; set; }
        public double Thursday { get; set; }
        public double Friday { get; set; }
        public double Saturday { get; set; }
        public double Sunday { get; set; }
        public string Notes { get; set; }

        public Timesheet Timesheet { get; set; }
        public WorkPackage WorkPackage { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public TimesheetRow()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        public TimesheetRow(int timesheetId, int tsVersion, int wpId, double mon, double tues,
            double wed, double thurs, double fri, double sat, double sun, string notes)
        {
            this.TimesheetId = timesheetId;
            this.TimesheetVersionNumber = tsVersion;
            this.WorkPackageId = wpId;
            this.Monday = mon;
            this.Tuesday = tues;
            this.Wednesday = wed;
            this.Thursday = thurs;
            this.Friday = fri;
            this.Saturday = sat;
            this.Sunday = sun;
            this.Notes = notes;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        //For seeding directly
        public TimesheetRow(int rowId, int timesheetId, int tsVersion, int wpId, double mon, double tues,
            double wed, double thurs, double fri, double sat, double sun, string notes)
        {
            this.TimesheetRowId = rowId;
            this.TimesheetId = timesheetId;
            this.TimesheetVersionNumber = tsVersion;
            this.WorkPackageId = wpId;
            this.Monday = mon;
            this.Tuesday = tues;
            this.Wednesday = wed;
            this.Thursday = thurs;
            this.Friday = fri;
            this.Saturday = sat;
            this.Sunday = sun;
            this.Notes = notes;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = "Seeded";
        }

    }
}
