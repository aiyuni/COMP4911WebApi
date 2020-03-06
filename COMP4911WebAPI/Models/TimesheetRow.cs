using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace COMP4911WebAPI.Models
{
    public class TimesheetRow
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimesheetRowId { get; set; }

        [Required]
        public int TimesheetId { get; set; }

        [Required]
        public int TimesheetVersionNumber { get; set; }

        [Required]
        public int WorkPackageId { get; set; }  //FK

        [Required]
        public double Monday { get; set; }

        [Required]
        public double Tuesday { get; set; }

        [Required]
        public double Wednesday { get; set; }

        [Required]
        public double Thursday { get; set; }

        [Required]
        public double Friday { get; set; }

        [Required]
        public double Saturday { get; set; }

        [Required]
        public double Sunday { get; set; }

        public string Notes { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public Timesheet Timesheet { get; set; }
        public WorkPackage WorkPackage { get; set; }

        public TimesheetRow()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        public TimesheetRow(TimesheetRowViewModel viewModel)
        {
            this.Monday = viewModel.Monday;
            this.Tuesday = viewModel.Tuesday;
            this.Wednesday = viewModel.Wednesday;
            this.Thursday = viewModel.Thursday;
            this.Friday = viewModel.Friday;
            this.Saturday = viewModel.Saturday;
            this.Sunday = viewModel.Sunday;
            this.Notes = viewModel.Notes;
            this.WorkPackageId = viewModel.WorkPackageId;
            this.TimesheetId = viewModel.TimesheetId;
            this.TimesheetVersionNumber = viewModel.TimesheetVersionNumber;
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

        //For seeding 
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
