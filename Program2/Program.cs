using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherData.Publisher;
using WeatherData.Subscriber;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData_ weatherdata = new WeatherData_();
            CurrentDisplay display = new CurrentDisplay();
            StatisticsDisplay display2 = new StatisticsDisplay();
            weatherdata.AddSubscriber(display);
            weatherdata.AddSubscriber(display2);
            weatherdata.NotifySubscriber();
            Console.ReadKey();
        }
    }
}
