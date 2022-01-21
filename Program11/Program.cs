using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            CafeMenu cafeMenu = new CafeMenu();
            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

            dinerMenu.AddItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89);

            Console.WriteLine(waitress.PrintMenu());
            Console.ReadKey();
        }
    }
}
