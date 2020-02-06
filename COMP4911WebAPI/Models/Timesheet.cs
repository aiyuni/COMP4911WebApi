using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Models
{
    public class Timesheet
    {
        public int TimesheetId { get; set; }
        public int VersionNumber { get; set; }

        public int EmployeeId { get; set; }

        public int WeekNumber { get; set; }
        public DateTime WeekEndingIn { get; set; }
        public TimesheetStatus Status { get; set; }
        public string Signature { get; set; }
        
        public Employee Employee { get; set; }
        public IList<TimesheetRow> TimesheetRows { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public Timesheet()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        public Timesheet(NewTimesheet ts)
        {
            this.TimesheetId = ts.TimesheetId;
            this.VersionNumber = ts.VersionNumber;
            this.EmployeeId = ts.EmployeeId;
            this.WeekNumber = ts.WeekNumber;
            this.WeekEndingIn = ts.WeekEndingIn;
            TimesheetStatus temp;
            Enum.TryParse(ts.Status, out temp);
            this.Status = temp;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }
    }

    public enum TimesheetStatus
    {
        InProgress, //0
        Pending,
        Approved,
        Rejected //3

    }
}
