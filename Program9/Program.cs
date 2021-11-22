using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            Tea tea = new Tea();

            Console.WriteLine("Coffe");
            coffee.PrepareRecipe();
            Console.WriteLine();

            Console.WriteLine("Tea");
            tea.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
