using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using COMP4911WebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace COMP4911WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabourGradeController : ControllerBase
    {
        private readonly IDataRepository<LabourGrade> _labourGradeRepository;

        public LabourGradeController(IDataRepository<LabourGrade> labourGradeRepository)
        {
            this._labourGradeRepository = labourGradeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLabourGrades()
        {
            IList<LabourGradeViewModel> lgList = new List<LabourGradeViewModel>();
            foreach (LabourGrade lg in await _labourGradeRepository.GetAll())
            {
                lgList.Add(new LabourGradeViewModel(lg));
            }
            return Ok(lgList);
        }
    }
}
