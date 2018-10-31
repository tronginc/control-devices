using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_Control_Program.Source.Util
{
    class MqttMessage
    {
        public int type { get; set; }
        public List<int> data { get; set; }
    }
}
