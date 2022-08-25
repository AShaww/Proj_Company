using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.EmployeeViewModels
{
    public class CreateEmployeeViewModel
    {
        public Employee Employee { get; set; }
        public EmployeeDetails EmployeeDetails { get; set; }
        public List<JobRole> JobRoles { get; set; }
    }
}
