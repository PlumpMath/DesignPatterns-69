using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObserverPatternWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IColorObservable _colorControls;

        public MainWindow()
        {
            InitializeComponent();
            _colorControls = new ColorControls();

            var colorSwatch = new ColorSwatchDisplay(ColorSwatchDisplayElement);
            _colorControls.RegisterObserver(colorSwatch);

            var colorText = new ColorTextDisplay(ColorTextDisplayElement);
            _colorControls.RegisterObserver(colorText);

            var colorRgbText = new ColorRgbTextDisplay(ColorRgbTextDisplayElement);
            _colorControls.RegisterObserver(colorRgbText);

            var colorWindowBg = new ColorRgbaPanelBackground(MainGrid);
            _colorControls.RegisterObserver(colorWindowBg);
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var newColor = Color.FromArgb(
                (byte)AlphaSliderElement.Value,
                (byte)e.NewValue, 
                (byte)GreenSliderElement.Value, 
                (byte)BlueSliderElement.Value
            );
            _colorControls.UpdateColor(newColor);
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var newColor = Color.FromArgb(
                (byte)AlphaSliderElement.Value,
                (byte)RedSliderElement.Value, 
                (byte)e.NewValue, 
                (byte)BlueSliderElement.Value
            );
            _colorControls.UpdateColor(newColor);
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var newColor = Color.FromArgb(
                (byte)AlphaSliderElement.Value,
                (byte)RedSliderElement.Value, 
                (byte)GreenSliderElement.Value, 
                (byte)e.NewValue
            );
            _colorControls.UpdateColor(newColor);
        }

        private void AlphaSliderElement_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var newColor = Color.FromArgb(
                (byte)e.NewValue,
                (byte)RedSliderElement.Value,
                (byte)GreenSliderElement.Value,
                (byte)BlueSliderElement.Value
            );
            _colorControls.UpdateColor(newColor);
        }
    }
}
