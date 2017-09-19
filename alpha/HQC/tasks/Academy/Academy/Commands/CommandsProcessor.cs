using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Commands
{
    public class CommandsProcessor : ICommandsProcessor
    {
        // Fields
        private readonly IParser parser;

        // Constructors
        public CommandsProcessor(IParser parser)
        {
            this.parser = parser;
        }

        // Methods
        public string ProcessCommand(string commandAsString)
        {
            if (string.IsNullOrEmpty(commandAsString))
            {
                throw new ArgumentNullException("command CAN NOT be null");
            }

            var command = this.parser.ParseCommand(commandAsString);
            var commandParams = this.parser.ParseParameters(commandAsString);

            var resultOfExecution = command.Execute(commandParams);

            return resultOfExecution;
        }
    }
}
