using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace AffineTransformationsIn3D.Geometry
{
    public class Graphics3D
    {

        // Буфер цвета.
        private Bitmap colorBuffer;
        // Буфер глубины.
        private double[,] zBuffer;

        private BitmapData bitmapData;

        private SceneView sceneView;
        private Matrix viewProjection;

        private double Width { get { return sceneView.Width; } }
        private double Height { get { return sceneView.Height; } }

        public Graphics3D(SceneView sceneView)
        {
            this.sceneView = sceneView;
            Resize();
        }

        public void Resize()
        {
            colorBuffer = new Bitmap((int)Width + 1, (int)Height + 1, PixelFormat.Format24bppRgb);
            zBuffer = new double[(int)Height + 1, (int)Width + 1];
        }

        public void StartDrawing()
        {
            // Очистим изображение
            using (var g = Graphics.FromImage(colorBuffer))
                g.FillRectangle(Brushes.Black, 0, 0, (int)Width, (int)Height);
            // Очистим z-буфер
            for (int i = 0; i < Height + 1; ++i)
                for (int j = 0; j < Width + 1; ++j)
                    zBuffer[i, j] = 1;
            bitmapData = colorBuffer.LockBits(
                new Rectangle(0, 0, colorBuffer.Width, colorBuffer.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            viewProjection = sceneView.Camera.ViewProjection;
        }

        public Bitmap FinishDrawing()
        {
            colorBuffer.UnlockBits(bitmapData);
            bitmapData = null;
            return colorBuffer;
        }

        private unsafe void SetPixel(int x, int y, double z, Color color)
        {
            if (x <=Width && y<=Height && y>=0 && x>=0)
            {
                var pointer = (byte*)bitmapData.Scan0.ToPointer();
                pointer[y * bitmapData.Stride + 3 * x + 0] = color.B;
                pointer[y * bitmapData.Stride + 3 * x + 1] = color.G;
                pointer[y * bitmapData.Stride + 3 * x + 2] = color.R;
            }
        }

        private Vector SpaceToClip(Vector v)
        {
            return v * viewProjection;
        }

        private Vector ClipToScreen(Vector v)
        {
            return NormalizedToScreen(Normalize(v));
        }

        private Vector Normalize(Vector v)
        {
            return new Vector(v.X / v.W, v.Y / v.W, v.Z / v.W);
        }

        private Vector NormalizedToScreen(Vector v)
        {
            return new Vector(
                (v.X + 1) / 2 * Width,
                (-v.Y + 1) / 2 * Height,
                v.Z);
        }
  

        public void DrawPoint(Vertex a)
        {
            a.Coordinate = SpaceToClip(a.Coordinate);
            a.Coordinate = ClipToScreen(a.Coordinate);
            const int POINT_SIZE = 5;
            for (int dy = 0; dy < POINT_SIZE; ++dy)
            {
                var y = (int)a.Coordinate.Y + dy - POINT_SIZE / 2;
                if (y < 0 || Height <= y) return;
                for (int dx = 0; dx < POINT_SIZE; ++dx)
                {
                    var x = (int)a.Coordinate.X + dx - POINT_SIZE / 2;
                    if (x < 0 || Width <= x) return;
                    SetPixel(x, y, a.Coordinate.Z, a.Color);
                }
            }
        }

        public void DrawLine(Vertex a, Vertex b)
        {
            a.Coordinate = SpaceToClip(a.Coordinate);
            b.Coordinate = SpaceToClip(b.Coordinate);
            a.Coordinate = ClipToScreen(a.Coordinate);
            b.Coordinate = ClipToScreen(b.Coordinate);
            int x0 = (int)a.Coordinate.X;
            int y0 = (int)a.Coordinate.Y;
            int x1 = (int)b.Coordinate.X;
            int y1 = (int)b.Coordinate.Y;
            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;
            int currentX = x0;
            int currentY = y0;
            while (true)
            {
                double f = dx < dy ? Math.Abs(currentY - a.Coordinate.Y) / dy : Math.Abs(currentX - a.Coordinate.X) / dx;
                SetPixel(currentX, currentY, 0, Color.White);
                if (currentX == x1 && currentY == y1)
                    break;
                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err = err - dy;
                    currentX = currentX + sx;
                }
                if (e2 < dx)
                {
                    err = err + dx;
                    currentY = currentY + sy;
                }
            }
        }

       
    }
}
