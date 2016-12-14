using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DailyMonitoringCMC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DailyMonitoringCMC.Models
{
    public class DailyMonitoringCMCContext : DbContext
    {    
        public DailyMonitoringCMCContext() : base("name=DailyMonitoringCMCContext")
        {
        }

        public DbSet<WindPark> WindParks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WindPark>().HasOptional(c => c.Connectioncontrol);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        }
    }

    
}
