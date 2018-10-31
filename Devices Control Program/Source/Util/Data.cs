using ControlDevice.Source.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_Control_Program.Source.Util
{
    class Data
    {     
        public static class User
        {
            public static String token = null;            
            public static List<Room> rooms;
            public static List<Device> device;
            public static List<Device> devices;            
        }
        public static List<String> roomIcon = JsonConvert.DeserializeObject<List<String>>("[\"BanCong.png\",\"bathtub.png\",\"bed.png\",\"boy2.png\",\"boy.png\",\"cooking.png\",\"flowers-pot-of-yard.png\",\"garage.png\",\"gate.png\",\"girl.png\",\"kitchen1.png\",\"livingroom.png\",\"toilet.png\",\"toilet2.png\",\"tv-table.png\",\"voice.png\",\"warehouse.png\",\"washing-machine.png\",\"washing-machine1.png\",\"window.png\"]");
    }
}
