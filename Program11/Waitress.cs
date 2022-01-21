using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class Waitress
    {
        IMenu pancakeHouseMenu;
        IMenu dinnerMenu;
        IMenu cafeMenu;

        public Waitress(IMenu pancakeHouseMenu,
            IMenu dinnerMenu, IMenu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinnerMenu = dinnerMenu;
            this.cafeMenu = cafeMenu;
        }

        public string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();

            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinnerIterator = dinnerMenu.CreateIterator();
            IIterator cafeIterator = cafeMenu.CreateIterator();
            sb.Append("ALL MENUS, All menus combined\n----------------------\nPANCAKE HOUSE MENU, Breakfast\n----------------------\n");
            sb.Append(PrintMenu(pancakeIterator));
            sb.Append("\nDINER MENU, Lunch\n----------------------\n");
            sb.Append(PrintMenu(dinnerIterator));
            sb.Append("\nCAFE MENU, Dinner\n----------------------\n");
            sb.Append(PrintMenu(cafeIterator));

            return sb.ToString();
        }

        public string PrintMenu(IIterator iterator)
        {
            StringBuilder sb = new StringBuilder();
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();

                sb.Append(menuItem.name + ", ");
                sb.Append(menuItem.price + "\n" + "    -- ");
                sb.Append(menuItem.description + "\n");
            }

            return sb.ToString();
        }
    }
}
