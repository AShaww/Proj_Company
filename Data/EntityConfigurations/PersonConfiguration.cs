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
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(a => a.PersonId);
            builder.HasOne(a => a.Address)
                .WithOne(a => a.Person);

            Seed(builder);
        }
        public void Seed(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person(1, 1)
                );
        }
    }
}
