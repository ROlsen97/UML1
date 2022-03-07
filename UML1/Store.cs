using System;
using System.Collections.Generic;
using System.Text;

namespace UML1
{
    public class Store
    {
        public void start()
        {
            Pizza p1 = new Pizza(69, "Margherita");
            Pizza p2 = new Pizza(75, "Vesuvio");
            Pizza p3 = new Pizza(80, "Capricciosa");

            Customer c1 = new Customer("Jens");
            Customer c2 = new Customer("Vibeke");
            Customer c3 = new Customer("Ruben");

            Order o1 = new Order(p1,c1);
            Order o2 = new Order(p2,c2);
            Order o3 = new Order(p3,c3);
            
            Console.WriteLine($"{o1}");
            Console.WriteLine($"{o2}");
            Console.WriteLine($"{o3}");
        }
    }
}
