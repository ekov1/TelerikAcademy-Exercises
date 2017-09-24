using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Commands.Listing.Abstracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class ListJourneysCommand : ListCommand, ICommand
    {
        // Constructors
        public ListJourneysCommand(IDatabase database)
            :base(database)
        {
        }

        // Methods
        public string Execute(IList<string> parameters)
        {
            var journeys = this.database.Journeys;

            if (journeys.Count == 0)
            {
                return "There are no registered journeys.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, journeys);
        }
    }
}
