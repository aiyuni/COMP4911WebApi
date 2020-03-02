using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    public class TotalDaysViewModel
    {
        public double TotalDays { get; set; }

        public TotalDaysViewModel(double days)
        {
            this.TotalDays = Math.Round(days, 2);
        }
    }
}
