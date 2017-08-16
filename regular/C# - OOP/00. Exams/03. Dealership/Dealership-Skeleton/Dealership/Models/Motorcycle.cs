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
    class Motorcycle : Vehicle, IMotorcycle, IVehicle
    {
        private string category;

        public Motorcycle(string make, string model, VehicleType type, decimal price)
            : base(make, model, type, price)
        {

        }
        public string Category
        {
            get
            {
                return this.category;
            }

            private set
            {
                Validator.ValidateNull(value, "Category can not be null!");
                Validator.ValidateIntRange(value.Length,
                    Constants.MinCategoryLength,
                    Constants.MaxCategoryLength,
                    string.Format(
                    Constants.StringMustBeBetweenMinAndMax,
                    nameof(this.Category),
                    Constants.MinCategoryLength,
                    Constants.MaxCategoryLength));
                this.category = value;
            }
        }

        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Motorcycle;
            }
        }
    }
}
