using Asp.NetCoreControlsDemo.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreControlsDemo.UI.Repositry
{
    public class DevDBContext : DbContext
    {
        public DevDBContext()
        {
        }

        public DevDBContext(DbContextOptions<DevDBContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot config = builder.Build();            
            optionsBuilder.UseSqlServer("server=192.168.0.30;Database=IBSERPDB_DEV;Trusted_Connection=false;User ID=sa;Password=$Q|@123");
        }

        public DbSet<LookUpMeetingRoom> LookUpMeetingRoom { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
