using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DailyMonitoringCMC.Models
{
    public class WindMill
    {
        public int WindMillID { get; set; }
        [Display(Name = "Description/Message")]
        public string WindMillName { get; set; }
        public int WindParkID { get; set; }
        public int ConnectionControlID { get; set; }
        public virtual WindPark Windpark { get; set; }
        public virtual ConnectionControl Connectioncontrol { get; set; }
    }
}