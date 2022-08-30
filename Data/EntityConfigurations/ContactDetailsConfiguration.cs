using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityConfigurations
{
    public class ContactDetailsConfiguration : IEntityTypeConfiguration<EmployeeDetails>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetails> builder)
        {
            builder.HasKey(x => x.EmployeeDetailsId);
            builder.HasOne(x => x.Employee).WithOne(x => x.EmployeeDetail);
            Seed(builder);

        }
        public void Seed(EntityTypeBuilder<EmployeeDetails> builder)
        {
            builder.HasData(
                new EmployeeDetails { EmployeeDetailsId = 1, Address = "31 Street", MobileNumber = "+447982892893"},
                new EmployeeDetails { EmployeeDetailsId = 2, Address = "Flat 921a, Monty Road", MobileNumber = "+447982892893" },
                new EmployeeDetails { EmployeeDetailsId = 3, Address = "6 Sewer Lake", MobileNumber = "+447982892893" },
                new EmployeeDetails { EmployeeDetailsId = 4, Address = "2 Random Cave Entrance", MobileNumber = "+447982892893" },
                new EmployeeDetails { EmployeeDetailsId = 5, Address = "24 Bobs Hut", MobileNumber = "+447982892893" },
                new EmployeeDetails { EmployeeDetailsId = 6, Address = "53 Deck of Houses", MobileNumber = "+447982892893" },
                new EmployeeDetails { EmployeeDetailsId = 7, Address = "12 Word on the street", MobileNumber = "+447982892893"},
                new EmployeeDetails { EmployeeDetailsId = 8, Address = "534 Maybe Im good at this? Road", MobileNumber = "+447982892893" },
                new EmployeeDetails { EmployeeDetailsId = 9, Address = "92 Lavender park", MobileNumber = "+447982892893" },
                new EmployeeDetails { EmployeeDetailsId = 10, Address = "EYY 9b Hey mamba Lane", MobileNumber = "+447982892893" }

                );
        }
    }
}
