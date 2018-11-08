using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_Control_Program.Source.Util
{
    class DeviceSchedule
    {
        public string topic { get; set; }
        public string controls { get; set; }
    }

    class Schedule
    {
        public string id { get; set; }
        public string name { get; set; }
        public long time { get; set; }
        public List<DeviceSchedule> devices { get; set; }
    }
}
