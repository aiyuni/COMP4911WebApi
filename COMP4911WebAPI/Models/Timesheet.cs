using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.ViewModels;

namespace COMP4911WebAPI.Models
{
    public enum TimesheetStatus
    {
        InProgress, //0
        Pending,
        Approved,
        Rejected //3

    }

    public class Timesheet
    {
        //not auto-increment because composite PK! 
        public int TimesheetId { get; set; }
        public int VersionNumber { get; set; }

        public int EmployeeId { get; set; }

        public int WeekNumber { get; set; }
        public DateTime WeekEndingIn { get; set; }
        public TimesheetStatus Status { get; set; }

        public Employee Employee { get; set; }
        public IList<TimesheetRow> TimesheetRows { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public Timesheet()
        {
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        public Timesheet(TimesheetViewModel ts)
        {
            this.TimesheetId = ts.TimesheetId;
            this.VersionNumber = ts.VersionNumber;
            this.EmployeeId = ts.EmployeeId;
            this.WeekNumber = ts.WeekNumber;
            this.WeekEndingIn = ts.WeekEndingIn;
            TimesheetStatus temp;
            Enum.TryParse(ts.Status, out temp);
            this.Status = temp;
           // this.TimesheetRows = ts.TimesheetRows;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = Environment.UserName.ToString();
        }

        //For seeding
        public Timesheet(int id, int version, int empId, int weekNumber, DateTime weekEndingIn, TimesheetStatus status)
        {
            this.TimesheetId = id;
            this.VersionNumber = version;
            this.EmployeeId = empId;
            this.WeekNumber = weekNumber;
            this.WeekEndingIn = weekEndingIn;
            this.Status = status;
            this.LastUpdatedTime = DateTime.Now;
            this.LastUpdatedBy = "Seeded";
        }
    }

}
