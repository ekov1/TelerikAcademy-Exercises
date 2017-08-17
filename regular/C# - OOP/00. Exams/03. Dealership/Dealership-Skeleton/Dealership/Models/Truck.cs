using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck, IVehicle
    {
        private int capacity;

        public Truck(string make, string model, decimal price, int capacity)
            : base(make, model, price)
        {
            this.WeightCapacity = capacity;
        }

        public int WeightCapacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                Validator.ValidateNull(value, "Capacity can not be null!");
                Validator.ValidateIntRange(value,
                    Constants.MinCapacity,
                    Constants.MaxCapacity,
                    string.Format(
                    Constants.NumberMustBeBetweenMinAndMax,
                    nameof(this.WeightCapacity),
                    Constants.MinCapacity,
                    Constants.MaxCapacity));
                this.capacity = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Truck;
            }
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Truck;
            }
        }
    }
}
