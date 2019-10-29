using AffineTransformationsIn3D.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AffineTransformationsIn3D.Geometry
{
    public static class Models
    {
       

        public static Mesh Cube(double size)
        {
            double s = size / 2;
            return new Mesh(new Vector[8]
                {
                    new Vector(-s, -s, -s),
                    new Vector(-s, s, -s),
                    new Vector(s, s, -s),
                    new Vector(s, -s, -s),
                    new Vector(-s, -s, s),
                    new Vector(-s, s, s),
                    new Vector(s, s, s),
                    new Vector(s, -s, s)
                }, new int[6][]
                {
                    new int[4] { 3, 2, 1, 0 },
                    new int[4] { 0, 1, 5, 4 },
                    new int[4] { 1, 2, 6, 5 },
                    new int[4] { 2, 3, 7, 6 },
                    new int[4] { 3, 0, 4, 7 },
                    new int[4] { 4, 5, 6, 7 }
                });

        }

        public static Mesh Icosahedron(double size)
        {
            var vertices = new Vector[12];
            var indices = new int[20][];
            double R = (size * Math.Sqrt(2.0 * (5.0 + Math.Sqrt(5.0)))) / 4;
            double r = (size * Math.Sqrt(3.0) * (3.0 + Math.Sqrt(5.0))) / 12;
            for (int i = 0; i < 5; ++i)
            {
                vertices[2 * i] = new Vector(
                    r * Math.Cos(2 * Math.PI / 5 * i),
                    R / 2,
                    r * Math.Sin(2 * Math.PI / 5 * i));
                vertices[2 * i + 1] = new Vector(
                    r * Math.Cos(2 * Math.PI / 5 * i + 2 * Math.PI / 10),
                    -R / 2,
                    r * Math.Sin(2 * Math.PI / 5 * i + 2 * Math.PI / 10));
            }
            vertices[10] = new Vector(0, R, 0);
            vertices[11] = new Vector(0, -R, 0);
            for (int i = 0; i < 10; i += 2)
                indices[i] = new int[3] { (i + 1) % 10, (i + 2) % 10, i };
            for (int i = 1; i < 10; i += 2)
                indices[i] = new int[3] { (i + 1) % 10, i, (i + 2) % 10 };
            for (int i = 0; i < 5; ++i)
            {
                indices[10 + 2 * i] = new int[3] { 10, 2 * i, (2 * (i + 1)) % 10 };
                indices[10 + 2 * i + 1] = new int[3] { 11, (2 * (i + 1) + 1) % 10, 2 * i + 1 };
            }
            return new Mesh(vertices, indices);
        }

        public static Mesh Tetrahedron(double size)
        {
            var vertices = new Vector[4];
            var indices = new int[4][];
            double h = Math.Sqrt(2.0 / 3.0) * size;
            vertices[0] = new Vector(-size / 2, 0, h / 3);
            vertices[1] = new Vector(0, 0, -h * 2 / 3);
            vertices[2] = new Vector(size / 2, 0, h / 3);
            vertices[3] = new Vector(0, h, 0);
            indices[0] = new int[3] { 0, 2, 1 };
            indices[1] = new int[3] { 1, 3, 0 };
            indices[2] = new int[3] { 0, 3, 2 };
            indices[3] = new int[3] { 2, 3, 1 };
            return new Mesh(vertices, indices);
        }

        public static Mesh Plot(
            double x0, double x1, double dx, double z0, double z1, double dz,
            Func<double, double, double> function, double AngleX = Math.PI/4,
			double AngleY = Math.PI / 2, double AngleZ = Math.PI / 4)
        {
            int nx = (int)((x1 - x0) / dx);
            int nz = (int)((z1 - z0) / dz);
            var vertices = new Vector[nx * nz];
            var indices = new int[(nx - 1) * (nz - 1)][];
            for (int i = 0; i < nx; ++i)
                for (int j = 0; j < nz; ++j)
                {
                    var x = x0 + dx * i;
                    var z = z0 + dz * j;
                    vertices[i * nz + j] = new Vector(x, function(x, z), z);
                }
            for (int i = 0; i < nx - 1; ++i)
                for (int j = 0; j < nz - 1; j++)
                {
                    indices[i * (nz - 1) + j] = new int[4] {
                        i * nz + j,
                        (i + 1) * nz + j,
                        (i + 1) * nz + j + 1,
                        i * nz + j + 1
                    };
                }

			Mesh m = new Mesh(vertices, indices);

			

			return m;
        }

 

        public static Mesh RotationFigure(IList<Vector> initial, int axis, int density)
        {
            Debug.Assert(0 <= axis && axis < 3);
            var n = initial.Count;
            var vertices = new Vector[n * density];
            var indices = new int[density * (n - 1)][];
            Func<double, Matrix> rotation;
            switch (axis)
            {
                case 0: rotation = Transformations.RotateX; break;
                case 1: rotation = Transformations.RotateY; break;
                default: rotation = Transformations.RotateZ; break;
            }
            for (int i = 0; i < density; ++i)
                for (int j = 0; j < n; ++j)
                    vertices[i * n + j] = initial[j] * rotation(2 * Math.PI * i / density);
            for (int i = 0; i < density; ++i)
                for (int j = 0; j < n - 1; ++j)
                    indices[i * (n - 1) + j] = new int[4] {
                        i * n + j + 1,
                        (i + 1) % density * n + j + 1,
                        (i + 1) % density * n + j,
                        i * n + j, };
            return new Mesh(vertices, indices);
        }
    }
}
