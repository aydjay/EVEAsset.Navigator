using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Navigator.DAL
{
    //Taken from https://damienbod.com/2016/01/11/asp-net-5-with-postgresql-and-entity-framework-7/
    public class DomainModelPostgreSqlContext : DbContext
    {
        public DomainModelPostgreSqlContext(DbContextOptions<DomainModelPostgreSqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            return base.SaveChanges();
        }
    }
}