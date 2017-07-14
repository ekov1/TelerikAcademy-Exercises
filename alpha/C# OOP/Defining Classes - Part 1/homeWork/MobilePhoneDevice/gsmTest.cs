using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MobilePhoneDevice.Battery;

namespace MobilePhoneDevice
{
    // Problem 7. GSM test

    // Write a class GSMTest to test the GSM class:
    // Create an array of few instances of the GSM class.
    // Display the information about the GSMs in the array.
    // Display the information about the static property IPhone4S.
    class gsmTest
    {
        public static void GTest()
        {
            GSM one = new GSM("titans2", "DooGee", 1200.99m, "the owner",
                new Battery("batModel", "batManufacturer", BatteryTypes.NiMH), 
                new Display("displModel", "displManufacturer"));
            Display ds = new Display("ds", "ds", 0.5m);
            Battery b = new Battery("s", "m", BatteryTypes.LiIon);
            //Battery ba = new Battery()

            // one.Model = "";
            // one.Manufacturer = "";
            // one.Price = -25;
            // one.Owner = "";

            // one.Battery.Manufacturer = "";
            // one.Battery.Model = "";

            // one.Display.Manufacturer = "";
            // one.Display.Model = "";

            // Console.WriteLine(one.ToString());

            GSM ip = GSM.iphone4s;

            GSM[] phones = { one, ip };

            foreach (var phone in phones)
            {
                Console.WriteLine(new string('x', 45));
                Console.WriteLine(phone.ToString());
            }
        }
    }
}
