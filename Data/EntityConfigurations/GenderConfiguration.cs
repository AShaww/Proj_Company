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
    public class GenderConfiguration: IEntityTypeConfiguration<Gender>
    {
public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(x => x.GenderId);

            Seed(builder);
        }
        public void Seed(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
                new Gender { GenderId = 1, GenderName = "Male"},
                new Gender { GenderId = 2, GenderName = "Female" }
                );
        }
    }
}
