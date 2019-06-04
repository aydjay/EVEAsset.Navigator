using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Navigator.DAL.Navigator;

namespace Navigator.DAL
{
    //Taken from https://damienbod.com/2016/01/11/asp-net-5-with-postgresql-and-entity-framework-7/
    public class NavigatorContext : DbContext
    {
        private string _connectionString;

        public NavigatorContext(DbContextOptions<NavigatorContext> options) : base(options)
        {
        }

        public DbSet<Route> Routes {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_connectionString, 
                x => x.MigrationsAssembly("Navigator.Migrations"));

        public IServiceProvider ConfigureServices(IServiceCollection services, string connection)
        {
            _connectionString = connection;

            return services.AddEntityFrameworkNpgsql()
                .AddDbContext<NavigatorContext>()
                .BuildServiceProvider();
        }
    }
}