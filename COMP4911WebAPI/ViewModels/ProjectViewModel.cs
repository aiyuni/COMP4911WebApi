﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    public class ProjectViewModel
    {
       
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public IList<WorkPackageViewModel> WorkPackageViewModels { get; set; }


        public ProjectViewModel(int projectId, string projectName, IList<WorkPackageViewModel> workPackageViewModels)
        {
            ProjectId = projectId;
            ProjectName = projectName;
            WorkPackageViewModels = workPackageViewModels;
        }
    }
}
