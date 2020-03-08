using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    public class WorkPackageViewModel
    {
        public int WorkPackageId { get; set; }
        public string WorkPackageCode { get; set; }
        public string WorkPackageTitle { get; set; }


        public WorkPackageViewModel(int workPackageId, string workPackageCode, string workPackageTitle)
        {
            WorkPackageId = workPackageId;
            WorkPackageCode = workPackageCode;
            WorkPackageTitle = workPackageTitle;
        }
    }
}
