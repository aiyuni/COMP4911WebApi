using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using COMP4911WebAPI.ViewModels;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkPackageReportsController : ControllerBase
    {
        private readonly IDataRepository<WorkPackageReport> _workPackageReportRepository;
        private readonly IDataRepository<WorkPackageReportDetails> _workPackageReportDetailsRepository;
        private readonly IDataRepository<WorkPackage> _workPackageRepository;

        public WorkPackageReportsController(IDataRepository<WorkPackageReport> workPackageReportRepository, 
            IDataRepository<WorkPackageReportDetails> workPackageReportDetailsRepository,
            IDataRepository<WorkPackage> workPackageRepository)
        {
            this._workPackageReportRepository = workPackageReportRepository;
            this._workPackageReportDetailsRepository = workPackageReportDetailsRepository;
            this._workPackageRepository = workPackageRepository;
        }

        // GET: api/WorkPackageReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkPackageReport>>> GetWorkPackageReports()
        {
            return (await _workPackageReportRepository.GetAll()).ToList();
        }

        // GET: api/WorkPackageReports/5
        //INPROGRESS - need to create a new viewmodel for get as its different from post. Or look into reusing current model?
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkPackageReport>> GetWorkPackageReport(string id)
        {
            try
            {
                int wpId = (await _workPackageRepository.GetAll()).FirstOrDefault(w => w.WorkPackageCode.Equals(id))
                    .WorkPackageId;
                var workPackageReport = await _workPackageReportRepository.Get(wpId);

                if (workPackageReport == null)
                {
                    return NotFound();
                }

                return workPackageReport;
            }
            catch (NullReferenceException e)
            {
                return Ok(new Exception("Null pointer: WorkPackageview's wp code might not exist in database. " +
                                        "Cannot get ID for wp code."));
            }
            catch (Exception e)
            {
                return Ok(new Exception("Something went wrong trying to get the workpackage Report of id: " + id +
                                        ". Error msg: " + e.ToString()));
            }
        }

        // PUT: api/WorkPackageReports/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkPackageReport(int id, WorkPackageReport workPackageReport)
        {
            if (id != workPackageReport.WorkPackageReportId)
            {
                return BadRequest("Passed in ID does not match WorkPackage ID.");
            }

            await _workPackageReportRepository.Update(workPackageReport);

            return Ok(workPackageReport);

        }

        // POST: api/WorkPackageReports
        //Since frontend is sending WpCode in ViewModel, instead of the internal WpId, we need to first get the Id using Code.
        //TODO?: add checking for duplicate dates... not allowed to post duplicate dates. One report per date. 
        [HttpPost]
        public async Task<ActionResult<WorkPackageReport>> PostWorkPackageReport(WorkPackageReportViewModel workPackageReportViewModel)
        {
            try
            {
                int wpId = (await _workPackageRepository.GetAll())
                    .FirstOrDefault(w => w.WorkPackageCode.Equals(workPackageReportViewModel.WorkPackageCode))
                    .WorkPackageId;
                await _workPackageReportRepository.Add(new WorkPackageReport(workPackageReportViewModel, wpId));
                foreach (WorkPackageReportDetailsViewModel details in workPackageReportViewModel.Details)
                {
                    await _workPackageReportDetailsRepository.Add(
                        new WorkPackageReportDetails(details, wpId));
                }

                return Ok(200);
            }
            catch (NullReferenceException e)
            {
                return Ok(new Exception("Null pointer: WorkPackageview's wp code might not exist in database. " +
                                        "Cannot get ID for wp code."));
            }
            catch (Exception e)
            {
                return Ok(new Exception("Failed to add, something went wrong: " + e.ToString()));
            }
        }
    }
}
