﻿using System;
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

            Call c = new Call("123",100);

            Console.WriteLine(c.ToString());
        }
    }
}
