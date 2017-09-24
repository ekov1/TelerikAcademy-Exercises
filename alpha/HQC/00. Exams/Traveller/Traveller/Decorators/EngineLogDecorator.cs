using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Core.Contracts;

namespace Traveller.Decorators
{
    public class EngineLogDecorator : IEngine
    {
        private readonly IEngine engine;

        public EngineLogDecorator(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start()
        {
            Console.WriteLine("The Engine is starting...");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            this.engine.Start();
            Console.WriteLine();
            Console.WriteLine("The Engine worked for {0} milliseconds.", sw.ElapsedTicks);
        }
    }
}
