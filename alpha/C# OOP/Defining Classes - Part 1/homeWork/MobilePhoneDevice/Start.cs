using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneDevice;
using static MobilePhoneDevice.Battery;

namespace MobilePhoneDevice
{
    class Start
    {
        static void Main(string[] args)
        {
            GSM one = new GSM("a", "a", new Battery("b", "b"), new Display("d", "d"));
            Display ds = new Display("ds", "ds", 0.5m);
            Battery b = new Battery("s", "m", BatteryType.LiIon);

            
        }
    }
}
