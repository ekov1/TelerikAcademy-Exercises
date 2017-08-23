using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPower
{

    class FastPower
    {
        const int MOD = 1000000007;
        // a^p * % mod
        static long PowerMod(long a, long p)
        {
            if (p == 0)
            {
                return 1;
            }

            if (p % 2 == 1)
            {
                return PowerMod(a, p - 1) * a % MOD;
            }
            a = PowerMod(a, p / 2);
            return a * a % MOD;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PowerMod(2, 10));
        }
    }
}
