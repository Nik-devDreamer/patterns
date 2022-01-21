using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class CafeMenuIterator : IIterator
    {
        MenuItem[] list;
        int position = 0;

        public CafeMenuIterator(MenuItem[] list)
        {
            this.list = list;
        }

        public object Next()
        {
            MenuItem menuItem = list[position];
            position++;
            return menuItem;
        }

        public bool HasNext()
        {
            if (position >= list.Length || list[position] == null)
                return false;
            else
                return true;
        }
    }
}
