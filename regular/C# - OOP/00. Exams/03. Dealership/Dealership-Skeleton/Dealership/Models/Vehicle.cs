using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        public int wheels;
        private string make;
        private string model;
        private IList<IComment> comments;
        private decimal price;

        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Make should no be mull or white space!");
                }
            }
        }
        public IList<IComment> Comments
        {
            get
            {
                throw new NotImplementedException();
            }
        }



        public string Model
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public VehicleType Type { get; private set; }

        public abstract int Wheels { get; }

    }
}
