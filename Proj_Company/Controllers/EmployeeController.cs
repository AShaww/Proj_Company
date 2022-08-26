using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Services.Interfaces;
using FluentValidation.AspNetCore;
using Proj_Company.Extensions;
using Models.Entities;
using Models.ViewModels.EmployeeViewModels;

namespace Proj_Company.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
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
        public async Task<IActionResult> Create(Employee employee, EmployeeDetails employeeDetails)
        {

            employee.EmployeeDetail = employeeDetails;

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
