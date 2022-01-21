using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class CafeMenu : IMenu
    {
        static int maxItems = 6;
        static int numberOfItems = 0;
        MenuItem[] menuItems;

        public CafeMenu()
        {
            menuItems = new MenuItem[maxItems];

            AddItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99);
            AddItem("Soup of the Day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69);
            AddItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= maxItems)
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public IIterator CreateIterator()
        {
            return new CafeMenuIterator(menuItems);
        }
    }
}
