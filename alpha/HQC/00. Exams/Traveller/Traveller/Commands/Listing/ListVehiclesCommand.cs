using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Commands.Listing.Abstracts;
using Traveller.Core;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class ListVehiclesCommand : ListCommand, ICommand
    {
        // Constructors
        public ListVehiclesCommand(IDatabase database)
            : base(database)
        {
        }

        // Methods
        public string Execute(IList<string> parameters)
        {
            var vehicles = this.database.Vehicles;

            if (vehicles.Count == 0)
            {
                return "There are no registered vehicles.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, vehicles);
        }
    }
}
