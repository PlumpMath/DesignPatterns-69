using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace ObserverPatternWpf
{
    public class ColorTextDisplay : IColorObserver
    {
        private TextBox _textBox;

        public ColorTextDisplay(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void Update(Color newColor)
        {
            _textBox.Text = newColor.ToString();
        }
    }
}