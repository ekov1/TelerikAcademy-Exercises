using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreatevehicleCommand : ICommand
    {
        // Fields
        protected readonly ITravellerFactory factory;
        protected readonly IEngine engine;

        // Constructors
        public CreatevehicleCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        // Methods
        protected abstract IVehicle CreateVehicle(IList<string> parameters);

        public string Execute(IList<string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}