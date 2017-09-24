﻿using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateTicketCommand : CreateCommand, ICommand
    {
        // Constructors
        public CreateTicketCommand(IDatabase database, ITravellerFactory factory)
            : base(database, factory)
        {
        }
        // Properties
        public IDatabase Database
        {
            get
            {
                return this.database;
            }
        }

        public ITravellerFactory Factory
        {
            get
            {
                return this.factory;
            }
        }

        // Metthods
        public string Execute(IList<string> parameters)
        {
            IJourney journey;
            decimal administrativeCosts;

            try
            {
                journey = this.database.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.factory.CreateTicket(journey, administrativeCosts);
            this.database.Tickets.Add(ticket);

            return $"Ticket with ID {this.database.Tickets.Count - 1} was created.";
        }
    }
}
