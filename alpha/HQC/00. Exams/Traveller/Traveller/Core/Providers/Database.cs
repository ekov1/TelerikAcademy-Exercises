﻿using System.Collections.Generic;
using Traveller.Core.Contracts;
using Traveller.Models.Abstractions;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Core.Providers
{
    public class Database : IDatabase
    {
        // Constructors
        public Database()
        {
            this.Vehicles = new List<IVehicle>();
            this.Journeys = new List<IJourney>();
            this.Tickets = new List<ITicket>();
            this.ExecutionResult = new List<string>();
        }

        // Properties
        public IList<IVehicle> Vehicles { get; }

        public IList<IJourney> Journeys { get; }

        public IList<ITicket> Tickets { get; }

        public IList<string> ExecutionResult { get; }
    }
}
