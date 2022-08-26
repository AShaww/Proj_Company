using FluentValidation;
using Models.Entities;
using Services.Interfaces;
using System.Text.RegularExpressions;

namespace Services.EntityValidators
{
    public class EmployeeValidator : AbstractValidator<Employee> , IRegexService
    {
        public EmployeeValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Field cannot be empty").MinimumLength(3).WithMessage("Cannot be less than 4 chars");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Field cannot be empty").MinimumLength(3).WithMessage("Cannot be less than 4 chars");
            RuleFor(c => c.EmployeeDetail.Address).NotEmpty().WithMessage("Field cannot be empty").MinimumLength(8).WithMessage("Cannot be less than 8 chars");
            RuleFor(c => c.EmployeeDetail.MobileNumber)
                .NotEmpty().WithMessage("Must have a number")
                .Must(x => IsPhoneNumber(x.ToString())).WithMessage("Must have numbers only");
            RuleFor(c => c.EmployeeDetail.HomePhoneNumber).NotEmpty().WithMessage("Field cannot be empty");

        }


        public bool IsPhoneNumber(string x)
        {
            var digit = new Regex("(\\d)");
            var symbol = new Regex("(\\W)-+");

            return digit.IsMatch(x) && symbol.IsMatch(x);
        }
     



    }
}
