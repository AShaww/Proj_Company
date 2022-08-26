
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

        public int MobileNumber { get; set; }
        public int? HomePhoneNumber { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }
}
