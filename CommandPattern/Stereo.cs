using System;

namespace CommandPattern
{
    public class Stereo
    {
        private int _volume;

        public void On()
        {
            Console.WriteLine("Turn stereo on");
        }

        public void SetCd()
        {
            Console.WriteLine("set CD player mode");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine("Set Volume to " + _volume);
        }

        public void Off()
        {
            Console.WriteLine("Turn stereo off");
        }
    }
}