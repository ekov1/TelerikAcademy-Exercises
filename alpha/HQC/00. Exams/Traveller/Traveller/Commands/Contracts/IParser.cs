using System.Collections.Generic;

namespace Traveller.Commands.Contracts
{
    public interface IParser
    {
        ICommand ParseCommand(string fullCommand);

        IList<string> ParseParameters(string fullCommand);
    }
}
