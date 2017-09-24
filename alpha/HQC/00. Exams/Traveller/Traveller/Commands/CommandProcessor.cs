using Bytes2you.Validation;
using System;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands
{
    public class CommandProcessor : ICommandProcessor
    {
        // Fields
        private readonly IParser parser;
        //private readonly IWriter writer;
        private readonly IDatabase database;

        // Constructors
        public CommandProcessor(IParser parser, IDatabase database)
        {
            Guard.WhenArgument(parser, "parser").IsNull().Throw();
            Guard.WhenArgument(database, "database").IsNull().Throw();

            this.database = database;
            this.parser = parser;
        }

        // Methods
        public void ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrWhiteSpace(commandAsString))
            {
                throw new ArgumentNullException("Command cannot be null or empty.");
            }

            var command = this.parser.ParseCommand(commandAsString);
            var parameters = this.parser.ParseParameters(commandAsString);

            var executionResult = command.Execute(parameters);
            //this.writer.Write(executionResult);

            this.database.ExecutionResult.Add(executionResult);
        }
    }
}
