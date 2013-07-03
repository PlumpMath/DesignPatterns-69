using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : IWeatherSubject
    {
        private IList<IWeatherObserver> Observers;

        private float _temperature;
        public float Temperature {
            get { return _temperature; }
            set { 
                _temperature = value;
                MeasurementsChanged();
            }
        }

        private float _humidity;
        public float Humidity
        {
            get { return _humidity; }
            set
            {
                _humidity = value;
                MeasurementsChanged();
            }
        }

        private float _pressure;
        public float Pressure
        {
            get { return _pressure; }
            set
            {
                _pressure = value;
                MeasurementsChanged();
            }
        }

        public WeatherData()
        {
            Observers = new List<IWeatherObserver>();
        }

        public void RegisterObserver(IWeatherObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IWeatherObserver o)
        {
            Observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}