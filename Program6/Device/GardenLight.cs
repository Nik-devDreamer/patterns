using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6.Device
{
    public class GardenLight
    {
        public void SetDuskTime(int hour)
        {
            Console.WriteLine("Время автоматического выключения освещения в саду: {0} ч.", hour);
        }

        public void SetDawnTime(int hour)
        {
            Console.WriteLine("Время автоматического включения освещения в саду: {0} ч.", hour);
        }

        public void ManualOn()
        {
            Console.WriteLine("Освещение включено вручную");
        }

        public void ManualOff()
        {
            Console.WriteLine("Освещение выключено вручную");
        }
    }
}
