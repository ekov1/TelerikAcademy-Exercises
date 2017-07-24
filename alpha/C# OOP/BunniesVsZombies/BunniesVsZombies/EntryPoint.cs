using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunniesVsZombies
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Bunny b = new Bunny("Pesho", 150, BunnyBreed.Fuzzy);
            b.Name = "b";
           // b.Breed = BunnyBreed.Wuzzy;
        }
    }
}
