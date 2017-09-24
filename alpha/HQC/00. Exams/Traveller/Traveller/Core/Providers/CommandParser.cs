using System.Collections.Generic;
using System.Linq;
using Traveller.Commands.Contracts;
using Traveller.Core.Factories;

namespace Traveller.Core.Providers
{
    public class CommandParser : IParser
    {
        // Fields
        private readonly ICommandFactory factory;

        // Constructors
        public CommandParser(ICommandFactory factory)
        {
            this.factory = factory;
        }

        // Methods
        public ICommand ParseCommand(string fullCommand)
        {
            var commandName = fullCommand.Split()[0];
            var command = this.factory.CreateCommand(commandName);
            //var commandTypeInfo = this.FindCommand(commandName);
            //var command = Activator.CreateInstance(commandTypeInfo) as ICommand;

            return command;
        }

        public IList<string> ParseParameters(string fullCommand)
        {
            var commandParts = fullCommand.Split().Skip(1).ToList();
            if (commandParts.Count == 0)
            {
                return new List<string>();
            }

            return commandParts;
        }

        //private TypeInfo FindCommand(string commandName)
        //{
        //    Assembly currentAssembly = this.GetType().GetTypeInfo().Assembly;
        //    var commandTypeInfo = currentAssembly.DefinedTypes
        //        .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
        //        .Where(type => type.Name.ToLower() == (commandName.ToLower() + "command"))
        //        .SingleOrDefault();

        //    if (commandTypeInfo == null)
        //    {
        //        throw new ArgumentException("The passed command is not found!");
        //    }

        //    return commandTypeInfo;
        //}
    }
}
