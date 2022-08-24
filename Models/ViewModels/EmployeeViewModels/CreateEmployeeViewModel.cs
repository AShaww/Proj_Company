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
        public EmployeeDetails ContactDetails { get; set; }
        public List<JobRole> JobRoles { get; set; }
    }
}
