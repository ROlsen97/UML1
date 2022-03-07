using System;
using System.Collections.Generic;
using System.Text;

namespace UML1
{
    class Customer
    {
        private string _name;

        public Customer(string name)
        {
            _name = name;
            
        }
        public string Name
        {
            get { return _name; }
        }
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
}
