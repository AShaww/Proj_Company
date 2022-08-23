using FluentValidation;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EntityValidators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Field cannot be empty").MinimumLength(4).WithMessage("Cannot be less than 4 chars");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Field cannot be empty").MinimumLength(4).WithMessage("Cannot be less than 4 chars");

        }
    }
}
