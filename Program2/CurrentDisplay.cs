using System;

namespace WD.Subscriber
{
    public class CurrentDisplay : ISubscriber
    {
        public void Update(double temperature, double humidity, double pressure)
        {
            Console.WriteLine("Текущие данные:");
            Console.WriteLine("Температура: {0}", temperature);
            Console.WriteLine("Влажность: {0}", humidity);
            Console.WriteLine("Давление: {0}", pressure);
            Console.WriteLine();
        }
    }
}