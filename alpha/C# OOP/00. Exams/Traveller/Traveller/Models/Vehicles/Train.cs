using System;
using System.Text;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Train : Vehicle, ITrain
    {
        // Fields
        private int passangerCapacity;
        private int carts;

        // Constructors
        public Train(int passangerCapacity, decimal pricePerKilometer, int carts)
            : base(passangerCapacity, pricePerKilometer)
        {
            this.Carts = carts;
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
                return "Train";
            }
        }

        public int Carts
        {
            get
            {
                return this.carts;
            }
            protected set
            {
                if (value < Constants.CartMinCount || value > Constants.CartMaxCount)
                {
                    throw new ArgumentOutOfRangeException($"A train cannot have less than {Constants.CartMinCount} cart or more than {Constants.CartMaxCount} carts.");
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
            protected set
            {
                if (value < Constants.TrainMinPassangers || value > Constants.TrainMaxPassangers)
                {
                    throw new ArgumentOutOfRangeException($"A train cannot have less than {Constants.TrainMinPassangers} passengers or more than {Constants.TrainMaxPassangers} passengers.");
                }
                this.passangerCapacity = value;
            }
        }

        // Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Carts amount: {this.Carts}");

            return sb.ToString().TrimEnd();
        }
    }
}
