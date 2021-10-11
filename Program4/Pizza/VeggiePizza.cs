using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.PizzaIngredientFactory;

namespace Program4.pizza
{
    class VeggiePizza : Pizza
    {
        public IPizzaIngredientFactory Factory;

        public VeggiePizza(IPizzaIngredientFactory IngredientFactory)
        {
            Factory = IngredientFactory;
        }

        public override string Prepare()
        {
            Name = "Veggie Pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSauce();
            Cheese = Factory.CreateCheese();
            Clams = Factory.CreateClams();

            StringBuilder str = new StringBuilder();
            str.Append(Dough.Display() + "\n");
            str.Append(Sauce.Display() + "\n");
            str.Append(Cheese.Display() + "\n");
            str.Append(Clams.Display() + "\n");
            return str.ToString();
        }
    }
}
