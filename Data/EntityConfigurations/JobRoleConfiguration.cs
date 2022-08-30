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
    public class JobRoleConfiguration : IEntityTypeConfiguration<JobRole>
    {
        public void Configure(EntityTypeBuilder<JobRole> builder)
        {
            builder.HasKey(x => x.JobRoleId);

            Seed(builder);
        }
        public void Seed(EntityTypeBuilder<JobRole> builder)
        {
            builder.HasData(
                new JobRole { JobRoleId = 1, JobRoleTitle = "CEO" }
                );
        }
    }
}
