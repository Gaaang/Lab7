using System.Drawing;

namespace AffineTransformationsIn3D.Geometry
{
    public class LightSource
    {
        public Vector Coordinate { get; set; }
        public Color Color { get; set; }

        public LightSource(Vector coordinate, Color color)
        {
            Coordinate = coordinate;
            Color = color;
        }
    }
}
