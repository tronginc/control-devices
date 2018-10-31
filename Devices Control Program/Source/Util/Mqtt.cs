using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;

namespace Devices_Control_Program.Source.Util
{
    class Mqtt
    {
        public static MqttClient client = new MqttClient("iot.eclipse.org");         
    }
}
