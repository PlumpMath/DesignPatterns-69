using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FactoryPatternWpf
{
    class StarShape : IShape
    {
        private int _width;
        private int _height;
        private Color _strokeColor;
        private Color _fillColor;
        protected int NumberOfPoints = 5;

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
            var star = new Star()
            {
                Stroke = new SolidColorBrush(_strokeColor),
                StrokeThickness = 2,
                Width = _width,
                Height = _height,
                Fill = new SolidColorBrush(_fillColor),
                NumberOfPoints = this.NumberOfPoints
            };
            Canvas.SetLeft(star, startPoint.Y);
            Canvas.SetTop(star, startPoint.X);
            canvas.Children.Add(star);
        }

    }
}