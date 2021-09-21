using System;
using WeatherData.Subscriber;

namespace WeatherData.Publisher
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber subscriber);
        void DeleteSubscriber(ISubscriber subscriber);
    }
}