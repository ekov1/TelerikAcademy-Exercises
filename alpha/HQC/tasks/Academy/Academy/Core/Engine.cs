using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Academy.Core
{
    public class Engine : IEngine
    {
        private static IEngine instanceHolder = new Engine();

        private const string TerminationCommand = "Exit";
        private const string NullProvidersExceptionMessage = "cannot be null.";
        private readonly StringBuilder builder = new StringBuilder();

        // Fields
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandsProcessor commandsProcessor;

        // Constructors
        public Engine(IReader reader, IWriter writer, ICommandsProcessor commandsProcessor)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandsProcessor = commandsProcessor;

            this.Seasons = new List<ISeason>();
            this.Students = new List<IStudent>();
            this.Trainers = new List<ITrainer>();
        }

        public static IEngine Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        // Property dependencty injection not validated for simplicity

        public IList<ISeason> Seasons { get; private set; }

        public IList<IStudent> Students { get; private set; }

        public IList<ITrainer> Trainers { get; private set; }


        public void Start()
        {
            while (true)
            {
                try
                {
                    var commandAsString = this.reader.ReadLine();

                    if (commandAsString == TerminationCommand)
                    {
                        this.writer.Write(this.builder.ToString());
                        break;
                    }

                    this.commandsProcessor.ProcessCommand(commandAsString);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    this.builder.AppendLine("Invalid command parameters supplied or the entity with that ID for does not exist.");
                }
                catch (Exception ex)
                {
                    this.builder.AppendLine(ex.Message);
                }
            }
        }
    }
}
