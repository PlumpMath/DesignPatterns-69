using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ObserverPatternWpf
{
    class ColorControls : IColorObservable
    {
        private IList<IColorObserver> _observers;
        private Color _color;

        public ColorControls()
        {
            _observers = new List<IColorObserver>();
            _color = Color.FromArgb(255,0,0,0); //default black
        }

        public void RegisterObserver(IColorObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IColorObserver o)
        {
            _observers.Remove(o);
        }

        public void UpdateColor(Color newColor)
        {
            _color = newColor;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var colorObserver in _observers)
            {
                colorObserver.Update(_color);
            }
        }
    }
}
