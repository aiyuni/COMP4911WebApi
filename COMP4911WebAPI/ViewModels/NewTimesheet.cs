using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{
    public class NewTimesheet
    {
        public int TimesheetId { get; set; }
        public int VersionNumber { get; set; }

        public int EmployeeId { get; set; }

        public int WeekNumber { get; set; }
        public DateTime WeekEndingIn { get; set; }
        public string Status { get; set; }
        public string Signature { get; set; }

        public NewTimesheet()
        {

        }

        public NewTimesheet(Timesheet ts)
        {
            this.TimesheetId = ts.TimesheetId;
            this.VersionNumber = ts.VersionNumber;
            this.EmployeeId = ts.EmployeeId;
            this.WeekNumber = ts.WeekNumber;
            this.Status = ts.Status.ToString();
            //TimesheetStatus value;
            //Enum.TryParse <TimesheetStatus>(this.Status, out value);
            //this.Status = value.ToString();
            this.WeekNumber = WeekNumber;
            this.WeekEndingIn = WeekEndingIn;
        }
    }
}
