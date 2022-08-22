using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Address
    {
        public Address(int addressId, string addressName)
        {
            AddressId = addressId;
            AddressName = addressName;
        }

        public int AddressId { get; set; }
        public int PersonId { get; set; }
        public string AddressName { get; set; }
        public Person Person { get; set; }
    }
}
