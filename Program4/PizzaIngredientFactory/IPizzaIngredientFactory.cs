using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program4.Cheese;
using Program4.Dough;
using Program4.Clams;
using Program4.Pepperoni;
using Program4.Sauce;
using Program4.Veggies;

namespace Program4.PizzaIngredientFactory
{
    public interface IPizzaIngredientFactory
    {
        List<IVeggies> CreateVeggies();
        IDough CreateDough();
        ICheese CreateCheese();
        IPepperoni CreatePepperoni();
        ISauce CreateSauce();
        IClams CreateClams();
    }
}
