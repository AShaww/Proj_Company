using FluentValidation;
using Models.ViewModels.JobRoleViewModels;
using Services.EntityValidators;


namespace Services.ValidatorManagers
{
    public class CreateJobRoleViewModelValidator : AbstractValidator<CreateJobRoleViewModel>
    {
        public CreateJobRoleViewModelValidator()
        {
            RuleFor(viewModel => viewModel.JobRoles).SetValidator(new JobRoleValidator());

        }
    }
}
