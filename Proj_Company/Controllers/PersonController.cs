using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Services.Interfaces;
using FluentValidation.AspNetCore;
using Proj_Company.Extensions;
using Models.Entities;
namespace Proj_Company.Controllers
{
    public class PersonController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public PersonController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employeeList = await _employeeService.BuildInitialEmployeeViewModel();
            return View(employeeList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var viewModel = await _employeeService.BuildCreateEmployeeViewModel();
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee, ContactDetails contactDetails)
        {
            employee.ContactDetails = contactDetails;

            var viewModel = new CreateEmployeeViewModel
            {
                Employee = employee
            };

            var results = await _employeeService.ValidateCreateEmployeeViewModel(viewModel);

            if (!results.IsValid)
            {
                viewModel = await _employeeService.BuildCreateEmployeeViewModel();
                results.AddToModelState(this.ModelState);
                return View(viewModel);
            }

            await _employeeService.AddEmployee(viewModel.Employee);
            return Redirect("Index");
        }
    }
}
