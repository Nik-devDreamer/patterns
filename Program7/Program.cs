using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Program7.Adapter;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            var redheadDuck = new RedheadDuck();
            var rubberDuck = new RubberDuck();
            var woodDuck = new WoodDuck();
            var decoyDuck = new DecoyDuck();

            mallardDuck.Display();
            Console.WriteLine();

            redheadDuck.Display();
            Console.WriteLine();

            rubberDuck.Display();
            Console.WriteLine();

            woodDuck.Display();
            Console.WriteLine();

            decoyDuck.Display();
            Console.WriteLine();

            mallardDuck.Dead();
            mallardDuck.Display();
            Console.WriteLine();

            WildTurkey turkey = new WildTurkey();
            TurkeyAdapter adaptedTurkey = new TurkeyAdapter(turkey);
            adaptedTurkey.Fly();
            adaptedTurkey.Quack();

            Console.ReadKey();
        }
    }
}
