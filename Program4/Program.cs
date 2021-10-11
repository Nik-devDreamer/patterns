using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.pizzaStore;
using Program4.pizza;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore benderPizzaStore = new BenderPizzaStore();
            PizzaStore tiraspolPizzaStore = new TiraspolPizzaStore();

            Pizza pizza = benderPizzaStore.OrderPizza("Cheese");
            Console.Write(pizza.Prepare());
            Console.WriteLine("{0} is ready", pizza.Name);
            Console.WriteLine();

            pizza = tiraspolPizzaStore.OrderPizza("Pepperoni");
            Console.Write(pizza.Prepare());
            Console.WriteLine("{0} is ready", pizza.Name);
            Console.ReadKey();
        }
    }
}
