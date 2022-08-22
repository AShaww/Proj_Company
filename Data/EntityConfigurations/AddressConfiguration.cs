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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.AddressId);
            builder.HasOne(a => a.Person).WithOne(a => a.Address);

            Seed(builder);
        }

        public void Seed(EntityTypeBuilder<Address> builder)
        {
            new Address(1, "31 something");
        }
    }
}
