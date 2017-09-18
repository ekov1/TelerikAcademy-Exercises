using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Commands.Contracts
{
    interface ICommandsProcessor
    {
        string ProcessCommand(string commandAsString);
    }
}
