using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        // Constructors
        public Airplane(int passangerCapacity, decimal pricePerKilometer, bool hasFreeFood)
            : base(passangerCapacity, pricePerKilometer)
        {
            this.HasFreeFood = hasFreeFood;
        }

        // Properties
        public override VehicleType Type
        {
            get
            {
                return VehicleType.Air;
            }
        }

        protected override string VehicleName
        {
            get
            {
                return "Airplane";
            }
        }

        public bool HasFreeFood { get; protected set; }

        // Methods
        public override string ToString()
        {
            return base.ToString() + $"Has free food: {this.HasFreeFood}".TrimEnd();
        }
    }
}
