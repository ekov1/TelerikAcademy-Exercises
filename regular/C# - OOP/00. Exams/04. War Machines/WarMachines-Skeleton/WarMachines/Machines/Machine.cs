namespace WarMachines.Machines
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a machine...
    /// </summary>
    public abstract class Machine : IMachine
    {
        // Fields
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        // Constructors
        public Machine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
        }

        // Properties
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
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("Target cannot be null or empty!");
            }

            this.targets.Add(target);
        }
    }
}
