using System;
using WD.Subscriber;

namespace WD.Publisher
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber subscriber);
        void DeleteSubscriber(ISubscriber subscriber);
    }
}