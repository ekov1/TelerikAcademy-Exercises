using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models
{
    public class Journey : IJourney
    {
        // Fields
        private string destination;
        private int distance;
        private string startLocation;
        private IVehicle vehicle;

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
                    throw new ArgumentOutOfRangeException(
                        "The Destination's length cannot be less than 5 or more than 25 symbols long.");
                }

                this.destination = value;
            }
        }

        public int Distance
        {
            get
            {
                return this.distance;
            }

            private set
            {
                if (value < 5 || value > 5000)
                {
                    throw new ArgumentOutOfRangeException(
                        "The Distance cannot be less than 5 or more than 5000 kilometers.");
                }

                this.distance = value;
            }
        }

        public string StartLocation
        {
            get
            {
                return this.startLocation;
            }

            private set
            {
                if (value.Length < 5 || value.Length > 25)
                {
                    throw new ArgumentOutOfRangeException(
                        "The StartingLocation's length cannot be less than 5 or more than 25 symbols long.");
                }

                this.startLocation = value;
            }
        }

        public IVehicle Vehicle
        {
            get
            {
                return this.vehicle;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("vehicle can not be null");
                }

                this.vehicle = value;
            }
        }

        // Methods
        public decimal CalculateTravelCosts()
        {
            return distance * Vehicle.PricePerKilometer;
        }

        public override string ToString()
        {
            decimal travelCost = CalculateTravelCosts();
            return string.Format(@"Journey ----
Start location: {0}
Destination: {1}
Distance: {2}
Vehicle type: {3}
Travel costs: {4}", this.StartLocation, this.Destination, this.Distance, this.Vehicle.Type, travelCost);
        }


    }
}
