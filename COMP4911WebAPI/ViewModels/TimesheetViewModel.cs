using COMP4911WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using COMP4911WebAPI.Controllers;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace COMP4911WebAPI.ViewModels
{
    /** Model to represent a timesheet */
    public class TimesheetViewModel
    {
        public int TimesheetId { get; set; }
        public int VersionNumber { get; set; }

        public int EmployeeId { get; set; }
        public int WeekNumber { get; set; }
        public DateTime WeekEndingIn { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string Signature { get; set; }  //not part of model for now
        public double OverTime { get; set; }
        public double FlexTime { get; set; }

        public List<TimesheetRowViewModel> TimesheetRows { get; set; }

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
            this.WeekNumber = ts.WeekNumber;
            this.WeekEndingIn = ts.WeekEndingIn;
            this.OverTime = ts.OverTime;
            this.FlexTime = ts.FlexTime;

            List<TimesheetRowViewModel> tsRowModelList = new List<TimesheetRowViewModel>();

            try
            {
                foreach (TimesheetRow tsRow in ts.TimesheetRows)
                {
                    tsRowModelList.Add(new TimesheetRowViewModel(tsRow));
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("catching and resuming...");
            }

            //doesnt work now...
            //foreach (TimesheetRow tsRow in ts.TimesheetRows)
            //{
            //    tsRowModelList.Add(new TimesheetRowViewModel(tsRow));
            //}

            this.TimesheetRows = tsRowModelList;  //rename timesheetRows to timesheetRowViewModels

            this.Comment = ts.Comment;
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
