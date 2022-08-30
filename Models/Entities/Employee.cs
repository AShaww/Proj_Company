namespace Models.Entities
{
    public class Employee
    {
        public Employee()
        {

        }
     
        public int EmployeeId { get; set; }
        public int EmployeeDetailsId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int GenderId { get; set; }
        public int JobRoleId { get; set; }
        public EmployeeDetails EmployeeDetail { get; set; }
        public JobRole JobRole { get; set; }
        public Gender Gender { get; set; }
    }
}
