using System;

namespace ObserverPattern
{
    class ForecastDisplay : IWeatherObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;

        public ForecastDisplay(IWeatherSubject weatherSubject)
        {
            weatherSubject.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: ");
		    if (_currentPressure > _lastPressure) {
			    Console.WriteLine("Improving weather on the way!");
		    } else if (_currentPressure == _lastPressure) {
			    Console.WriteLine("More of the same");
		    } else if (_currentPressure < _lastPressure) {
                Console.WriteLine("Watch out for cooler, rainy weather");
		    }
        }
    }
}