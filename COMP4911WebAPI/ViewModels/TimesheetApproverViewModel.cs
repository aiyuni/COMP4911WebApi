using COMP4911WebAPI.Models;

namespace COMP4911WebAPI.ViewModels
{

    //View model for GetAllTimesheetsByApproverId
    public class TimesheetApproverViewModel : TimesheetViewModel
    {

        //Data member
        //Owner as an EmployeeDetailsViewModel
        public EmployeeDetailsViewModel owner;

        //Constructor
        public TimesheetApproverViewModel(Timesheet timesheet, EmployeeDetailsViewModel owner) : base(timesheet)
        {
            
            this.owner = owner;
        }
    }
}