using Traveller.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane, IVehicle
    {
        // Fields
        private int passangerCapacity;

        // Constructors
        public Airplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood)
            : base(pricePerKilometer)
        {
            this.PassangerCapacity = passangerCapacity;
            this.HasFreeFood = hasFreeFood;
        }

        // Properties
        public bool HasFreeFood
        {
            get; private set;
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

                this.passangerCapacity = value;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Air;
            }
        }
        // Methods
        public override string ToString()
        {
            return string.Format(@"Airplane ----
Passenger capacity: {0}
Price per kilometer: {1}
Vehicle type: {2}
Has free food: {3}", this.PassangerCapacity, this.PricePerKilometer, this.Type, this.HasFreeFood);
        }
    }
}
