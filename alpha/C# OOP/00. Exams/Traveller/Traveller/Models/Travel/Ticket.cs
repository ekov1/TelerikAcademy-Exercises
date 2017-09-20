using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;

namespace Traveller.Models.Travel
{
    public class Ticket : ITicket
    {
        // Fields
        protected decimal administrativeCosts;

        // Constructors
        public Ticket(IJourney journey, decimal administrativeCosts)
        {
            this.Journey = journey;
            this.AdministrativeCosts = administrativeCosts;
        }

        // Properties
        public decimal AdministrativeCosts
        {
            get
            {
                return this.administrativeCosts;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The AdministrativeCosts cannot be less than 0.00$");
                }
                this.administrativeCosts = value;
            }
        }

        public IJourney Journey { get; protected set; }

        // Methods
        public decimal CalculatePrice()
        {
            return this.Journey.CalculateTravelCosts() + this.AdministrativeCosts;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Ticket ----");
            sb.AppendLine($"Destination: {this.Journey.Destination}");
            sb.AppendLine($"Price: {this.CalculatePrice()}");

            return sb.ToString().TrimEnd();
        }
    }
}
