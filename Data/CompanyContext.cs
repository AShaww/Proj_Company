using Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContactDetailsConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new JobRoleConfiguration());

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<ContactDetails> ContactDetails { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
           
    }
}
