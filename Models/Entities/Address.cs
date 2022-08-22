using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Address
    {
        public Address(int addressId, string addressName, int personId)
        {
            AddressId = addressId;
            AddressName = addressName;
            PersonId = personId;
        }

        public int AddressId { get; set; }
        public string AddressName { get; set; }
        public int PersonId { get; set; }   
        public ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
