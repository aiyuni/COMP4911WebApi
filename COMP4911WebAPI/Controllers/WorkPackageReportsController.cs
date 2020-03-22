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
        private readonly IDataRepository<Project> _projectRepository;
        private readonly IDataRepository<Employee> _employeeRepository;
        private readonly IDataRepository<LabourGrade> _labourGradeRepository;
        private readonly IDataRepository<EmployeeWorkPackageAssignment> _employeeWorkPackageAssignmentRepository;

        public WorkPackageReportsController(IDataRepository<WorkPackageReport> workPackageReportRepository, 
            IDataRepository<WorkPackageReportDetails> workPackageReportDetailsRepository,
            IDataRepository<WorkPackage> workPackageRepository, IDataRepository<Project> projectRepository,
            IDataRepository<Employee> employeeRepository, IDataRepository<LabourGrade> labourGradeRepository,
            IDataRepository<EmployeeWorkPackageAssignment> employeeWorkPackageAssignmentRepository)
        {
            this._workPackageReportRepository = workPackageReportRepository;
            this._workPackageReportDetailsRepository = workPackageReportDetailsRepository;
            this._workPackageRepository = workPackageRepository;
            this._projectRepository = projectRepository;
            this._employeeRepository = employeeRepository;
            this._labourGradeRepository = labourGradeRepository;
            this._employeeWorkPackageAssignmentRepository = employeeWorkPackageAssignmentRepository;
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
        public async Task<ActionResult<WorkPackageReportGetViewModel>> GetWorkPackageReport(string id)
        {
            try
            {
                var workPackage = (await _workPackageRepository.GetAll()).FirstOrDefault(w => w.WorkPackageCode.Equals(id));
                var project = await _projectRepository.Get(workPackage.ProjectId);
                int wpId = (await _workPackageRepository.GetAll()).FirstOrDefault(w => w.WorkPackageCode.Equals(id))
                    .WorkPackageId;
                var workPackageReport = await _workPackageReportRepository.Get(wpId);

                if (workPackageReport == null)
                {
                    return NotFound();
                }


                var projectManager = await _employeeRepository.Get(project.ProjectManagerId);
                projectManager.LabourGrade = await _labourGradeRepository.Get(projectManager.LabourGradeId);
                var responsibleEngineer = await _employeeRepository.Get(workPackage.ResponsibleEngineerId);
                responsibleEngineer.LabourGrade = await _labourGradeRepository.Get(responsibleEngineer.LabourGradeId);


                List<EmployeeReportViewModel> engineers = new List<EmployeeReportViewModel>();

                foreach(EmployeeWorkPackageAssignment item in await _employeeWorkPackageAssignmentRepository.GetAll())
                {
                    if (item.WorkPackageId == wpId)
                    {
                        var engineer = await _employeeRepository.Get(item.EmployeeId);
                        engineer.LabourGrade = await _labourGradeRepository.Get(engineer.LabourGradeId);
                        engineers.Add(new EmployeeReportViewModel(engineer));
                    }
                }

                List<WorkPackageReportDetailsViewModel> details = new List<WorkPackageReportDetailsViewModel>();

                foreach (WorkPackageReportDetails item in await _workPackageReportDetailsRepository.GetAll())
                {
                    if (item.WorkPackageReportId == workPackageReport.WorkPackageReportId)
                    {
                        details.Add(new WorkPackageReportDetailsViewModel(item));
                    }
                }

                WorkPackageReportGetViewModel workPackageReportGetViewModel = new WorkPackageReportGetViewModel(workPackageReport, workPackage, project, projectManager, responsibleEngineer, engineers, details);

                return workPackageReportGetViewModel;
            }
            catch (NullReferenceException e)
            {
                return Ok(new Exception("Null pointer: WorkPackageview's wp code might not exist in database. " +
                                        "Cannot get ID for wp code." +
                                        " Error msg: " + e.ToString()));
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
                    WorkPackageReportDetails wpReportDetails = new WorkPackageReportDetails();
                    wpReportDetails.LabourGradeId = details.LabourGradeId;
                    wpReportDetails.WorkPackageReportId = wpId;
                    wpReportDetails.LabourGradeName = details.LabourGradeName;
                    wpReportDetails.ResponsibleEngineerBudgetInDays = details.ReBudgetDay;
                    wpReportDetails.TotalDays = details.TotalDays;
                    wpReportDetails.ReEstimateAtCompletion = details.ReEAC;
                    wpReportDetails.ReEstimateToCompletion = details.ReETC;
                    wpReportDetails.VariancePercent = details.Variance;
                    wpReportDetails.CompletionPercent = details.Complete;
                    wpReportDetails.LastUpdatedBy = Environment.UserName;
                    wpReportDetails.LastUpdatedTime = DateTime.Now;

                    await _workPackageReportDetailsRepository.Add(wpReportDetails);
                    //await _workPackageReportDetailsRepository.Add(new WorkPackageReportDetails(details, wpId));
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
    

        // GET: api/WorkPackageReports/getAllWorkPackageReport/wpcode
        [HttpGet("getAllWorkPackageReport/{id}")]
        public async Task<ActionResult<IEnumerable<WorkPackageReportGetAllViewModel>>> GetAllWorkPackageReports(int id)
        {
            List<WorkPackageReportGetAllViewModel> list = new List<WorkPackageReportGetAllViewModel>();

            foreach(WorkPackageReport item in await _workPackageReportRepository.GetAll()) {
                if(item.WorkPackageId == id) 
                    list.Add(new WorkPackageReportGetAllViewModel(item));
            }

            return Ok(list);
        }
    }
}
