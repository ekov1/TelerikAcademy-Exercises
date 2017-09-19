using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Commands.Contracts
{
    public interface ICommandsProcessor
    {
        string ProcessCommand(string commandAsString);
    }
}
