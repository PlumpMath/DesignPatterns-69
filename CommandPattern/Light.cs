using System;

namespace CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light was turned ON");
        }

        public void Off()
        {
            Console.WriteLine("Light was turned OFF");
        }
    }
}