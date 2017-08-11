namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;
    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {

        }

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
                    throw new ArgumentNullException("Name", "Name cannot be null");
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new NullReferenceException("Null machne can not be added");
            }
            this.machines.Add(machine);
        }

        public string Report()
        {
            throw new NotImplementedException();
        }
    }
}
