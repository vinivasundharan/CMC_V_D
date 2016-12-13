using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DailyMonitoringCMC.Models;

namespace DailyMonitoringCMC.Models
{
    public class DailyMonitoringCMCContext : DbContext
    {    
        public DailyMonitoringCMCContext() : base("name=DailyMonitoringCMCContext")
        {
        }

        public DbSet<WindPark> WindParks { get; set; }
    }
}
