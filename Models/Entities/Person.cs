using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Person
    {
        public Person(int id, int addressId)
        {
            PersonId = id;
            AddressId = addressId;
        }

        public int PersonId { get; set; }
        
      /*  public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname
        {
            get
            {
                return FirstName + LastName;
            }
        }*/
        public int AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
