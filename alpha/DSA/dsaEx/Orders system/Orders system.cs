using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders_system
{
  public  class Program
    {
        static List<Order> orders = new List<Order>();
        public class Order
        {
            public Order(string name, double price, string consumer)
            {
                this.Name = name;
                this.Price = price;
                this.Consumer = consumer;
            }

            public string Name { get; set; }
            public double Price { get; set; }
            public string Consumer { get; set; }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command;

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();

                if (command.Contains("AddOrder"))
                {
                    string[] commandParams = command.Split(';').ToArray();

                    string name = commandParams[0].Substring(9);
                    double price = double.Parse(commandParams[1]);
                    // Console.WriteLine(price);
                    string consumer = commandParams[2];
                    orders.Add(new Order(name, price, consumer));

                    Console.WriteLine("Order added");
                }

                if (command.Contains("DeleteOrders"))
                {
                    int counter = 0;
                    string[] commandParams = command.Split(' ').ToArray();
                    string name = commandParams[1];
                    if (commandParams.Length > 2)
                    {
                        name += " " + commandParams[2];
                    }
                    if (commandParams.Length > 3)
                    {
                        name += " " + commandParams[3];
                    }
                    for (int j = 0; j < orders.Count; j++)
                    {
                        if (orders[j].Consumer == name)
                        {
                            orders.Remove(orders[j]);
                            j--;
                            counter++;
                        }
                    }
                    if (counter > 0)
                    {
                        Console.WriteLine("{0} orders deleted", counter);
                        counter = 0;
                    }
                    else
                    {
                        Console.WriteLine("No orders found");
                    }
                }

                if (command.Contains("FindOrdersByConsumer"))
                {
                    List<Order> cOreders = new List<Order>();
                    string[] commandParams = command.Split(' ').ToArray();
                    string name = commandParams[1];
                    if (commandParams.Length > 2)
                    {
                        name += " " + commandParams[2];
                    }
                    if (commandParams.Length > 3)
                    {
                        name += " " + commandParams[3];
                    }
                    for (int j = 0; j < orders.Count; j++)
                    {
                        if (orders[j].Consumer == name)
                        {
                            cOreders.Add(orders[j]);
                        }
                    }

                    if (cOreders.Count > 0)
                    {
                        var sorted = cOreders.OrderBy(x => x.Name);
                        foreach (var order in sorted)
                        {
                            var price = string.Format("{0:F2}", order.Price);
                            Console.WriteLine("{" + order.Name + ";" + order.Consumer + ";" + price + "}");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" No orders found");
                    }

                }

                if (command.Contains("FindOrdersByPriceRange"))
                {
                    List<Order> pOreders = new List<Order>();
                    string[] commandParams = command.Split(';').ToArray();
                    string p1 = commandParams[0].Substring(23);
                    string p2 = commandParams[1];

                    double priceL = double.Parse(p1);
                    double priceM = double.Parse(p2);

                    for (int j = 0; j < orders.Count; j++)
                    {
                        double orderP = orders[j].Price;

                        if (priceL <= orderP && orderP <= priceM)
                        {
                            pOreders.Add(orders[j]);
                        }
                    }

                    if (pOreders.Count > 0)
                    {
                        var sorted = pOreders.OrderBy(x => x.Name);
                        foreach (var order in sorted)
                        {
                            var price = string.Format("{0:F2}", order.Price);
                            Console.WriteLine("{" + order.Name + ";" + order.Consumer + ";" + price + "}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No orders found");
                    }
                }

            }
        }
    }
}
