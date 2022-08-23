using Data;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.ViewModels;
using Services.Interfaces;
using System.Linq;

namespace Services.Implementations
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        private readonly IValidator<CreateEmployeeViewModel> _validator;
        public EmployeeService(CompanyContext db, IValidator<CreateEmployeeViewModel> validator) : base(db)
        {
            _validator = validator;
        }

        public async Task<ActionResult> AddEmployee(Employee person)
        {
            //add address


            /*            person.Address.AddressId = (highestIndex.AddressId + 1);*/

            /* _db.AddressList.Add(person.Address);*/

            //look at the identity column for address, add this first with highest id of user.

            //add person 
            await _db.ContactDetails.AddAsync(person.ContactDetails);
            await _db.JobRoles.AddAsync(person.JobRole);

            var highestIndex = await _db.ContactDetails.OrderByDescending(a => a.EmployeeDetailsId).SingleOrDefaultAsync();
            if (highestIndex == null)
            {
                person.ContactDetailsId = 1;
                    }
            else
            {
                person.ContactDetailsId = highestIndex.EmployeeDetailsId;
            }
            await _db.Employee.AddAsync(person);
            await _db.SaveChangesAsync();
            return new OkResult();
        }

        public async Task<CreateEmployeeViewModel> BuildCreateEmployeeViewModel(CreateEmployeeViewModel? viewModel = null)
        {
            if (viewModel == null)
            {
                viewModel = new CreateEmployeeViewModel { Employee = new Employee() };
            }
            return viewModel;
        }

        public async Task<EmployeeViewModel> BuildEmployeeListViewModel()
        {
            var viewModel = new EmployeeViewModel
            {
                EmployeeResults = await GetInitialEmployeeResults()
            };
            return viewModel;

        }
        public async Task<EmployeeResults> GetInitialEmployeeResults()
        {

            var recordCount = _db.Employee.Count();

            EmployeeResults results = new EmployeeResults
            {
                Employee = await SortEmployeeResults()
            };
            return results;
        }
        private async Task<List<Employee>> SortEmployeeResults()
        {

            var Employees = _db.Employee.Include(a => a.ContactDetails).ToList();

            return Employees;
        }
        public async Task<EmployeeViewModel> BuildInitialEmployeeViewModel()
        {
            var viewModel = new EmployeeViewModel
            {
                EmployeeResults = await GetInitialEmployeeResults()
            };
            return viewModel;
        }

        public async Task<ValidationResult> ValidateCreateEmployeeViewModel(CreateEmployeeViewModel viewModel)
        {
            ValidationResult result = await _validator.ValidateAsync(viewModel);
            return result;
        }
    }
}
