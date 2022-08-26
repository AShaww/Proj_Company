using Data;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.ViewModels.JobRoleViewModels;
using Services.Interfaces;

namespace Services.Implementations
{
    public class JobRoleService : BaseService, IJobRoleService
    {
        private readonly IValidator<CreateJobRoleViewModel> _validator;
        public JobRoleService(CompanyContext db, IValidator<CreateJobRoleViewModel> validator) : base(db)
        {
            _validator = validator;
        }
        public async Task<ActionResult> AddJobRole(JobRole jobRole)
        {
            await _db.JobRoles.AddAsync(jobRole);
            await _db.SaveChangesAsync();
            return new OkResult();
        }

        public async Task<CreateJobRoleViewModel> BuildCreateJobRoleViewModel(CreateJobRoleViewModel? viewModel = null)
        {
            if (viewModel == null)
            {
                viewModel = new CreateJobRoleViewModel { JobRoles = new JobRole() };
            }
          /*  viewModel.JobRole = await _db.JobRoles.ToListAsync(); */
            return viewModel;

        }

        public async Task<JobRoleViewModel> BuildInitialJobRoleViewModel()
        {
            var viewModel = new JobRoleViewModel
            {
                JobRoleResults = await GetInitialJobRoleResults()
            };
            return viewModel;
        }
        /*     public async Task<JobRoleResults> GetInitialJobRoleResults()
             {
                 JobRoleResults results = new();
                 return results;
             }*/
        public async Task<JobRoleViewModel> BuildJobTitleViewModel()
        {
            var viewModel = new JobRoleViewModel
            {
                JobRoleResults = await GetInitialJobRoleResults()
            };
            return viewModel;
        }

        public async Task<JobRoleResults> GetInitialJobRoleResults()
        {
            JobRoleResults results = new JobRoleResults()
            {
                JobRole = await SortJobRoleResults()
            };
            return results;
        }
      
        private async Task<List<JobRole>> SortJobRoleResults()
        {
            var JobRole =  _db.JobRoles.ToList();
            return JobRole;
        }
        public async Task<ValidationResult> ValidateCreateJobRoleViewModel(CreateJobRoleViewModel viewModel)
        {
            ValidationResult result = await _validator.ValidateAsync(viewModel);

            return result;
        }
    }
}
