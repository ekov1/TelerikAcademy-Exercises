using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrimesInInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            List<int> primes = GetPrimes(100, 300);

            foreach (var prime in primes)
            {
                Console.Write("{0} ", prime);
                if (counter % 10 == 0)
                    Console.WriteLine();

                counter++;
            }
            Console.WriteLine();
        }

        private static List<int> GetPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();

            for (int num = start; num <= end; num++)
            {
                bool prime = true;

                for (int div = 2; div < Math.Sqrt(num); div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    primesList.Add(num);
                }
            }

            return primesList;
        }
    }
}
