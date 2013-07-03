using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public interface IWeatherObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
