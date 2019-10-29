namespace AffineTransformationsIn3D.Geometry
{
    public interface IDrawable
    {
        Vector Center { get; }

        void Draw(Graphics3D graphics);
        void Apply(Matrix transformation);
    }
}
