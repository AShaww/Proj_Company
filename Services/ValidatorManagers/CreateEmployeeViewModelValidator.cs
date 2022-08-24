using FluentValidation;
using Models.ViewModels.EmployeeViewModels;
using Services.EntityValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ValidatorManagers
{
    public class CreateEmployeeViewModelValidator : AbstractValidator<CreateEmployeeViewModel>
    {
        public CreateEmployeeViewModelValidator()
        {
            RuleFor(viewModel => viewModel.Employee).SetValidator(new EmployeeValidator());
        }
    }
}
