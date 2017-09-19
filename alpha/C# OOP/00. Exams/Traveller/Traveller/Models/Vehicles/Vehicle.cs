using System;
using System.Text;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        // Fields
        private int passangerCapacity;
        private decimal pricePerKilometer;

        // Constructors
        public Vehicle(int passangerCapacity, decimal pricePerKilometer)
        {
            this.PassangerCapacity = passangerCapacity;
            this.PricePerKilometer = pricePerKilometer;
        }

        // Properties
        // default validation for every child class, if needed override in the future some of them
        public virtual int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }
            protected set
            {
                if (value < 1 || value > 800)
                {
                    throw new ArgumentOutOfRangeException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
                }
                this.passangerCapacity = value;
            }
        }

        public virtual decimal PricePerKilometer
        {
            get
            {
                return this.pricePerKilometer;
            }
            protected set
            {
                if (value < 0.10m || value > 2.50m)
                {
                    throw new ArgumentOutOfRangeException("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
                }
                this.pricePerKilometer = value;
            }
        }

        public abstract VehicleType Type { get; }

        protected abstract string VehicleName { get; }

        // Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.VehicleName}");
            sb.AppendLine($"Passenger capacity: {this.PassangerCapacity}");
            sb.AppendLine($"Price per kilometer: {this.PricePerKilometer}");
            sb.AppendLine($"Vehicle type: {this.Type}");

            return sb.ToString();
        }
    }
}
