using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.PizzaIngredientFactory;

namespace Program4.pizza
{
    class PepperoniPizza : Pizza
    {
        public IPizzaIngredientFactory Factory;

        public PepperoniPizza(IPizzaIngredientFactory IngredientFactory)
        {
            Factory = IngredientFactory;
        }

        public override string Prepare()
        {
            Name = "Pepperoni Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Cheese = Factory.CreateCheese();

            StringBuilder str = new StringBuilder();
            str.Append(Dough.Display() + "\n");
            str.Append(Sauce.Display() + "\n");
            str.Append(Cheese.Display() + "\n");
            return str.ToString();
        }
    }
}
