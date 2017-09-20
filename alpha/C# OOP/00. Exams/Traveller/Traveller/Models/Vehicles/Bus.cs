using System;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Bus : Vehicle, IBus
    {
        // Fields
        int passangerCapacity;

        // Constructors
        public Bus(int passangerCapacity, decimal pricePerKilometer)
            : base(passangerCapacity, pricePerKilometer)
        {
        }

        // Properties
        public override VehicleType Type
        {
            get
            {
                return VehicleType.Land;
            }
        }

        protected override string VehicleName
        {
            get
            {
                return "Bus";
            }
        }

        public override int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }
            protected set
            {
                if (value < Constants.BusMinPassangers || value > Constants.BusMaxPassangers)
                {
                    throw new ArgumentOutOfRangeException($"A bus cannot have less than {Constants.BusMinPassangers} passengers or more than {Constants.BusMaxPassangers} passengers.");
                }
                this.passangerCapacity = value;
            }
        }

        // Methods
        public override string ToString()
        {
            return base.ToString().TrimEnd();
        }
    }
}
