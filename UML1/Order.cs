using System;
using System.Collections.Generic;
using System.Text;

namespace UML1
{
    class Order
    {
        private double _pizzaprice;
        private string _name;
        private string _pizzaname;

        public Order(Pizza pizza, Customer customer)
        {
            _pizzaprice = pizza.Price;
            _name = customer.Name;
            _pizzaname = pizza.Name;
        }
        public override string ToString()
        {
            return $"Name of pizza is {_pizzaname}, Price of the order (incl. tax and delivery) is {_pizzaprice}DKK, Name of customer is {_name}";
        }
    }
}
