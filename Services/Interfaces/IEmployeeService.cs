using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.ViewModels.EmployeeViewModels;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeViewModel> BuildEmployeeListViewModel();
        Task<EmployeeViewModel> BuildInitialEmployeeViewModel();
        Task<ActionResult> AddEmployee(Employee person);
        Task<CreateEmployeeViewModel> BuildCreateEmployeeViewModel(CreateEmployeeViewModel? viewModel = null);
        Task<ValidationResult> ValidateCreateEmployeeViewModel(CreateEmployeeViewModel viewModel);
    }
}