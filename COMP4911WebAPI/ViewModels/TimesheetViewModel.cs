using COMP4911WebAPI.Models;
using System;
using System.Collections.Generic;
using COMP4911WebAPI.Controllers;

namespace COMP4911WebAPI.ViewModels
{
    /// <summary>
    /// Timesheet view
    /// </summary>
    public class TimesheetViewModel
    {
        public int TimesheetId { get; set; }
        public int VersionNumber { get; set; }

        public int EmployeeId { get; set; }
        public int WeekNumber { get; set; }
        public DateTime WeekEndingIn { get; set; }
        public string Status { get; set; }
        public string Signature { get; set; }  //not part of model for now

        public List<TimesheetRow> TimesheetRows { get; set; }

        public TimesheetViewModel()
        {

        }

        public TimesheetViewModel(Timesheet ts)
        {
            this.TimesheetId = ts.TimesheetId;
            this.VersionNumber = ts.VersionNumber;
            this.EmployeeId = ts.EmployeeId;
            this.WeekNumber = ts.WeekNumber;
            this.Status = ts.Status.ToString();
            this.WeekNumber = WeekNumber;
            this.WeekEndingIn = WeekEndingIn;
        }

        public TimesheetViewModel(int timesheetId, int versionNumber, int employeeId, string status)
        {
            TimesheetId = timesheetId;
            VersionNumber = versionNumber;
            EmployeeId = employeeId;
            Status = status;
        }
    }
}
