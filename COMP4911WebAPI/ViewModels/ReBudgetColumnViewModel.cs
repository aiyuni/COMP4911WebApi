using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    public class ReBudgetColumnViewModel
    {
        public double reBudget { get; set; }

        public ReBudgetColumnViewModel(double value)
        {
            this.reBudget = value;
        }
    }
}
