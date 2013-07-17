using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FactoryPatternWpf
{
    class RectangleShape : IShape
    {
        private Rectangle _rect;
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

        public  void SetHeight(int height)
        {
            _height = height;
        }

        public void Draw(Canvas canvas, Point startPoint)
        {
            _rect = new Rectangle
                {
                    Stroke = new SolidColorBrush(_strokeColor),
                    StrokeThickness = 2,
                    Width = _width,
                    Height = _height,
                    Fill = new SolidColorBrush(_fillColor)
                };
            Canvas.SetLeft(_rect, startPoint.Y);
            Canvas.SetTop(_rect, startPoint.X);
            canvas.Children.Add(_rect);
        }
    }
}