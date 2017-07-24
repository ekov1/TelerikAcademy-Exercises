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
            // gsmTest.GTest();

            GSM one = new GSM("mod", "manu");

            Console.WriteLine(one.CallHistory.Count);

            Call someCall = new Call("135", 100);
            Call two = new Call("6541651", 100);
            one.AddCall(someCall);
            Console.WriteLine(one.CallHistory.Count);
            one.AddCall(two);
            Console.WriteLine(one.CallHistory.Count);
            one.RemoveCall(two);
            Console.WriteLine(one.CallHistory.Count);
            one.ClearCallHistory();
            Console.WriteLine(one.CallHistory.Count);

        }
    }
}
