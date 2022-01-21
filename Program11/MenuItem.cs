using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class MenuItem : MenuComponent
    {
        public string name;
        public string description;
        public bool vegetarian;
        public double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string Name()
        {
            return name;
        }

        public string Description()
        {
            return description;
        }

        public double Price()
        {
            return price;
        }

        public bool Vegetarian()
        {
            return vegetarian;
        }
    }
}
