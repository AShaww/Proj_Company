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
            builder.ApplyConfiguration(new PersonConfiguration());
            builder.ApplyConfiguration(new AddressConfiguration());

        }
        public DbSet<Person> PersonList { get; set; }
        public DbSet<Address> AddressList { get; set; }

    }
}
