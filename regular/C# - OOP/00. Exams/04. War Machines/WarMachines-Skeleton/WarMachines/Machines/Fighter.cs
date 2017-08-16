using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IMachine, IFighter
    {
        public bool StealthMode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ToggleStealthMode()
        {
            throw new NotImplementedException();
        }
    }
}
