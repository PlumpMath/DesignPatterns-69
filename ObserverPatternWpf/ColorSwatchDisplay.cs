using System.Windows.Media;
using System.Windows.Shapes;

namespace ObserverPatternWpf
{
    public class ColorSwatchDisplay : IColorObserver
    {
        private Rectangle _rectangle;

        public ColorSwatchDisplay(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        public void Update(Color newColor)
        {
            _rectangle.Fill = new SolidColorBrush(newColor);
        }
    }
}