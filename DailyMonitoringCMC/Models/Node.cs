using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DailyMonitoringCMC.Models
{
    public class Node
    {
        public int NodeID { get; set; }
        public string NodeName { get; set; }

        public int DriveTrainID { get; set; }
        public virtual DriveTrain Drivetrain { get; set; }
    }
}