using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Listing.Abstracts
{
    public abstract class ListCommand
    {
        // Fields
        protected IDatabase database;

        // Constructors
        public ListCommand(IDatabase database)
        {
            this.database = database;
        }
    }
}
