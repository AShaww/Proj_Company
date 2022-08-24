namespace Models.Entities
{
    public class Employee
    {
        public Employee()
        {

        }
        /*public Person(int id, int addressId, string firstName, string lastName)
        {
            PersonId = id;
            AddressId = addressId;
            FirstName = firstName;
            LastName = lastName;
        }*/
        public int EmployeeId { get; set; }
        public int EmployeeDetailsId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname
        {
            get
            {
                return FirstName + LastName;
            }
        }
        public int JobRoleId { get; set; }
        public EmployeeDetails ContactDetails { get; set; }
        public JobRole? JobRole { get; set; }
    }
}
