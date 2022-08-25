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

            builder.HasOne(x => x.JobRole)
                .WithMany(x => x.Employees);

            Seed(builder);
        }
        public void Seed(EntityTypeBuilder<Employee> builder)
        {
            /* builder.HasData(
                *//* new Person(1, 1, "Amir", "Shaw")*//*
                 );*/
        }
    }
}
