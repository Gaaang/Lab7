using System.Drawing;

namespace AffineTransformationsIn3D.Geometry
{
    public class MeshWithNormals : Mesh
    {
        public Vector[] Normals { get; set; }
        public bool VirisbleNormals { get; set; } = false;

        public MeshWithNormals(Vector[] vertices, Vector[] normals, int[][] indices) : base(vertices, indices)
        {
            Normals = normals;
        }

        public override void Apply(Matrix transformation)
        {
            var normalTransformation = transformation.Inverse().Transpose();
            for (int i = 0; i < Coordinates.Length; ++i)
            {
                Coordinates[i] *= transformation;
                // В следующей строке, вероятно, не должно быть вызова Normalize,
                // но без него ничего не работает. Возможно, normalTransformation
                // вычисляется неверно.
                Normals[i] = (Normals[i] * normalTransformation).Normalize();
            }
        }

        public override void Draw(Graphics3D graphics)
        {
            foreach (var facet in Indices)
            {
                for (int i = 1; i < facet.Length - 1; ++i)
                {
                    var a = new Vertex(Coordinates[facet[0]], Color.White, Normals[facet[0]]);
                    var b = new Vertex(Coordinates[facet[i]], Color.White, Normals[facet[i]]);
                    var c = new Vertex(Coordinates[facet[i + 1]], Color.White, Normals[facet[i + 1]]);
                    graphics.DrawTriangle(a, b, c);
                }
                if (VirisbleNormals)
                    for (int i = 0; i < Coordinates.Length; ++i)
                    {
                        var a = new Vertex(Coordinates[i], Color.White, Normals[i]);
                        var b = new Vertex(Coordinates[i] + Normals[i], Color.White, Normals[i]);
                        graphics.DrawLine(a, b);
                    }
            }
        }
    }
}
