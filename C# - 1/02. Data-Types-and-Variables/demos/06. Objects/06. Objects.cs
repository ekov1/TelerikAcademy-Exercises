using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Objects
{
    class Objects
    {
        static void Main(string[] args)
        {
            object dataContainer = 5;
            Console.WriteLine("The value of dataContainer is: {0}", dataContainer);

            dataContainer = "Five";
            Console.WriteLine("The value of dataContainer is: {0}", dataContainer);
            Console.WriteLine(dataContainer.GetType().Name);

            foreach (var item in dataContainer.GetType().GetMethods())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
