using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace Data.EntityConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.EmployeeId);
            builder.HasOne(a => a.EmployeeDetail).WithOne(a => a.Employee)
                .HasForeignKey<EmployeeDetails>(a => a.EmployeeDetailsId);

            builder.HasOne(x => x.Gender).WithMany(x=>x.Employees).HasForeignKey(x=>x.GenderId);
                

            builder.HasOne(x => x.JobRole)
                .WithMany(x => x.Employees);
            Seed(builder);
        }
        public void Seed(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { EmployeeId = 1, EmployeeDetailsId = 1, FirstName = "Pepper", LastName = "Potts", JobRoleId = 2, GenderId = 2  },
                new Employee { EmployeeId = 2, EmployeeDetailsId = 2, FirstName = "Amelia", LastName = "Kent", JobRoleId = 2, GenderId = 2 },
                new Employee { EmployeeId = 3, EmployeeDetailsId = 3, FirstName = "Jane", LastName = "Dough", JobRoleId = 3, GenderId = 2 },
                new Employee { EmployeeId = 4, EmployeeDetailsId = 4, FirstName = "Booklyn", LastName = "Street", JobRoleId = 4, GenderId = 2 },
                new Employee { EmployeeId = 5, EmployeeDetailsId = 5, FirstName = "Robin", LastName = "Steal'ums", JobRoleId = 5, GenderId = 2 },
                new Employee { EmployeeId = 6, EmployeeDetailsId = 6, FirstName = "Luke", LastName = "Skycrawler", JobRoleId = 1, GenderId = 1 },
                new Employee { EmployeeId = 7, EmployeeDetailsId = 7, FirstName = "Rob", LastName = "Banks", JobRoleId = 7, GenderId = 1 },
                new Employee { EmployeeId = 8, EmployeeDetailsId = 8, FirstName = "Resta", LastName = "Soul", JobRoleId = 8, GenderId = 1 },
                new Employee { EmployeeId = 9, EmployeeDetailsId = 9, FirstName = "Amir", LastName = "Shaw", JobRoleId = 9, GenderId = 1 },
                new Employee { EmployeeId = 10, EmployeeDetailsId = 10, FirstName = "Jack", LastName = "Daniels", JobRoleId = 9, GenderId = 1 }

                );
        }
    }
}
