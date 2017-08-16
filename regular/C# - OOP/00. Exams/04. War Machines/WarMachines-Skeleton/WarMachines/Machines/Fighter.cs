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
        private const int FighterInitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints,
            bool initialStealthMode)
            : base(name, FighterInitialHealthPoints, attackPoints, defensePoints)
        {
            this.StealthMode = initialStealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            string machineAsString = base.ToString();
            string stealthModeAsString = this.StealthMode ? ModeON : ModeOff;

            result.Append(machineAsString);
            result.AppendLine(string.Format(" *Stealth: {0}", stealthModeAsString));

            return result.ToString();
        }
    }
}
