using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models
{
    class Journey : IJourney
    {
        // Fields
        private string destination;
        private int distance;

        // Properties
        public string Destination
        {
            get
            {
                return this.destination;
            }

            private set
            {
                if (value.Length < 5 || value.Length > 25)
                {
                    throw new ArgumentException(
                        "The Destination's length cannot be less than 5 or more than 25 symbols long.");
                }

                this.destination = value;
            }
        }

        public int Distance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string StartLocation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IVehicle Vehicle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal CalculateTravelCosts()
        {
            throw new NotImplementedException();
        }
    }
}
