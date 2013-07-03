using System.Windows.Media;

namespace ObserverPatternWpf
{
    public interface IColorObservable
    {
        void RegisterObserver(IColorObserver o);
        void RemoveObserver(IColorObserver o);
        void UpdateColor(Color newColor);
        void NotifyObservers();
    }
}