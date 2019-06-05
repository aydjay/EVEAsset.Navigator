using System;
using System.Collections.Generic;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Route>()
                .Property(e => e.NavigatedSystems)
                .HasConversion(v => string.Join(',', v),
                    v => ConvertToListInt(v));

            base.OnModelCreating(modelBuilder);
        }

        

        /// <summary>
        /// See: https://stackoverflow.com/questions/20711986/entity-framework-code-first-cant-store-liststring
        /// </summary>
        /// <param name="input">String of int's which represent solar systems in the SDE</param>
        /// <returns>List of int's which represen solar systems in the SDE</returns>
        private List<int> ConvertToListInt(string input)
        {
            var returnList = new List<int>();
            var items = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                if (int.TryParse(item, out int result))
                {
                    returnList.Add(result);
                }
            }

            return returnList;
        }

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