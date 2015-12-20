using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace ImageProcess
{
    public class BumpMap
    {
        //
        // Algorithms From http://www.alejandrosegovia.net/2014/03/31/bump-map-generation/
        //
        public static Image FromGrayScale(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 1; y < bmOrigin.Size.Height - 1; y++)
            {
                for (int x = 1; x < bmOrigin.Size.Width - 1; x++)
                {
                    Vector3D s = new Vector3D(1, 0, bmOrigin.GetPixel(x - 1, y).B - bmOrigin.GetPixel(x + 1, y).B);
                    Vector3D t = new Vector3D(0, 1, bmOrigin.GetPixel(x, y - 1).B - bmOrigin.GetPixel(x, y + 1).B);
                    Vector3D R = Vector3D.CrossProduct(s,t);
                    R.Normalize();
                    bmProcess.SetPixel(x, y, VectorToColor(R));
                }
            }
            return bmProcess;
        }

        public static Image FromColorImage(Image imOrigin)
        {
            return FromGrayScale(GrayScale.Luma(imOrigin));
        }

        private static int VectorComponentTo255ColorComponent(double VecComponent)
        {
            return (int)(((VecComponent + 1.0) / 2.0) * 255);
        }
        private static Color VectorToColor(Vector3D vec)
        {
            return Color.FromArgb(
                VectorComponentTo255ColorComponent(vec.X),
                VectorComponentTo255ColorComponent(vec.Y),
                VectorComponentTo255ColorComponent(vec.Z)
                );
        }
        private static Color VectorToColor(Vector3D vec, int Alpha)
        {
            return Color.FromArgb(
                Alpha,
                VectorComponentTo255ColorComponent(vec.X),
                VectorComponentTo255ColorComponent(vec.Y),
                VectorComponentTo255ColorComponent(vec.Z)
                );
        }
    }
}
