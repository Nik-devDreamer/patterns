using System;
using System.Collections.Generic;
using WD.Subscriber;

namespace WD.Publisher
{
    public class WeatherData : IPublisher
    {
        double temperature, humidity, pressure;
        List<ISubscriber> subscribers = new List<ISubscriber>();
        Random rnd = new Random();

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void DeleteSubscriber(ISubscriber subscriber)
        {
            int i = subscribers.IndexOf(subscriber);
            if (i >= 0)
            {
                subscribers.Remove(subscriber);
            }
        }

        public void NotifySubscriber()
        {
            temperature = Temperature();
            humidity = Humidity();
            pressure = Pressure();

            foreach (var a in subscribers)
            {
                a.Update(temperature, humidity, pressure);
            }
        }

        public double Temperature()
        {
            return rnd.Next(0, 50);
        }

        public double Humidity()
        {
            return rnd.Next(30, 60);
        }

        public double Pressure()
        {
            return rnd.Next(600, 800);
        }
    }
}