using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System.Collections.Generic;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle, ICommentable
    {
        private int wheels;
        private VehicleType type;
        private string make;
        private string model;
        private IList<IComment> comments;
        private decimal price;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.comments = new List<IComment>();
        }

        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                Validator.ValidateNull(value, "Comments should not be null");
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                Validator.ValidateNull(value, "Make must not be null!");
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinMakeLength,
                    Constants.MaxMakeLength,
                    string.Format(
                    Constants.StringMustBeBetweenMinAndMax,
                    nameof(this.Make),
                    Constants.MinMakeLength,
                    Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                Validator.ValidateNull(value, "Model can not be null or empty!");
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinModelLength,
                    Constants.MaxModelLength,
                    string.Format(
                    Constants.StringMustBeBetweenMinAndMax,
                    nameof(this.Model),
                    Constants.MinModelLength,
                    Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                Validator.ValidateNull(value, "Price can not be null or empty!");
                Validator.ValidateDecimalRange(
                    value,
                    Constants.MinPrice,
                    Constants.MaxPrice,
                    string.Format(
                    Constants.StringMustBeBetweenMinAndMax,
                    nameof(this.Price),
                    Constants.MinPrice,
                    Constants.MaxPrice));
                this.price = value;
            }
        }

        public abstract VehicleType Type
        {
            get;
        }

        public abstract int Wheels { get; }

    }
}
