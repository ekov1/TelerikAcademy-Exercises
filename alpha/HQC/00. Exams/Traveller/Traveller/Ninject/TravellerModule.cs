using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands;
using Traveller.Commands.Contracts;
using Traveller.Commands.Creating;
using Traveller.Core;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Core.Providers;
using Traveller.Decorators;

namespace Traveller.Ninject
{
    public class TravellerModule : NinjectModule
    {
        public override void Load()
        {
            
            this.Bind<IEngine>().To<Engine>().InSingletonScope().Named("originalEngine");
            this.Bind<IDatabase>().To<Database>().InSingletonScope();

            this.Bind<IReader>().To<ConsoleReader>().InSingletonScope();
            this.Bind<IWriter>().To<ConsoleWriter>().InSingletonScope();
            this.Bind<IParser>().To<CommandParser>().InSingletonScope();
            this.Bind<ICommandProcessor>().To<CommandProcessor>();

            this.Bind<ICommandFactory>().To<CommandFactory>().InSingletonScope();
            this.Bind<ITravellerFactory>().To<TravellerFactory>().InSingletonScope();

            this.Bind<ICommand>().To<CreateBusCommand>().Named("createbus");
            this.Bind<ICommand>().To<CreateAirplaneCommand>().Named("createairplane");
            this.Bind<ICommand>().To<CreateTrainCommand>().Named("createtrain");
            this.Bind<ICommand>().To<CreateJourneyCommand>().Named("createjourney");
            this.Bind<ICommand>().To<CreateTicketCommand>().Named("createticket");

            this.Bind<ICommand>().To<ListVehiclesCommand>().Named("listvehicles");
            this.Bind<ICommand>().To<ListJourneysCommand>().Named("listjourneys");
            this.Bind<ICommand>().To<ListTicketsCommand>().Named("listtickets");

            this.Bind<IEngine>().To<EngineLogDecorator>().Named("decorator")
                .WithConstructorArgument(this.Kernel.Get<IEngine>("originalEngine"));
        }
    }
}
