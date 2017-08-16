using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar, IVehicle
    {
        private int seats;

        public Car(string make, string model, VehicleType type, decimal price, int seats)
            : base(make, model, type, price)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }

            private set
            {
                Validator.ValidateNull(value, "Seats can not be null!");
                Validator.ValidateIntRange(value,
                    Constants.MinSeats,
                    Constants.MaxSeats,
                    string.Format(
                    Constants.NumberMustBeBetweenMinAndMax,
                    nameof(this.Seats),
                    Constants.MinSeats,
                    Constants.MaxSeats));
                this.seats = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Car;
            }
        }
    }
}
