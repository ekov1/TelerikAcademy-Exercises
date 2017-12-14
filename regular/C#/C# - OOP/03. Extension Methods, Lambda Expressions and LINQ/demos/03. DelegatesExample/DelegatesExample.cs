using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DelegatesExample
{
    class DelegatesExample
    {
        // Declaration of a delegate
        public delegate void SimpleDelegate(string param);

        private static void TestMethod(string param)
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I got parameter: {0}.", param);
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate
            SimpleDelegate d = new SimpleDelegate(TestMethod);

            // The above can be written in a shorter way
            d = TestMethod;

            // Invocation of the method, pointed by delegate
            d("test");
        }


    }
}
