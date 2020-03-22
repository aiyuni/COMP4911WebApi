using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
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
        [Required]
        public int TimesheetId { get; set; }

        [Required]
        public int VersionNumber { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int WeekNumber { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime WeekEndingIn { get; set; }

        public double FlexTime { get; set; }

        public double OverTime { get; set; }

        public string Comment { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

        public TimesheetStatus Status { get; set; }
        public Employee Employee { get; set; }
        public IList<TimesheetRow> TimesheetRows { get; set; }

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

            this.Comment = ts.Comment;
            this.FlexTime = ts.FlexTime;
            this.OverTime = ts.OverTime;
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
            this.Comment = "seeded comment";
            this.OverTime = 1;
            this.FlexTime = 2;
        }
    }

}
