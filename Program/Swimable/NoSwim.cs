using System;

namespace Program.Swimable
{
    class NoSwim : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("������ ���� �� �������");
        }
    }
}