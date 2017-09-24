using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateAirplaneCommand : CreateCommand, ICommand
    {
        // Constructors
        public CreateAirplaneCommand(IDatabase database, ITravellerFactory factory)
            : base(database, factory)
        {
        }

        // Metthods
        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            bool hasFreeFood;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                hasFreeFood = bool.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateAirplane command parameters.");
            }

            var airplane = this.factory.CreateAirplane(passengerCapacity, pricePerKilometer, hasFreeFood);
            this.database.Vehicles.Add(airplane);

            return $"Vehicle with ID {this.database.Vehicles.Count - 1} was created.";
        }
    }
}
