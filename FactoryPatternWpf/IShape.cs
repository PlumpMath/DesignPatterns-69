using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryPatternWpf
{
    public interface IShape
    {
        void SetStrokeColor(Color color);
        void SetFillColor(Color color);
        void SetWidth(int width);
        void SetHeight(int height);
        void Draw(Canvas canvas, Point startPoint);
    }
}