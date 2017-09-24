using Bytes2you.Validation;
using System;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Core
{
    public class Engine : IEngine
    {
        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";

        // Fields
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IDatabase database;
        private readonly ICommandProcessor commandProcessor;

        // Constructors
        public Engine(IReader reader, IWriter writer, IDatabase database, ICommandProcessor commandProcessor)
        {
            Guard.WhenArgument(reader, "reader").IsNull().Throw();
            Guard.WhenArgument(writer, "writer").IsNull().Throw();
            Guard.WhenArgument(commandProcessor, "commandProcessor").IsNull().Throw();
            Guard.WhenArgument(database, "database").IsNull().Throw();

            this.reader = reader;
            this.writer = writer;
            this.database = database;
            this.commandProcessor = commandProcessor;
        }

        // Methods
        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString.ToLower() == TerminationCommand.ToLower())
                    {
                        this.writer.Write(string.Join("\n", this.database.ExecutionResult));
                        break;
                    }

                    this.commandProcessor.ProcessCommand(commandAsString);
                }
                catch (Exception ex)
                {
                    this.database.ExecutionResult.Add(ex.Message);
                }
            }
        }

        //private void ProcessCommand(string commandAsString)
        //{
        //    if (string.IsNullOrWhiteSpace(commandAsString))
        //    {
        //        throw new ArgumentNullException("Command cannot be null or empty.");
        //    }

        //    var parser = new CommandParser();
        //    var command = parser.ParseCommand(commandAsString);
        //    var parameters = parser.ParseParameters(commandAsString);

        //    var executionResult = command.Execute(parameters);
        //    this.Builder.AppendLine(executionResult);
        //}
    }
}
