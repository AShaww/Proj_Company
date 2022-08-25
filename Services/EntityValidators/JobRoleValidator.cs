using FluentValidation;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EntityValidators
{
    public class JobRoleValidator : AbstractValidator<JobRole>
    {
        public JobRoleValidator()
        {
            RuleFor(c => c.JobRoleTitle).NotEmpty().WithMessage("Must have value!");
        }
    }
}
