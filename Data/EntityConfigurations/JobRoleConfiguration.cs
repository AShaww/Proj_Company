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
                    new JobRole { JobRoleId = 1, JobRoleTitle = "Illuminati" },
                    new JobRole { JobRoleId = 2, JobRoleTitle = "CEO" },
                    new JobRole { JobRoleId = 3, JobRoleTitle = "CTO" },
                    new JobRole { JobRoleId = 4, JobRoleTitle = "C3PO" },
                    new JobRole { JobRoleId = 5, JobRoleTitle = "Head of Department" },
                    new JobRole { JobRoleId = 6, JobRoleTitle = "Manager" },
                    new JobRole { JobRoleId = 7, JobRoleTitle = "Supervisor" },
                    new JobRole { JobRoleId = 8, JobRoleTitle = "Lacky" },
                    new JobRole { JobRoleId = 9, JobRoleTitle = "Coffee Boy" }
                );
        }
    }
}
