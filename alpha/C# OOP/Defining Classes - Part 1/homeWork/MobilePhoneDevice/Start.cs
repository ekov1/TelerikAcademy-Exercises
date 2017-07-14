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
            GSM one = new GSM("titans2", "DooGee", 1200.99m, "the owner",
                new Battery("batModel", "batManufacturer"), new Display("displModel", "displManufacturer"));
            Display ds = new Display("ds", "ds", 0.5m);
            Battery b = new Battery("s", "m", BatteryTypes.LiIon);

            // one.Model = "";
            // one.Manufacturer = "";
            // one.Price = -25;
            // one.Owner = "";

            // one.Battery.Manufacturer = "";
            // one.Battery.Model = "";

            // one.Display.Manufacturer = "";
            // one.Display.Model = "";

            Console.WriteLine(one.ToString());
        }
    }
}
