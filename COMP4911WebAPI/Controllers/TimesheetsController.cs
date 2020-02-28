using System;
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

        public TimesheetsController(IDataRepository<Timesheet> timesheetRepository, IDataRepository<Employee> employeeRepository,
            IDataRepository<TimesheetRow> timesheetRowRepository)
        {
            this._timesheetRepository = (TimesheetRepository) timesheetRepository;
            this._employeeRepository = employeeRepository;
            this._timesheetRowRepository = (TimesheetRowRepository)timesheetRowRepository;
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

        // Not Used for now.
        // GET: api/Timesheets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Timesheet>> GetTimesheet(int id)
        {
            Debug.WriteLine("inside single param get..." );
            Timesheet ts = await(GetFullTimesheetDetails(await _timesheetRepository.Get(id)));
            return Ok(new TimesheetViewModel(ts));
        }

        //Gets a specific version of a timesheet 
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
            var timesheetList = (await _timesheetRepository.GetAll()).Where(x => x.EmployeeId == id);

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
            foreach (TimesheetRow item in timesheetViewModel.TimesheetRows)
            {
                await _timesheetRowRepository.Add(item);
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
            foreach (TimesheetRow item in timesheetViewModel.TimesheetRows)
            {
                await _timesheetRowRepository.Add(item);
            }
            return Ok(timesheetViewModel);
        }

        
        private bool TimesheetExists(int id)
        {
            return true;
        }


        private async Task<Timesheet> GetFullTimesheetDetails(Timesheet ts)
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
                }
            }

            ts.TimesheetRows = timesheetRows.ToList();

            return ts;
        }
    }
}
