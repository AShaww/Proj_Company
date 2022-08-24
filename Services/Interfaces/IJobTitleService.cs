using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IJobTitleService
    {
        Task<JobRoleViewModel> BuildJobTitleViewModel();
        Task<JobRoleViewModel> BuildInitialEmployeeViewModel();
        Task<ActionResult> AddEmployee(JobRole jobRole);
        Task<CreateJobRoleViewModel> BuildCreateEmployeeViewModel(CreateJobRoleViewModel? viewModel = null);
        Task<ValidationResult> ValidateCreateEmployeeViewModel(CreateJobRoleViewModel viewModel);
    }
}
