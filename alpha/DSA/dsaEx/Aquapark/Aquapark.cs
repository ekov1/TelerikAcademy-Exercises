using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark
{
    class Aquapark
    {
        static Queue<string> q = new Queue<string>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command;

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();
                if(command == "print")
                {
                    var q2 = q.Reverse();
                    Console.WriteLine(string.Join(" ", q2));
                }
                else
                {
                    string[] commandParams = command.Split(' ').ToArray();
                    switch (commandParams[0])
                    {
                        case "add":
                            q.Enqueue(commandParams[1]);
                            Console.WriteLine("Added {0}", commandParams[1]);
                            break;

                        case "slide":
                            for (int j = 0; j < int.Parse(commandParams[1]); j++)
                            {
                                var person = q.Dequeue();
                                q.Enqueue(person);
                            }
                            Console.WriteLine("Slided {0}", commandParams[1]);
                            break;
                    }
                }
               
            }
        }
    }
}
