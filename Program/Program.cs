using System;

namespace Program
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

            Console.WriteLine("Крякающая утка:");
            mallardDuck.Display();
            Console.WriteLine();

            Console.WriteLine("Рыжая утка:");
            redheadDuck.Display();
            Console.WriteLine();

            Console.WriteLine("Резиновая утка:");
            rubberDuck.Display();
            Console.WriteLine();

            Console.WriteLine("Деревянная утка:");
            woodDuck.Display();
            Console.WriteLine();

            Console.WriteLine("Ложная утка:");
            woodDuck.Display();
            Console.WriteLine();

            Console.WriteLine("Крякающая утка:");
            mallardDuck.Dead();
            mallardDuck.Display();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
