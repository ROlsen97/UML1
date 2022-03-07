using System;
using System.Collections.Generic;
using System.Text;

namespace UML1
{
    class Pizza
    {
        
        public double _price;
        public double _tax=1.25;
        public double _delivery=40;
        public string _name;


        public Pizza (double price, string name)
        {
            _price = price;
            _name = name;
        }
        
        public double Price
        {
            get { return (_price*_tax)+_delivery; }
        }
        public string Name
        {
            get { return _name; }
        }
        public override string ToString()
        {
            return $"Pizza name : {Name} Price : {Price}";
        }
    }
}
