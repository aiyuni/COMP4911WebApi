using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.Helpers
{
    public static class HelperMethods
    {
        /**We assume date is a Monday, and we want the Friday */
        public static DateTime GetWeekEndingIn(DateTime date)
        {
            Debug.WriteLine("extension method start date of friday is: " + date.AddDays(5));
            return date.AddDays(5);
        }

        public static double SumTotalHoursOfTimesheetRow(TimesheetRow row)
        {
            return row.Monday + row.Tuesday + row.Wednesday + row.Thursday + row.Friday + row.Saturday + row.Saturday;
        }
    }
}
