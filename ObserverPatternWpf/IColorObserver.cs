using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ObserverPatternWpf
{
    public interface IColorObserver
    {
        void Update(Color newColor);
    }
}
