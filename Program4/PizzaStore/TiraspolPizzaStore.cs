using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.pizza;
using Program4.PizzaIngredientFactory;

namespace Program4.pizzaStore
{
    public class TiraspolPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            IPizzaIngredientFactory IngredientFactory = new TiraspolPizzaIngredientFactory();
            switch (type)
            {
                case "Cheese": return new CheesePizza(IngredientFactory);
                case "Clam": return new ClamPizza(IngredientFactory);
                case "Pepperoni": return new PepperoniPizza(IngredientFactory);
                case "Veggie": return new VeggiePizza(IngredientFactory);
                default: return null;
            }
        }
    }
}
