using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WD.Publisher;
using WD.Subscriber;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherdata = new WeatherData();
            CurrentDisplay display = new CurrentDisplay();
            StatisticsDisplay display2 = new StatisticsDisplay();
            weatherdata.AddSubscriber(display);
            weatherdata.AddSubscriber(display2);
            weatherdata.NotifySubscriber();
            Console.ReadKey();
        }
    }
}
