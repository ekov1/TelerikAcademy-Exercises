using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Traveller.Core.Contracts;
using Traveller.Core.Factories;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Commands.Creating
{
    public abstract class Command
    {
        private ITravellerFactory factory;
        private IList<string> commandParameters;
    

        public Command(IList<string> commandLine)
        {
            this.factory = TravellerFactory.Instance;
            this.CommandParameters = commandLine;
        }

        public ITravellerFactory Factory
        {
            get
            {
                return this.factory;
            }
        }

        public IList<string> CommandParameters
        {
            get
            {
                return this.commandParameters;
            }
            protected set
            {
                this.commandParameters = value;
            }
        }

        public abstract string Execute();
    }
}
