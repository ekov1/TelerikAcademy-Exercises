using System;
using Traveller.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Train : Vehicle, ITrain, IVehicle
    {
        // Fields
        private int carts;
        private int passangerCapacity;

        // Constructors
        public Train(int passengerCapacity, decimal pricePerKilometer, int carts)
            : base(pricePerKilometer)
        {
            this.PassangerCapacity = passangerCapacity;
            this.Carts = carts;
        }

        // Properties
        public int Carts
        {
            get
            {
                return this.carts;
            }

            private set
            {
                if (value < 1 || value > 15)
                {
                    throw new ArgumentOutOfRangeException("A train cannot have less than 1 cart or more than 15 carts.");
                }

                this.carts = value;
            }
        }

        public override int PassangerCapacity
        {
            get
            {
                return this.passangerCapacity;
            }

            set
            {
                // ValidatePassangerCapacity(value);

                if (value < 30 || value > 150)
                {
                    throw new ArgumentOutOfRangeException(
                        "A train cannot have less than 30 passengers or more than 150 passengers.");
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
            return string.Format(@"Train ----
Passenger capacity: {0}
Price per kilometer: {1}
Vehicle type: {2}
Carts amount: {3}", this.PassangerCapacity, this.PricePerKilometer, this.Type, this.Carts);
        }
    }
}
