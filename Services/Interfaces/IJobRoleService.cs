using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.ViewModels;
using Models.ViewModels.JobRoleViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IJobRoleService
    {
        Task<JobRoleViewModel> BuildInitialJobRoleViewModel();  
        Task<JobRoleViewModel> BuildJobTitleViewModel();
        Task<CreateJobRoleViewModel> BuildCreateJobRoleViewModel(CreateJobRoleViewModel? viewModel = null);
        Task<ValidationResult> ValidateCreateJobRoleViewModel(CreateJobRoleViewModel viewModel);
        Task<ActionResult> AddJobRole(JobRole jobRole);

    }
}
