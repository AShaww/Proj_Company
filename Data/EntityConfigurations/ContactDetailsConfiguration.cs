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
    public class ContactDetailsConfiguration : IEntityTypeConfiguration<ContactDetails>
    {
        public void Configure(EntityTypeBuilder<ContactDetails> builder)
        {
            builder.HasKey(x => x.EmployeeDetailsId);
            builder.HasOne(x => x.Employee).WithOne(x => x.ContactDetails);
            Seed(builder);

            
        }

        public void Seed(EntityTypeBuilder<ContactDetails> builder)
        {
           /* new Address(1, "31 something"); */
        }
    }
}
