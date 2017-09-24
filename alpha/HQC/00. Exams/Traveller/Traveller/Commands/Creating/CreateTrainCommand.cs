using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class CreateTrainCommand : CreateCommand, ICommand
    {
        // Constructors
        public CreateTrainCommand(IDatabase database, ITravellerFactory factory)
            : base(database, factory)
        {
        }

        // Metthods
        public string Execute(IList<string> parameters)
        {
            int passengerCapacity;
            decimal pricePerKilometer;
            int cartsCount;

            try
            {
                passengerCapacity = int.Parse(parameters[0]);
                pricePerKilometer = decimal.Parse(parameters[1]);
                cartsCount = int.Parse(parameters[2]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTrain command parameters.");
            }

            var train = this.factory.CreateTrain(passengerCapacity, pricePerKilometer, cartsCount);
            this.database.Vehicles.Add(train);

            return $"Vehicle with ID {this.database.Vehicles.Count - 1} was created.";
        }
    }
}
