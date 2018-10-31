using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace ControlDevice.Source.Data
{
    class InOut {
        public String name { get; set; }
        public int value { get; set; }
    }
    class Control
    {
        public List<InOut> @in { get; set; }
        public List<InOut> @out { get; set; }
    }
    class Device
    {
        public String id { get; set; }
        public String name { get; set; }
        public String type { get; set; }
        public String mac { get; set; }
        public String topic { get; set; }
        public long startRunning { get; set; }
        public Control controls;
        public String overPower { get; set; }
        public String roomID { get; set; }

        public bool isInput()
        {
            return null != controls.@in;
        }

        public bool isOutput()
        {
            return null != controls.@out;
        }

    }
}
