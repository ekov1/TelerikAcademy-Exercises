using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System.Collections.Generic;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        public int wheels;
        private string make;
        private string model;
        private IList<IComment> comments;
        private decimal price;

        // Constructors
        public Vehicle(string make, string model, VehicleType type, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Type = type;
            this.Price = price;
            this.Comments = new List<IComment>();
        }


        // Properties
        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                //if (string.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Make should no be mull or white space!");
                //}

                Validator.ValidateNull(value, "Make must not be null");
                Validator.ValidateIntRange(value.Length,
                    Constants.MinMakeLength, Constants.MaxMakeLength,
                    string.Format(
                        Constants.StringMustBeBetweenMinAndMax,
                        // value,
                        // "Make",
                        nameof(this.Make),
                    Constants.MinMakeLength, Constants.MaxMakeLength));
            }
        }
        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                Validator.ValidateNull(value, "Comments must not be null");
                this.comments = value;
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
                Validator.ValidateNull(value, "Model must not be null");
                Validator.ValidateIntRange(value.Length,
                    Constants.MinModelLength, Constants.MaxModelLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(this.Model),
                    Constants.MinModelLength, Constants.MaxModelLength));
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
                //Validator.ValidateNull(value, "Price must not be null");
                Validator.ValidateDecimalRange(value,
                    Constants.MinPrice, Constants.MaxPrice,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, value,
                    Constants.MinPrice, Constants.MaxPrice));
            }
        }

        public VehicleType Type { get; private set; }

        public abstract int Wheels { get; }

    }
}
