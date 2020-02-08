using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetRowsController : ControllerBase
    {
        private readonly IDataRepository<TimesheetRow> _timesheetRowRepository;

        public TimesheetRowsController(IDataRepository<TimesheetRow> timesheetRowRepository)
        {
            this._timesheetRowRepository = timesheetRowRepository;
        }

        // GET: api/TimesheetRows
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimesheetRow>>> GetTimesheetRows()
        {
           return Ok(await _timesheetRowRepository.GetAll());
        }

        // GET: api/TimesheetRows/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimesheetRow>> GetTimesheetRow(int id)
        {
            return null;
        }

        // PUT: api/TimesheetRows/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimesheetRow(int id, TimesheetRow timesheetRow)
        {
            return null;
        }

        // POST: api/TimesheetRows
        [HttpPost]
        public async Task<ActionResult<TimesheetRow>> PostTimesheetRow(TimesheetRow timesheetRow)
        {
            return null;
        }

        private bool TimesheetRowExists(int id)
        {
            return true;
        }
    }
}
