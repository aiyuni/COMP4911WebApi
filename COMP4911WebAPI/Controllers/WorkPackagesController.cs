using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using COMP4911WebAPI.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkPackagesController : ControllerBase
    {
        private readonly WorkPackageRepository _workPackageRepository;
        private readonly ProjectRepository _projectRepository;
        private readonly TimesheetRepository _timesheetRepository;
        private readonly EmployeeRepository _employeeRepository;
        private readonly WorkPackageLabourGradeAssignmentRepository _workPackageLabourGradeRepository;
        private readonly EmployeeWorkPackageAssignmentRepository _empWorkPackageAssignmentRepository;
        private readonly EmployeesController _empController;
        private readonly TimesheetsController _tsController;

        public WorkPackagesController(IDataRepository<WorkPackage> wpRepository, IDataRepository<Project> projRepository,
            IDataRepository<Timesheet> timesheetRepository, IDataRepository<Employee> employeeRepository,
            IDataRepository<WorkPackageLabourGradeAssignment> workPackageLabourGradeAssignment,
            IDataRepository<EmployeeWorkPackageAssignment> empWorkPackageAssignment,
            EmployeesController empController, TimesheetsController tsController)
        {
            this._workPackageRepository = (WorkPackageRepository) wpRepository;
            this._projectRepository = (ProjectRepository) projRepository;
            this._timesheetRepository = (TimesheetRepository) timesheetRepository;
            this._employeeRepository = (EmployeeRepository) employeeRepository;
            this._workPackageLabourGradeRepository = (WorkPackageLabourGradeAssignmentRepository) workPackageLabourGradeAssignment;
            this._empWorkPackageAssignmentRepository =
                (EmployeeWorkPackageAssignmentRepository) empWorkPackageAssignment;
            this._empController = empController;
            this._tsController = tsController;
        }

        // GET: api/WorkPackages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkPackage>>> GetWorkPackages()
        {

            //return Ok(await _workPackageRepository.GetAll());
            List<WorkPackage> workPackages = new List<WorkPackage>();

            foreach (WorkPackage wp in await _workPackageRepository.GetAll())
            {
                wp.ChildrenWorkPackages = null;
                workPackages.Add(wp);
            }
            return workPackages;
        }

        // GET: api/WorkPackages/5
        [HttpGet("{code}")]
        public async Task<ActionResult<WorkPackage>> GetWorkPackage(string code)
        {
            //Get WpId from param that is WpCode
            int id = _workPackageRepository.GetIdByCode(code);

            //Get WP
            WorkPackage wp = await _workPackageRepository.Get(id);

            //Get ParentWPCode
            int? parentWpId = wp.ParentWorkPackageId;
            string parentWpCode = null;
            WorkPackage parentWp;
            if (parentWpId != null)
            {
                parentWp = await _workPackageRepository.Get((int)parentWpId);
                parentWpCode = parentWp.WorkPackageCode;
            }

            //GetProject
            Project proj = await _projectRepository.Get(wp.ProjectId);

            //Filter EmployeeWokPackageAssignments
            IEnumerable<EmployeeWorkPackageAssignment> empWpAssignments = await _empWorkPackageAssignmentRepository.GetAll();
            empWpAssignments = empWpAssignments.Where(x => x.WorkPackageId == id);  

            //Get employees list and Responsible Engineer
            IList<EmployeeNameViewModel> employees = new List<EmployeeNameViewModel>();
            EmployeeNameViewModel responsibleEngineer = null;

            foreach (EmployeeWorkPackageAssignment empWpAssignment in empWpAssignments)
            {
                Employee emp = await _employeeRepository.Get(empWpAssignment.EmployeeId);
                if (wp.ResponsibleEngineerId != empWpAssignment.EmployeeId)
                {
                    employees.Add(new EmployeeNameViewModel(emp));
                }
                else
                {
                    responsibleEngineer = new EmployeeNameViewModel(emp);
                }
            }

            //Filter WorkPackageLabourGradeAssignments
            IEnumerable<WorkPackageLabourGradeAssignment> wpLabourGradeAssignments =
                await _workPackageLabourGradeRepository.GetAll();
            wpLabourGradeAssignments = wpLabourGradeAssignments.Where(x => x.WorkPackageId == id);

            //Get PmPlannings
            IList<PmPlanningViewModel> pmPlannings = new List<PmPlanningViewModel>();
            foreach (WorkPackageLabourGradeAssignment item in wpLabourGradeAssignments)
            {
                pmPlannings.Add(new PmPlanningViewModel(item));
            }

            //Create the viewmodel
            WorkPackageViewModel wpViewModel = new WorkPackageViewModel(wp, parentWpCode, proj, responsibleEngineer, employees, pmPlannings);

           // return Ok(await _workPackageRepository.Get(id));  //this is just plain database table object
           return Ok(wpViewModel);
        }

        //GET: api/WorkPackages/GetAllWorkPackagesByProjectId/2
        [HttpGet("GetAllWorkPackagesByProjectId/{projId}")]
        public async Task<ActionResult> GetAllWorkPackagesByProjectId(int projId)
        {
            IList<WorkPackageViewModel> wpViewModels = new List<WorkPackageViewModel>();

            IEnumerable<WorkPackage> wpList = await _workPackageRepository.GetAll();
            wpList = wpList.Where(wp => wp.ProjectId == projId);

            foreach (WorkPackage wp in wpList)
            {
                //Get ParentWPCode
                int? parentWpId = wp.ParentWorkPackageId;
                string parentWpCode = null;
                WorkPackage parentWp;
                if (parentWpId != null)
                {
                    parentWp = await _workPackageRepository.Get((int)parentWpId);
                    parentWpCode = parentWp.WorkPackageCode;
                }

                //GetProject
                Project proj = await _projectRepository.Get(wp.ProjectId);

                wpViewModels.Add(new WorkPackageViewModel(wp, parentWpCode, proj));
            }

            return Ok(wpViewModels);
        }

        [HttpGet("GetallWorkPackagesByEmpId/{empId}")]
        public async Task<ActionResult> GetAllWorkPackageByEmpId(int empId)
        {
            IList<WorkPackageViewModel> wpViewModels = new List<WorkPackageViewModel>();

            //IEnumerable<WorkPackage> wpList = await _workPackageRepository.GetAll();

            IEnumerable<EmployeeWorkPackageAssignment> empWpList = await _empWorkPackageAssignmentRepository.GetAll();
            empWpList = empWpList.Where(x => x.EmployeeId == empId);

            IList<WorkPackage> wpList = new List<WorkPackage>();

            foreach (EmployeeWorkPackageAssignment item in empWpList)
            {
                WorkPackage wp = await _workPackageRepository.Get(item.WorkPackageId);
                wpList.Add(wp);
            }

            foreach (WorkPackage wp in wpList)
            {
                //Get ParentWPCode
                int? parentWpId = wp.ParentWorkPackageId;
                string parentWpCode = null;
                WorkPackage parentWp;
                if (parentWpId != null)
                {
                    parentWp = await _workPackageRepository.Get((int)parentWpId);
                    parentWpCode = parentWp.WorkPackageCode;
                }

                //GetProject
                Project proj = await _projectRepository.Get(wp.ProjectId);

                //GetResponsibleEngineer
                Employee re = await _employeeRepository.Get(wp.ResponsibleEngineerId);
                
                wpViewModels.Add(new WorkPackageViewModel(wp, parentWpCode, proj, new EmployeeNameViewModel(re)));
            }

            return Ok(wpViewModels);
        }
        
        

        // GET: api/WorkPackages/GetTotalHoursByWpIdRange/B/2020-2-10/2020-2-20/2
        //This is for WP Report
        [HttpGet("GetTotalHoursByWpIdRange/{wpId}/{startDate}/{endDate}/{labourGradeId}")]
        public async Task<ActionResult> GetActualDaysByWpIdRange(string wpId, DateTime startDate, DateTime endDate,
            int labourGradeId)
        {
            double totalHours = 0;
            IList<WorkPackage> wpList = await this.GetAllChildWorkPackages(wpId);
            IList<Employee> empList = (await _empController.GetAllEmployeesByLabourGrade(labourGradeId)).ToList();
            IList<Timesheet> tsList = new List<Timesheet>();
            foreach (Employee emp in empList)
            {
                IList<Timesheet> tempTsList = tsList.Concat((await _tsController.GetTimesheetByEmpIdHelper(emp.EmployeeId))
                    .Where(t => (DateTime.Compare(t.WeekEndingIn, endDate)) <= 0 &&
                                (DateTime.Compare(t.WeekEndingIn, HelperMethods.GetWeekEndingIn(startDate)) >= 0))
                    .ToList()).ToList();
                tsList = tempTsList;
            }

            foreach (Timesheet ts in tsList)
            {
                Timesheet detailedTs = await _tsController.GetFullTimesheetDetails(ts);
                //Debug.WriteLine("week ending in is: " + ts.WeekEndingIn + ", End Date is: " +
                //                endDate + "value of compare to with end date is: " +
                //                DateTime.Compare(ts.WeekEndingIn, endDate) + ", value of compare to with start date is: " +
                //                DateTime.Compare(ts.WeekEndingIn, HelperMethods.GetWeekEndingIn(startDate))); ;
                foreach (TimesheetRow row in detailedTs.TimesheetRows)
                {
                    foreach (WorkPackage wp in wpList)
                    {
                        if (row.WorkPackageId == wp.WorkPackageId)
                        {
                            totalHours += HelperMethods.SumTotalHoursOfTimesheetRow(row);
                        }
                    }
                }
            }

            Debug.Write("Total days is: " + totalHours/8);
            return Ok(new TotalDaysViewModel(totalHours/8));
        }

        //// PUT: api/WorkPackages/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutWorkPackage(int id, WorkPackage workPackage)
        //{
        //    await _workPackageRepository.Update(workPackage);
        //    return NoContent();
        //}

        // New PUT: api/WorkPackages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkPackage(string id, WorkPackageViewModel wpViewModel)
        {
            //Get Project and ParentWpIds
            int? parentWpId = null;
            if (wpViewModel.ParentWorkPackageCode != null)
            {
                parentWpId = _workPackageRepository.GetIdByCode(wpViewModel.ParentWorkPackageCode);
            }
        
            int projectId = _projectRepository.GetIdByCode(wpViewModel.ProjectCode);
            int wpId = wpViewModel.WorkPackageId;

            WorkPackage wp = new WorkPackage(wpViewModel, parentWpId, projectId);
            wp.WorkPackageId = wpId; //id is needed for PUT

            await _workPackageRepository.Update(wp);

            //Get and delete existing assignments
            IEnumerable<EmployeeWorkPackageAssignment> empWpList = await _empWorkPackageAssignmentRepository.GetAll();
            foreach (EmployeeNameViewModel emp in wpViewModel.Employees)
            {
                var tempList = empWpList.Where(x => x.EmployeeId == emp.EmployeeId);
                foreach (var empWp in tempList)
                {
                    await _empWorkPackageAssignmentRepository.Delete(empWp);
                }
            }

            await _empWorkPackageAssignmentRepository.Delete(empWpList.FirstOrDefault(x =>
                x.EmployeeId == wpViewModel.ResponsibleEngineer.EmployeeId));

            //add updated assignments back
            foreach (EmployeeNameViewModel emp in wpViewModel.Employees)
            {
                EmployeeWorkPackageAssignment empWpAss = new EmployeeWorkPackageAssignment(emp.EmployeeId, wpId);
                await _empWorkPackageAssignmentRepository.Add(empWpAss);
            }

            //add updated RE to db
            EmployeeWorkPackageAssignment re = new EmployeeWorkPackageAssignment(wpViewModel.ResponsibleEngineer.EmployeeId, wpId);
            await _empWorkPackageAssignmentRepository.Add(re);

            //update pmViewModels
            foreach (PmPlanningViewModel pmViewModel in wpViewModel.PmPlannings)
            {
                WorkPackageLabourGradeAssignment wplga = new WorkPackageLabourGradeAssignment(wpId, pmViewModel);
                await _workPackageLabourGradeRepository.Update(wplga);
            }

            return Ok(200);
        }

        //New Post: api/WorkPackages
        [HttpPost]
        public async Task<ActionResult<WorkPackageViewModel>> PostWorkPackage(WorkPackageViewModel wpViewModel)
        {
            //Get Project and ParentWpIds
            int? parentWpId = null;
            if (wpViewModel.ParentWorkPackageCode != null)
            {
                parentWpId = _workPackageRepository.GetIdByCode(wpViewModel.ParentWorkPackageCode);
            }
            int projectId = _projectRepository.GetIdByCode(wpViewModel.ProjectCode);

            WorkPackage wp = new WorkPackage(wpViewModel, parentWpId, projectId);
            await _workPackageRepository.Add(wp);

            //Get id of the wp just added
            int wpId = _workPackageRepository.GetIdByCode(wpViewModel.WorkPackageCode);

            //add pmViewModels
            foreach (PmPlanningViewModel pmViewModel in wpViewModel.PmPlannings)
            {
                WorkPackageLabourGradeAssignment wplga = new WorkPackageLabourGradeAssignment(wpId, pmViewModel);
                await _workPackageLabourGradeRepository.Add(wplga);
            }

            foreach (EmployeeNameViewModel emp in wpViewModel.Employees)
            {
                EmployeeWorkPackageAssignment empWpAss = new EmployeeWorkPackageAssignment(emp.EmployeeId, wpId);
                await _empWorkPackageAssignmentRepository.Add(empWpAss);
            }

            //add RE to db
            EmployeeWorkPackageAssignment re = new EmployeeWorkPackageAssignment(wpViewModel.ResponsibleEngineer.EmployeeId, wpId);
            await _empWorkPackageAssignmentRepository.Add(re);

            return Ok(wpViewModel);
        }

        private bool WorkPackageExists(int id)
        {
            return true;
        }

        private async Task<IList<WorkPackage>> GetAllChildWorkPackages(string code)
        {
            IEnumerable<WorkPackage> allWp = (await _workPackageRepository.GetAll());
            List<WorkPackage> wpList = new List<WorkPackage>();
            foreach (WorkPackage wp in allWp)
            {
                if (wp.WorkPackageCode.StartsWith(code))
                {
                    if (wp.ChildrenWorkPackages == null) //if the wp doesnt have any more children
                    {
                        wpList.Add(wp);
                    }
                    else if (!wp.WorkPackageCode.Equals(code))
                    {
                        List<WorkPackage> tempList = await (await GetAllChildWorkPackages(wp.WorkPackageCode)).ToAsyncEnumerable().ToList();
                        wpList.AddRange(tempList);
                    }
                }
            }

            return wpList.ToHashSet().ToList();
        }

        
    }
}
