using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    public class TimesheetRowViewModel
    {
        public int TimesheetRowId { get; set; }

        public int TimesheetId { get; set; }

        public int TimesheetVersionNumber { get; set; }
        public int WorkPackageId { get; set; }  
        public string WorkPackageCode { get; set; }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public double Monday { get; set; }

        public double Tuesday { get; set; }
        public double Wednesday { get; set; }

        public double Thursday { get; set; }
        public double Friday { get; set; }
        public double Saturday { get; set; }
        public double Sunday { get; set; }

        public string Notes { get; set; }

        public TimesheetRowViewModel()
        {

        }

        public TimesheetRowViewModel(TimesheetRow tsRow, Project proj, string wpCode)
        {
            this.ProjectId = proj.ProjectId;
            this.ProjectName = proj.ProjectName;

            this.Friday = tsRow.Friday;
            this.Thursday = tsRow.Thursday;
            this.Wednesday = tsRow.Wednesday;
            this.Tuesday = tsRow.Tuesday;
            this.Monday = tsRow.Monday;
            this.Saturday = tsRow.Saturday;
            this.Sunday = tsRow.Sunday;
            this.Notes = Notes;

            this.TimesheetId = tsRow.TimesheetId;
            this.TimesheetVersionNumber = tsRow.TimesheetVersionNumber;

            this.WorkPackageId = tsRow.WorkPackageId;
            this.WorkPackageCode = wpCode;
        }

        //Constructor that converts tsRow to tsRowViewModel directly
        public TimesheetRowViewModel(TimesheetRow tsRow)
        {
            this.Friday = tsRow.Friday;
            this.Thursday = tsRow.Thursday;
            this.Wednesday = tsRow.Wednesday;
            this.Tuesday = tsRow.Tuesday;
            this.Monday = tsRow.Monday;
            this.Saturday = tsRow.Saturday;
            this.Sunday = tsRow.Sunday;
            this.Notes = Notes;

            this.TimesheetId = tsRow.TimesheetId;
            this.TimesheetVersionNumber = tsRow.TimesheetVersionNumber;

            this.WorkPackageId = tsRow.WorkPackageId;
        }
    }
}
