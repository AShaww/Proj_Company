using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class PersonAddress
    {
        public int PersonId { get; set; }
        public string AddressId { get; set; }
        
        public Person? Person { get; set; }
        public Address? Address { get; set; }
    }
}
