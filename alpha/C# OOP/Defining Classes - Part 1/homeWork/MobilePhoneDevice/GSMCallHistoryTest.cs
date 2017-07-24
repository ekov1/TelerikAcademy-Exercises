using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    // Problem 12. Call history test

    // Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.

    // Create an instance of the GSM class.
    // Add few calls.
    // Display the information about the calls.
    // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
    // Remove the longest call from the history and calculate the total price again.
    // Finally clear the call history and print it.
    class GSMCallHistoryTest
    {
        public static void HistoryTest()
        {
            GSM one = new GSM("mod", "manu");

            Console.WriteLine(one.CallHistory.Count);

            Call someCall = new Call("135", 100);
            Call two = new Call("6541651", 102);
            one.AddCall(someCall);
            Console.WriteLine(one.CallHistory.Count);
            one.AddCall(two);
            Console.WriteLine(one.CallHistory.Count);

            Console.WriteLine(one.CalcPriceOfCalls());

          
            Console.WriteLine(one.ToString());

            one.RemoveLongestCall();

            Console.WriteLine(one.ToString());

        }
    }
}
