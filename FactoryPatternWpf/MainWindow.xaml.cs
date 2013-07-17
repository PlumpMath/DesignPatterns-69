using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace FactoryPatternWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ShapeFactory _shapeFactory;

        public MainWindow()
        {
            InitializeComponent();
            
            _shapeFactory = new ShapeFactory();
        }

        private void Draw_Button_Click(object sender, RoutedEventArgs e)
        {
            var width = Convert.ToInt32(WidthBox.Text);
            var height = Convert.ToInt32(HeightBox.Text);
            var top = Convert.ToInt32(TopBox.Text);
            var left = Convert.ToInt32(LeftBox.Text);
            var type = ShapeType.Text;
            var strokeColor = Color.FromRgb(
                (byte)RedStrokeSlider.Value, 
                (byte)GreenStrokeSlider.Value, 
                (byte)BlueStrokeSlider.Value
            );
            var fillColor = Color.FromRgb(
                (byte)RedFillSlider.Value, 
                (byte)GreenFillSlider.Value, 
                (byte)BlueFillSlider.Value
            );

            var shape = _shapeFactory.CreateShape(type);
            shape.SetFillColor(fillColor);
            shape.SetStrokeColor(strokeColor);
            shape.SetWidth(width);
            shape.SetHeight(height);
            shape.Draw(MyCanvas, new Point(top, left));
        }


        #region OtherUIEvents

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();
        }

        private void FillSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            FillSwatch.Fill = new SolidColorBrush(Color.FromRgb(
                (byte) RedFillSlider.Value,
                (byte) GreenFillSlider.Value,
                (byte) BlueFillSlider.Value
            ));
        }


        private void StrokeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            StrokeSwatch.Stroke = new SolidColorBrush(Color.FromRgb(
                (byte)RedStrokeSlider.Value,
                (byte)GreenStrokeSlider.Value,
                (byte)BlueStrokeSlider.Value
            ));
        }
        #endregion

    }
}
