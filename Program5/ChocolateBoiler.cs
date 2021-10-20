using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5
{
    class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler uniqueInstance;
        private static object LockThis = new object();

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance() 
        {
            if (uniqueInstance == null)
            {
                lock (LockThis)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new ChocolateBoiler();
                    }
                }
            }
		    return uniqueInstance;
	    }

        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Fill the boiler");
            }
        }

        public void drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                Console.WriteLine("Drain");
            }
        }

        public void boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("Boil");
            }
        }
    }
}
