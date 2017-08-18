using System;
using Traveller.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        // Fields
        protected decimal pricePerKilometer;

        // Constructors
        public Vehicle(decimal pricePerKilometer)
        {
            this.PricePerKilometer = pricePerKilometer;
        }

        // Properties
        public abstract int PassangerCapacity
        {
            get; set;
        }

        public decimal PricePerKilometer
        {
            get
            {
                return this.pricePerKilometer;
            }

            set
            {
                if (value < 0.10m || value > 2.50m)
                {
                    throw new ArgumentException(
                        "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
                }

                this.pricePerKilometer = value;
            }
        }

        public abstract VehicleType Type
        {
            get;
        }

        // Methods
        protected void ValidatePassangerCapacity(int value)
        {
            if (value < 1 || value > 800)
            {
                throw new ArgumentOutOfRangeException(
                    "A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
            }
        }
    }
}
