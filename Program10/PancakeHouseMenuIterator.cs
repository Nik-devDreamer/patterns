using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        List<MenuItem> list;
        int position = 0;
        public PancakeHouseMenuIterator(List<MenuItem> list)
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
            if (position >= list.Count || list[position] == null)
                return false;
            else
                return true;
        }
    }
}
