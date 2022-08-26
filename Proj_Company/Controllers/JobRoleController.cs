using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.ViewModels.JobRoleViewModels;
using Proj_Company.Extensions;
using Services.EntityValidators;
using Services.Interfaces;

namespace Proj_Company.Controllers
{
    public class JobRoleController : Controller
    {
        private readonly IJobRoleService _jobRoleService;
        public JobRoleController(IJobRoleService jobRoleService)
        {
            _jobRoleService = jobRoleService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var jobRoleList = await _jobRoleService.BuildInitialJobRoleViewModel();

            return View(jobRoleList);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewModel = await _jobRoleService.BuildCreateJobRoleViewModel();
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(JobRole jobRoles)
        {
            var validator = new JobRoleValidator();
            var validationResult = validator.Validate(jobRoles);

            var viewModel = new CreateJobRoleViewModel { JobRoles = jobRoles };
            /*var results = await _jobRoleService.ValidateCreateJobRoleViewModel(viewModel);*/

            /*if(!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.First().ErrorMessage);
            }    */

            if (!validationResult.IsValid)
            {
                viewModel = await _jobRoleService.BuildCreateJobRoleViewModel();
                validationResult.AddToModelState(this.ModelState);
                return View(viewModel);
            }

            await _jobRoleService.AddJobRole(viewModel.JobRoles);
            return Redirect("Index");
        }
    }
}
