using System;

namespace WeatherData.Subscriber
{
    public interface ISubscriber
    {
        void Update(double temperature, double humidity, double pressure);
    }
}