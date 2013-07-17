using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FactoryPatternWpf
{
    public class Star : Shape
    {
        // Using a DependencyProperty as the backing store for NumberOfPoints.  
        public static readonly DependencyProperty NumberOfPointsProperty =
            DependencyProperty.Register("NumberOfPoints", typeof(int), typeof(Shape), new UIPropertyMetadata(5));

        public int NumberOfPoints
        {
            get { return (int)GetValue(NumberOfPointsProperty); }
            set { SetValue(NumberOfPointsProperty, value); }
        }

        protected override Geometry DefiningGeometry
        {
            get { return CreateStarGeometry(NumberOfPoints); }
        }

        protected Geometry CreateStarGeometry(int numberOfPoints)
        {
            GeometryGroup group = new GeometryGroup();
            group.FillRule = FillRule.Nonzero;
            Geometry triangle = PathGeometry.Parse("M 0,-30 L 10,10 -10,10 0,-30");
            group.Children.Add(triangle);

            double deltaAngle = 360 / numberOfPoints;
            double currentAngle = 0;
            for (int index = 1; index < numberOfPoints; index++)
            {
                currentAngle += deltaAngle;
                triangle = triangle.CloneCurrentValue();
                triangle.Transform = new RotateTransform(currentAngle, 0, 0);
                group.Children.Add(triangle);
            }

            Geometry outlinePath = group.GetOutlinedPathGeometry();
            return outlinePath;
        }
    }
}