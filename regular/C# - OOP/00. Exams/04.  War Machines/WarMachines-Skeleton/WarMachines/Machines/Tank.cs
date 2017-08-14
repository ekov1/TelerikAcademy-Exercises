using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine,ITank, IMachine
    {
        public bool DefenseMode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ToggleDefenseMode()
        {
            throw new NotImplementedException();
        }
    }
}
