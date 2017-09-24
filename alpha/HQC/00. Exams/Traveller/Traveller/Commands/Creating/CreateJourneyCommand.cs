﻿using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Vehicles.Abstractions;

namespace Traveller.Commands.Creating
{
    public class CreateJourneyCommand : CreateCommand, ICommand
    {
        // Constructors
        public CreateJourneyCommand(IDatabase database, ITravellerFactory factory)
            : base(database, factory)
        {

        }
        // Metthods
        public string Execute(IList<string> parameters)
        {
            string startLocation;
            string destination;
            int distance;
            IVehicle vehicle;

            try
            {
                startLocation = parameters[0];
                destination = parameters[1];
                distance = int.Parse(parameters[2]);
                vehicle = this.database.Vehicles[int.Parse(parameters[3])];
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateJourney command parameters.");
            }

            var journey = this.factory.CreateJourney(startLocation, destination, distance, vehicle);
            this.database.Journeys.Add(journey);

            return $"Journey with ID {this.database.Journeys.Count - 1} was created.";
        }
    }
}
