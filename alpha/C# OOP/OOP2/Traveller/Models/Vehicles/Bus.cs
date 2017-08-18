using System;
using Traveller.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Bus : Vehicle, IBus, IVehicle
    {
        // Fields
        private int passangerCapacity;

        // Constructors
        public Bus(int passengerCapacity, decimal pricePerKilometer)
            : base(pricePerKilometer)
        {
            this.PassangerCapacity = passangerCapacity;
        }

        // Properties
        public override int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }

            set
            {
                ValidatePassangerCapacity(value);

                if (value < 10 || value > 50)
                {
                    throw new ArgumentOutOfRangeException(
                        "A bus cannot have less than 10 passengers or more than 50 passengers.");
                }

                this.passangerCapacity = value;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Land;
            }
        }

        // Methods
        public override string ToString()
        {
            return string.Format(@"Bus ----
Passenger capacity: {0}
Price per kilometer: {1}
Vehicle type: {2}", this.PassangerCapacity, this.PricePerKilometer, this.Type);
        }
    }
}
