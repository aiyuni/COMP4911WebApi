using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using COMP4911WebAPI.ViewModels;
using Microsoft.AspNetCore.Internal;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetsController : ControllerBase
    {
        private readonly TimesheetRepository _timesheetRepository;
        private readonly IDataRepository<Employee> _employeeRepository;
        private readonly TimesheetRowRepository _timesheetRowRepository;

        private readonly CredentialRepository _credentialRepository;

        private readonly LabourGradeRepository _labourGradeRepository;
        private readonly WorkPackageRepository _workPackageRepository; //Perry: investigate if we can move this elsewhere?
        private readonly ProjectRepository _projectRepository; //likewise

        public TimesheetsController(IDataRepository<Timesheet> timesheetRepository, IDataRepository<Employee> employeeRepository,
            IDataRepository<TimesheetRow> timesheetRowRepository, IDataRepository<Credential> credentialRepository, IDataRepository<LabourGrade> labourGradeRepository, IDataRepository<WorkPackage> workPackageRepository,
            IDataRepository<Project> projectRepository)
        {
            this._timesheetRepository = (TimesheetRepository)timesheetRepository;
            this._employeeRepository = employeeRepository;
            this._timesheetRowRepository = (TimesheetRowRepository)timesheetRowRepository;
            this._credentialRepository = (CredentialRepository)credentialRepository;
            this._labourGradeRepository = (LabourGradeRepository)labourGradeRepository;
            this._workPackageRepository = (WorkPackageRepository)workPackageRepository;
            this._projectRepository = (ProjectRepository)projectRepository;
            
        }

        // GET: api/Timesheets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Timesheet>>> GetTimesheets()
        {
            List<TimesheetViewModel> tsList = new List<TimesheetViewModel>();
            foreach (Timesheet ts in await _timesheetRepository.GetAll())
            {
                tsList.Add(new TimesheetViewModel(await GetFullTimesheetDetails(ts)));
            }

            return Ok(tsList);
        }

        // We are using this one. Automatically goes to latest version.
        // GET: api/Timesheets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimesheetViewModel>> GetTimesheet(int id)
        {
            Debug.WriteLine("inside single param get...");
            //Timesheet ts = await(GetFullTimesheetDetails(await _timesheetRepository.Get(id)));
            TimesheetViewModel tsViewModel =
                await (GetFullTimesheetViewModelDetails(new TimesheetViewModel(await _timesheetRepository.Get(id))));
            return Ok(tsViewModel);
        }

        //NOT USED ANYMORE. Gets a specific version of a timesheet.
        // GET: api/Timesheets/5/2
        [HttpGet("{id}/{versionId}")]
        public async Task<ActionResult<TimesheetViewModel>> GetTimesheet(int id, int versionId)
        {
            Debug.WriteLine("inside multi param get.. version id is: " + versionId);
            Timesheet ts = await _timesheetRepository.Get(id, versionId);
            return Ok(new TimesheetViewModel(ts));
        }

        //Gets all timesheet respective to a particular user
        // GET: api/Timesheets/GetTimesheetsByEmpId/5
        [HttpGet("GetTimesheetsByEmpId/{id}")]
        public async Task<IActionResult> GetTimesheetsByEmployeeId(int id)
        {
            var timesheetList = await GetTimesheetByEmpIdHelper(id);

            List<TimesheetViewModel> timesheetListParam = new List<TimesheetViewModel>();

            foreach (Timesheet item in timesheetList)
            {
                TimesheetViewModel timesheetViewModel = new TimesheetViewModel(await (GetFullTimesheetDetails(item)));
                timesheetListParam.Add(timesheetViewModel);
            }

            return Ok(timesheetListParam);
            /*Employee emp = (await _employeeRepository.Get(id));
            int empCode = emp.EmployeeCode;
            
            return Ok(new EmployeeTimesheetListViewModel(id, empCode, timesheetListParam));
            */
        }

        //Gets all timesheets based on the approver
        // GET: api/Timesheets/GetTimesheetsByApproverId/2
        [HttpGet("GetTimesheetsByApproverId/{id}")]
        public async Task<IActionResult> GetTimesheetsByApproverId(int id)
        {   //Finds employee by EmployeeID
            var approver = await GetEmployeeByIdHelper(id);
            //Finds employees by ApproverID
            var employees = await GetEmployeeByApproverIdHelper(id);

            List<TimesheetApproverViewModel> timesheetApproverViews = new List<TimesheetApproverViewModel>();

            foreach (Employee item in employees)
            {
                //Null coalesce
                //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
                var supervisor = await GetEmployeeByIdHelper((item.SupervisorId ?? 0));
                var timesheets = await GetTimesheetByEmpIdHelper(item.EmployeeId);

                Credential empCred = (await _credentialRepository.GetAll()).FirstOrDefault(c => c.EmployeeId == item.EmployeeId);
                LabourGrade labourGrade = await _labourGradeRepository.Get(item.LabourGradeId);
                EmployeeDetailsViewModel thisEmployee = new EmployeeDetailsViewModel(item, empCred, new LabourGradeViewModel(labourGrade),
                    new EmployeeNameViewModel(approver.First()), new EmployeeNameViewModel(supervisor.First()));

                foreach (Timesheet timesheet in timesheets)
                {
                    TimesheetApproverViewModel timesheetApproverView = new TimesheetApproverViewModel(timesheet, thisEmployee);
                    timesheetApproverViews.Add(timesheetApproverView);
                }

            }

            return Ok(timesheetApproverViews);

        }



        [NonAction]
        public async Task<IEnumerable<Timesheet>> GetTimesheetByEmpIdHelper(int id)
        {
            return (await _timesheetRepository.GetAll()).Where(x => x.EmployeeId == id);
        }

        //Helper method to get employee details based on timesheet approver id
        [NonAction]
        public async Task<IEnumerable<Employee>> GetEmployeeByApproverIdHelper(int id)
        {
            return (await _employeeRepository.GetAll()).Where(x => x.TimesheetApproverId == id);
        }

        [NonAction]
        public async Task<IEnumerable<Employee>> GetEmployeeByIdHelper(int id)
        {
            return (await _employeeRepository.GetAll()).Where(x => x.EmployeeId == id);
        }


        //Get the next available timesheet id
        [HttpGet("availableTimesheetId")]
        public async Task<IActionResult> GetAvailableTimesheetId()
        {
            Timesheet ts = await _timesheetRepository.GetLastId();
            return Ok(new AvailableId(ts.TimesheetId + 1));
        }

        [HttpGet("pendingTimesheetsForApprover")]
        public async Task<IActionResult> GetAllPendingTimesheetsForApproverId(int id)
        {
            IEnumerable<Timesheet> timesheetList = await _timesheetRepository.GetAll();
            return Ok("in progress");
        }

        //This is only called when a timesheet is labelled as "In Progress".
        //Otherwise, frontend will call Post method instead.
        // PUT: api/Timesheets/5
        [HttpPut("{id}/{versionId}")]
        public async Task<IActionResult> PutTimesheet(int id, int versionId, TimesheetViewModel timesheetViewModel)
        {
            await _timesheetRepository.Update(new Timesheet(timesheetViewModel));

            //delete existing rows and then add, dont update
            var tsRows = (await _timesheetRowRepository.GetAll()).Where(t => t.TimesheetId == id && t.TimesheetVersionNumber == versionId);

            foreach (TimesheetRow item in tsRows)
            {
                await _timesheetRowRepository.Delete(item);
            }
            foreach (TimesheetRowViewModel item in timesheetViewModel.TimesheetRows)
            {
                await _timesheetRowRepository.Add(new TimesheetRow(item));
            }

            return Ok(timesheetViewModel);
        }

        // POST: api/Timesheets
        [HttpPost]
        public async Task<ActionResult<Timesheet>> PostTimesheet(TimesheetViewModel timesheetViewModel)
        {
            bool success = await _timesheetRepository.Add(new Timesheet(timesheetViewModel));
            if (!success)
            {
                return Ok("Error on adding timesheet...duplicate entry.");
            }
            foreach (TimesheetRowViewModel item in timesheetViewModel.TimesheetRows)
            {
                await _timesheetRowRepository.Add(new TimesheetRow(item));
            }
            return Ok(timesheetViewModel);
        }


        private bool TimesheetExists(int id)
        {
            return true;
        }

        [NonAction]
        public async Task<Timesheet> GetFullTimesheetDetails(Timesheet ts)
        {
            Employee emp = await _employeeRepository.Get(ts.EmployeeId);
            emp.Timesheets = null;
            ts.Employee = emp;

            var timesheetRows = (await _timesheetRowRepository.GetAll())
                .Where(t => t.TimesheetId == ts.TimesheetId && t.TimesheetVersionNumber == ts.VersionNumber);

            if (ts.TimesheetRows != null)
            {
                foreach (var tsTimesheetRow in ts.TimesheetRows)
                {
                    tsTimesheetRow.Timesheet = null;
                    WorkPackage wp = await _workPackageRepository.Get(tsTimesheetRow.WorkPackageId);
                    Project proj = await _projectRepository.Get(wp.ProjectId);
                    TimesheetRowViewModel tsRowViewModel = new TimesheetRowViewModel(tsTimesheetRow, proj, wp.WorkPackageCode);
                }
            }

            TimesheetViewModel tsViewModel = new TimesheetViewModel(ts);
            ts.TimesheetRows = timesheetRows.ToList();

            return ts;
        }

        [NonAction]
        public async Task<TimesheetViewModel> GetFullTimesheetViewModelDetails(TimesheetViewModel ts)
        {
            Employee emp = await _employeeRepository.Get(ts.EmployeeId);
            emp.Timesheets = null;

            var timesheetRows = (await _timesheetRowRepository.GetAll())
                .Where(t => t.TimesheetId == ts.TimesheetId && t.TimesheetVersionNumber == ts.VersionNumber);

            List<TimesheetRowViewModel> tsRowViewModelList = new List<TimesheetRowViewModel>();

            foreach (var tsTimesheetRow in timesheetRows)
            {
                // tsTimesheetRow.Timesheet = null;
                WorkPackage wp = await _workPackageRepository.Get(tsTimesheetRow.WorkPackageId);
                Project proj = await _projectRepository.Get(wp.ProjectId);
                TimesheetRowViewModel tsRowViewModel = new TimesheetRowViewModel(tsTimesheetRow, proj, wp.WorkPackageCode);
                tsRowViewModelList.Add(tsRowViewModel);
            }

            //if (ts.TimesheetRows != null)
            //{
            //    foreach (var tsTimesheetRow in ts.TimesheetRows)
            //    {
            //       // tsTimesheetRow.Timesheet = null;
            //        WorkPackage wp = await _workPackageRepository.Get(tsTimesheetRow.WorkPackageId);
            //        Project proj = await _projectRepository.Get(wp.ProjectId); 
            //        TimesheetRowViewModel tsRowViewModel = new TimesheetRowViewModel(new TimesheetRow(tsTimesheetRow), proj, wp.WorkPackageCode);
            //        tsRowViewModelList.Add(tsRowViewModel);
            //    }
            //}

            //TimesheetViewModel tsViewModel = new TimesheetViewModel(ts);
            ts.TimesheetRows = tsRowViewModelList;

            return ts;
        }
    }
}
