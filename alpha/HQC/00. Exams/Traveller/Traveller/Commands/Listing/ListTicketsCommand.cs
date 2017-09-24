using System;
using System.Collections.Generic;
using Traveller.Commands.Contracts;
using Traveller.Commands.Listing.Abstracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public class ListTicketsCommand : ListCommand, ICommand
    {
        // Constructors
        public ListTicketsCommand(IDatabase database)
            : base(database)
        {
        }

        // Methods
        public string Execute(IList<string> parameters)
        {
            var tickets = this.database.Tickets;

            if (tickets.Count == 0)
            {
                return "There are no registered tickets.";
            }

            return string.Join(Environment.NewLine + "####################" + Environment.NewLine, tickets);
        }
    }
}
