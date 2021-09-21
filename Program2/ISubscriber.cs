using System;

namespace WD.Subscriber
{
    public interface ISubscriber
    {
        void Update(double temperature, double humidity, double pressure);
    }
}