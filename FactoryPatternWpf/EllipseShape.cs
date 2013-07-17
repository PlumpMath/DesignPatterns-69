using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FactoryPatternWpf
{
    class EllipseShape : IShape
    {
        private Ellipse _ellipse;
        private int _width;
        private int _height;
        private Color _strokeColor;
        private Color _fillColor;

        public void SetStrokeColor(Color color)
        {
            _strokeColor = color;
        }

        public void SetFillColor(Color color)
        {
            _fillColor = color;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public void Draw(Canvas canvas, Point startPoint)
        {
            _ellipse = new Ellipse()
                {
                    Stroke = new SolidColorBrush(_strokeColor),
                    StrokeThickness = 2,
                    Width = _width,
                    Height = _height,
                    Fill = new SolidColorBrush(_fillColor)
                };
            Canvas.SetLeft(_ellipse, startPoint.Y);
            Canvas.SetTop(_ellipse, startPoint.X);
            canvas.Children.Add(_ellipse);
        }
    }
}