using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Gender
    {
        public Gender()
        {

        }
        public Gender(int genderId, string genderName)
        {
            GenderId = genderId;
            GenderName = genderName;
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public ICollection<Employee>? Employees { get; set; }

    }
}
