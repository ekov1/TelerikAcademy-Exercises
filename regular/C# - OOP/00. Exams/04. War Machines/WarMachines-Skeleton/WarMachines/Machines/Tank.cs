using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank, IMachine
    {
        private const int TankInitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DeffensePointsModifier = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, TankInitialHealthPoints, attackPoints, defensePoints)
        { }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DeffensePointsModifier;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DeffensePointsModifier;
            }
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            string machineAsString = base.ToString();
            string defenseModeAsString = this.DefenseMode ? ModeON : ModeOff;

            result.AppendLine(machineAsString);
            result.AppendLine(string.Format(" *Defense: {0}", defenseModeAsString));

            return result.ToString();
        }
    }
}
