namespace WarMachines.Machines
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        public double AttackPoints { get; private set; }

        public double DefensePoints { get; private set; }

        public double HealthPoints { get; set; }


        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Machine name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Engaged pilot name cannot be null");
                }
                this.pilot = value;
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
    }
}
