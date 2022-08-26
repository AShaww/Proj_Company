
using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class EmployeeDetails 
    {
        public EmployeeDetails() { }

        /*  public Address(int addressId, string addressName)
          {
              AddressId = addressId;
              AddressName = addressName;
          }*/
        public int EmployeeDetailsId { get; set; }


        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid number (NO SYMBOLS)")]
        public string MobileNumber { get; set; }


        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid number (NO SYMBOLS)")]
        public int? HomePhoneNumber { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }
}
