using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class CreateEmployeeViewModel
    {
        public Employee Employee { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public List<JobRole> JobRoles { get; set; }
    }
}
