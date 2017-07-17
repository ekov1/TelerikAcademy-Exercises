using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Move
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumF = 0, sumB = 0, steps, stepSize, nextP = 0;
            string line, direction;
            string[] words;
            int startingIndex = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            int p = startingIndex;

            do
            {
                line = Console.ReadLine();
                

                // Console.WriteLine(steps);
                // Console.WriteLine(stepSize);
                if (line != "exit")
                {
                    words = line.Split(' ').ToArray();

                    steps = int.Parse(words[0]);
                    direction = words[1];
                    stepSize = int.Parse(words[2]);

                    for (int i = 0; i < steps; i++)
                    {
                        if (direction == "forward")
                        {
                            for (i = 0; i < steps; i++)
                            {

                                nextP = p + stepSize;
                                if (nextP > numbers.Length - 1)
                                {
                                    p = nextP % numbers.Length;
                                }
                                else
                                {
                                    p = nextP;
                                }
                                    //    Console.Write("P="+numbers[p]+" ");
                                    //      Console.WriteLine();
                                sumF += numbers[p];

                            }
                        }
                        else
                        {
                            for (i = 0; i < int.Parse(words[0]); i++)
                            {
                                nextP = p - int.Parse(words[2]);
                                if (nextP < 0)
                                {
                                    if (-nextP > numbers.Length) nextP = nextP % numbers.Length;
                                    p = numbers.Length + nextP;
                                }
                                else
                                {
                                    p = nextP;
                                }
                                   //   Console.Write("P=" + numbers[p] + " ");
                                 //    Console.WriteLine();
                                sumB += numbers[p];
                            }
                        }

                    }
                }
                 

            } while (line != "exit");


            Console.WriteLine("Forward: {0}", sumF);
            Console.WriteLine("Backwards: {0}", sumB);
        }
    }
}
