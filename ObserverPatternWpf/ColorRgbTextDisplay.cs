using System.Windows.Controls;
using System.Windows.Media;

namespace ObserverPatternWpf
{
    public class ColorRgbTextDisplay : IColorObserver
    {
        private TextBox _textBox;

        public ColorRgbTextDisplay(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void Update(Color newColor)
        {
            _textBox.Text = 
                "R:" + newColor.R.ToString().PadLeft(3,'0')
                + " G:" + newColor.G.ToString().PadLeft(3, '0')
                + " B:" + newColor.B.ToString().PadLeft(3, '0')
                + " A:" + newColor.A.ToString().PadLeft(3, '0');
        }
    }
}