using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IMachine , IFighter
    {
        public double AttackPoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public double DefensePoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public double HealthPoints
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IPilot Pilot
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool StealthMode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IList<string> Targets
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Attack(string target)
        {
            throw new NotImplementedException();
        }

        public void ToggleStealthMode()
        {
            throw new NotImplementedException();
        }
    }
}
