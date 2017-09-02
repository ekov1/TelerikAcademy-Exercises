using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_loves_paper
{
    class Program
    {
        static LinkedList<int> number = new LinkedList<int>();
        static int n;
        static List<int> lost = new List<int>();

        /// <summary>
        /// 5
        /// 2 is after 1
        /// 2 is before 4
        /// 4 is after 3
        /// 4 is before 6
        /// 8 is after 6
        /// </summary>
        private static void ReadDigits()
        {
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();

                int dig1 = int.Parse(line[0]);
                int dig2 = int.Parse(line[3]);
                string condition = line[2];

                if (!number.Contains(dig1) && !number.Contains(dig2) && number.Count == 0)
                {
                    if (condition == "after")
                    {
                        number.AddFirst(dig2);
                        number.AddLast(dig1);
                    }
                    if (condition == "before")
                    {
                        number.AddFirst(dig1);
                        number.AddLast(dig2);
                    }
                }

                if (!number.Contains(dig1) && !number.Contains(dig2) && number.Count > 0)
                {
                    if (condition == "after")
                    {
                        foreach (var dg in number)
                        {
                            if (dg < dig2)
                            {
                                continue;
                            }
                            else if (dg > dig2)
                            {
                                var node = number.Find(dg);
                                number.AddBefore(node, dig2);
                                break;
                            }
                            else
                            {
                                number.AddFirst(dig1);
                                number.AddFirst(dig2);
                            }
                        }

                        if (number.Contains(dig2) && !number.Contains(dig1))
                        {
                            var node = number.Find(dig2);
                            number.AddAfter(node, dig1);
                        }
                    }
                    if (condition == "before")
                    {
                        foreach (var dg in number)
                        {
                            if (dg < dig1)
                            {
                                continue;
                            }
                            else if (dg > dig1)
                            {
                                var node = number.Find(dg);
                                number.AddBefore(node, dig1);
                                break;
                            }
                            else
                            {
                                number.AddFirst(dig2);
                                number.AddFirst(dig1);
                            }
                        }

                        if (!number.Contains(dig2) && number.Contains(dig1))
                        {
                            var node = number.Find(dig1);
                            number.AddAfter(node, dig2);
                        }
                    }
                }

                

                //if (lost > 0)
                //{

                //    foreach (var dg in number)
                //    {
                //        if (dg < lost && dg != x)
                //        {
                //            continue;
                //        }
                //        else if (dg > lost && dg != x)
                //        {
                //            var node = number.Find(dg);
                //            number.AddBefore(node, lost);
                //            break;
                //        }
                //        else
                //        {
                //            number.AddLast(lost);
                //        }
                //    }
                //    lost = -1;
                //}

                if (!number.Contains(dig1) && number.Contains(dig2))
                {
                    var node = number.Find(dig2);
                    if (condition == "after")
                    {
                        number.AddAfter(node, dig1);
                    }
                    else if (condition == "before" && number.First.Value == 0)
                    {
                        number.AddFirst(dig1);
                    }
                    if (condition == "before")
                    {
                        number.AddBefore(node, dig1);
                    }
                }

                if (number.Contains(dig1) && !number.Contains(dig2))
                {
                    var node = number.Find(dig1);
                    if (condition == "after")
                    {
                        number.AddBefore(node, dig2);
                    }
                    else if (condition == "after" && number.First.Value == 0)
                    {
                        number.AddFirst(dig2);
                    }
                    else if (condition == "before")
                    {
                        number.AddAfter(node, dig2);
                    }
                }


                if (!number.Contains(dig1) && !number.Contains(dig2) && number.Count > 0
                   && number.First.Value == 0)
                {
                    if (condition == "before")
                    {
                        number.AddFirst(dig1);
                        lost.Add(dig2);
                    }
                    if (condition == "after")
                    {
                        number.AddFirst(dig2);
                        lost.Add(dig1);
                    }

                }
              //  Console.WriteLine(string.Join("", number));
            }
        }

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            ReadDigits();
            List<int> wtf = number.ToList();
            foreach (var num in lost)
            {
                for (int i = wtf.Count - 1; i > 1; i--)
                {
                    if (num > wtf[i])
                    {
                        var node = number.Find(wtf[i]);
                        number.AddAfter(node, num);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join("", number));
        }


    }
}
