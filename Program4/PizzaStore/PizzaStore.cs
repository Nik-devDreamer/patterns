using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.pizza;

namespace Program4.pizzaStore
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
