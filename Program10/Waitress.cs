using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator<MenuItem> dinerIterator = dinerMenu.CreateIterator();
            Console.WriteLine("Pancake menu");
            PrintMenu(pancakeIterator);
            Console.WriteLine();
            Console.WriteLine("Diner menu");
            PrintMenu(dinerIterator);
        }
        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine("{0} - {1}", menuItem.Name, menuItem.Price);
                Console.WriteLine("{0}", menuItem.Description);
            }
        }
    }
}
