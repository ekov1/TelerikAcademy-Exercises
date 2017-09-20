using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreateVehicleCommand : ICommand
    {
        // Fields
        protected readonly ITravellerFactory factory;
        protected readonly IEngine engine;

        // Constructors
        public CreateVehicleCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        // Methods
        protected abstract IVehicle CreateVehicle(IList<string> parameters);

        public string Execute(IList<string> parameters)
        {
            IVehicle vehicle = this.CreateVehicle(parameters);

            this.engine.Vehicles.Add(vehicle);

            return $"Vehicle with ID {engine.Vehicles.Count - 1} was created.";
        }
    }
}