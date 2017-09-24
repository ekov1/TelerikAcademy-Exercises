using Bytes2you.Validation;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class CreateCommand
    {
        // Fields
        protected IDatabase database;
        protected ITravellerFactory factory;

        // Constructors
        public CreateCommand(IDatabase database, ITravellerFactory factory)
        {
            Guard.WhenArgument(factory, "factory").IsNull().Throw();
            Guard.WhenArgument(database, "database").IsNull().Throw();

            this.database = database;
            this.factory = factory;
        }
    }
}
