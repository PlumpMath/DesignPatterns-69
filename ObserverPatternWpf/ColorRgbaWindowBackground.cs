using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ObserverPatternWpf
{
    public class ColorRgbaPanelBackground : IColorObserver
    {
        private Panel _panel;

        public ColorRgbaPanelBackground(Panel panel)
        {
            _panel = panel;
        }

        public void Update(Color newColor)
        {
            var newColorAlpha = newColor;
            newColorAlpha.A = 70;
            _panel.Background = new SolidColorBrush(newColorAlpha);
        }
    }
}