using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public abstract class MenuComponent
    {
        public void Add(MenuComponent menuComponent)
        {
            throw new UnSupportedOperationException();
        }

        public void Remove(MenuComponent menuComponent)
        {
            throw new UnSupportedOperationException();
        }

        public MenuComponent getChild(int i)
        {
            throw new UnSupportedOperationException();
        }

        public string getName()
        {
            throw new UnSupportedOperationException();
        }

        public string getDescription()
        {
            throw new UnSupportedOperationException();
        }

        public double getPrice()
        {
            throw new UnSupportedOperationException();
        }

        public bool isVegetarian()
        {
            throw new UnSupportedOperationException();
        }
    }
}
