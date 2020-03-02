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
        private readonly EmployeesController _empController;
        private readonly TimesheetsController _tsController;

        public WorkPackagesController(IDataRepository<WorkPackage> wpRepository, IDataRepository<Project> projRepository,
            IDataRepository<Timesheet> timesheetRepository, IDataRepository<Employee> employeeRepository, 
            EmployeesController empController, TimesheetsController tsController)
        {
            this._workPackageRepository = (WorkPackageRepository) wpRepository;
            this._projectRepository = (ProjectRepository) projRepository;
            this._timesheetRepository = (TimesheetRepository) timesheetRepository;
            this._employeeRepository = (EmployeeRepository) employeeRepository;
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
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkPackage>> GetWorkPackage(int id)
        {
            return Ok(await _workPackageRepository.Get(id));
        }

        // GET: api/WorkPackages/GetTotalHoursByWpIdRange/B/2020-2-10/2020-2-20/2
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

        // PUT: api/WorkPackages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkPackage(int id, WorkPackage workPackage)
        {
            await _workPackageRepository.Update(workPackage);
            return NoContent();
        }

        // POST: api/WorkPackages
        [HttpPost]
        public async Task<ActionResult<WorkPackage>> PostWorkPackage(WorkPackage workPackage)
        {
            Debug.WriteLine("posting work package...");
            await _workPackageRepository.Add(workPackage);
            return Ok(200);
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
