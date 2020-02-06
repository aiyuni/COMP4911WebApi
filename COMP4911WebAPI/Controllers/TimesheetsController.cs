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

        public TimesheetsController(IDataRepository<Timesheet> timesheetRepository, IDataRepository<Employee> employeeRepository)
        {
            this._timesheetRepository = (TimesheetRepository) timesheetRepository;
            this._employeeRepository = employeeRepository;
        }

        // GET: api/Timesheets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Timesheet>>> GetTimesheets()
        {
            List<NewTimesheet> tsList = new List<NewTimesheet>();
            foreach (Timesheet ts in await _timesheetRepository.GetAll())
            {
                tsList.Add(new NewTimesheet(await GetFullTimesheetDetails(ts)));
            }

            return Ok(tsList);
        }

        // GET: api/Timesheets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Timesheet>> GetTimesheet(int id)
        {
            Debug.WriteLine("inside single param get..." );
            Timesheet ts = await(GetFullTimesheetDetails(await _timesheetRepository.Get(id)));
            return Ok(new NewTimesheet(ts));
        }

        // GET: api/Timesheets/5/2
        [HttpGet("{id}/{versionId}")]
        public async Task<ActionResult<NewTimesheet>> GetTimesheet(int id, int versionId)
        {
            Debug.WriteLine("inside multi param get.. version id is: " + versionId);
            Timesheet ts = await _timesheetRepository.Get(id, versionId);
            return Ok(new NewTimesheet(ts));
        }

        // PUT: api/Timesheets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimesheet(int id, Timesheet timesheet)
        {
            //frontend handles 'put' by calling post.
            return NoContent();
        }

        // POST: api/Timesheets
        [HttpPost]
        public async Task<ActionResult<Timesheet>> PostTimesheet(NewTimesheet newTimesheet)
        { 
            await _timesheetRepository.Add(new Timesheet(newTimesheet));
            return Ok(newTimesheet);
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

            //implement timesheetrows here

            return ts;
        }
    }
}
