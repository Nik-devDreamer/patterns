using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program7.Adapter
{
    public class TurkeyAdapter : ITurkey
    {
        private WildTurkey turkey;

        public TurkeyAdapter(WildTurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
                this.turkey.Fly();
        }

        public void Quack()
        {
            this.turkey.Gobble();
        }
    }
}
