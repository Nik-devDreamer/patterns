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

            Console.ReadKey();
        }
    }
}
