using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class JobRole
    {
        public JobRole()
        {

        }
        public JobRole(int id, string title)
        {
            JobRoleId = id;
            JobTitle = title;
        }
        public int JobRoleId { get; set; }
        public string JobTitle { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
