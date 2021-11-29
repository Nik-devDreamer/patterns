using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class DinerMenuIterator : IIterator<MenuItem>
    {
        MenuItem[] list;
        int position = 0;
        public DinerMenuIterator(MenuItem[] list)
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
