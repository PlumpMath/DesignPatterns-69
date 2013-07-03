using System;

namespace ObserverPattern
{
    class CurrentConditionDisplay : IWeatherObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private IWeatherSubject _weatherSubject;

        public CurrentConditionDisplay(IWeatherSubject weatherSubject)
        {
            _weatherSubject = weatherSubject;
            weatherSubject.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }
    }
}