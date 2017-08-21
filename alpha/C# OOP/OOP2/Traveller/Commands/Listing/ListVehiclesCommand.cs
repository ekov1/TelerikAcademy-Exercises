﻿using System;
using System.Collections.Generic;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    // TODO
    class ListVehiclesCommand
    {
        private readonly ITravellerFactory factory;
        private readonly IEngine engine;

        public ListVehiclesCommand(ITravellerFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            var vehicles = this.engine.Vehicles;

            if (vehicles.Count == 0)
            {
                return "There are no vehicles tickets.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicles);
        }
    }
}
