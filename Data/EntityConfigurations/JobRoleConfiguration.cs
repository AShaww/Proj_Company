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
                new JobRole { JobRoleId = 1, JobTitle = "CEO" }
              /*  new JobRole { JobRoleId = 2, JobTitle = "CTO" },
                new JobRole { JobRoleId = 3, JobTitle = "C3PO" },
                new JobRole { JobRoleId = 4, JobTitle = "Manager" },
                new JobRole { JobRoleId = 5, JobTitle = "Supervisor" },
                new JobRole { JobRoleId = 6, JobTitle = "Contracted" },
                new JobRole { JobRoleId = 7, JobTitle = "In House" },
                new JobRole { JobRoleId = 8, JobTitle = "Associate" },
                new JobRole { JobRoleId = 9, JobTitle = "Nobody" }*/
                );
        }
    }
}
