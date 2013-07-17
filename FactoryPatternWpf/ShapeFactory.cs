namespace FactoryPatternWpf
{
    public class ShapeFactory
    {
        private IShape _shape;

        public IShape CreateShape(string shapeType)
        {
            switch (shapeType)
            {
                case "Square":
                    _shape = new SquareShape();
                    break;
                case "Rectangle":
                    _shape = new RectangleShape();
                    break;
                case "Ellipse":
                    _shape = new EllipseShape();
                    break;
                case "Star":
                    _shape = new StarShape();
                    break;
                case "4 Point Star":
                    _shape = new FourPointStarShape();
                    break;
            }
            return _shape;
        }
    }
}