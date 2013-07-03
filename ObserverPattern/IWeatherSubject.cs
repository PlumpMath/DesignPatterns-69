namespace ObserverPattern
{
    public interface IWeatherSubject
    {
        void RegisterObserver(IWeatherObserver o);
        void RemoveObserver(IWeatherObserver o);
        void NotifyObservers();
    }
}