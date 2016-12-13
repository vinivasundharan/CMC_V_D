using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyMonitoringCMC.Models
{
    public class DriveTrain
    {
        public int DriveTrainID { get; set; }
        public string DrivaTrainName { get; set; }
        public List<Node> Nodes { get; set; }
    }
}