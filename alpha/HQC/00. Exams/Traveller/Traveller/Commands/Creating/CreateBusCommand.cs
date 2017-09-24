using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateBusCommand :CreateCommand, ICommand
    {
        // Constructors
        public CreateBusCommand(IDatabase database, ITravellerFactory factory)
            : base(database, factory)
        {
        }

        // Metthods
        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateBus command parameters.");
            }

            var bus = this.factory.CreateBus(passengerCapacity, pricePerKilometer);
            this.database.Vehicles.Add(bus);

            return $"Vehicle with ID {this.database.Vehicles.Count - 1} was created.";
        }
    }
}
