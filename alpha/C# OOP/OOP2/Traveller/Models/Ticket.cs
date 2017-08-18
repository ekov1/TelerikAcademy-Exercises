using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Models.Contracts
{
    class Ticket : ITicket
    {
        private decimal administrativeCosts;

        public decimal AdministrativeCosts
        {
            get
            {
                return this.administrativeCosts;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("administrativeCosts can not be less than 0");
                }
            }
        }

        public IJourney Journey
        {
            get; private set;
        }

        // Methods
        public decimal CalculatePrice()
        {
            decimal travelCost = this.Journey.CalculateTravelCosts();
            return travelCost + this.AdministrativeCosts;
        }

        public override string ToString()
        {
            decimal price = CalculatePrice();
            return string.Format(@"Ticket ----
Destination: {0}
Price: {1}", this.Journey.Destination, price);
        }
    }
}
