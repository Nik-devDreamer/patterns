using System;
using System.Collections.Generic;
using System.Linq;

namespace WD.Subscriber
{
    public class StatisticsDisplay : ISubscriber
    {
        static List<double> temperatureList = new List<double>() { 10, 27, 15, 29 };
        static List<double> humidityList = new List<double>() { 41, 42, 44, 30 };
        static List<double> pressureList = new List<double>() { 600, 650, 700, 750 };

        public void Update(double temperature, double humidity, double pressure)
        {
            temperatureList.Add(temperature);
            humidityList.Add(humidity);
            pressureList.Add(pressure);

            Show();
        }

        static void Show()
        {
            Console.WriteLine("Средние значения за сегодняшний день:");
            Console.WriteLine("Средняя температура: {0}", Average(temperatureList));
            Console.WriteLine("Средняя влажность воздуха: {0}", Average(humidityList));
            Console.WriteLine("Среднее давление: {0}", Average(pressureList));
        }

        static double Average(List<double> data)
        {
            return data.Average();
        }
    }
}