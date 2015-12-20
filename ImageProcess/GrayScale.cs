using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImageProcess
{
    public class GrayScale
    {
        //
        // Algorithms From http://www.tannerhelland.com/3643/grayscale-image-algorithm-vb6/
        //

        #region Wrapper
        public delegate Color GrayScaleFunction(Color Couleur);
        public static Image GrayScaleProcess(Image imOrigin, GrayScaleFunction Process)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, Process(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }

        #endregion

        #region Luma
        public static Color Luma(Color Couleur)
        {
            int temp = (int)Math.Round((Couleur.R * 0.3 + Couleur.G * 0.59 + Couleur.B * 0.11));
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }

        public static Image Luma(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, Luma(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion

        #region Average

        public static Color Average(Color Couleur)
        {
            int temp = (Couleur.R + Couleur.G + Couleur.B) / 3;
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }
        public static Image Average(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, Average(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion

        #region Desaturation
        public static Color Desaturation(Color Couleur)
        {
            int temp = (MaxColorComponent(Couleur) + MinColorComponent(Couleur)) / 2;
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }

        public static Image Desaturation(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, Desaturation(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion

        #region Maximum Decomposition
        public static Color MaximumDecomposition(Color Couleur)
        {
            int temp = MaxColorComponent(Couleur);
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }

        public static Image MaximumDecomposition(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, MaximumDecomposition(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion

        #region Minimum Decomposition
        public static Color MinimumDecomposition(Color Couleur)
        {
            int temp = MinColorComponent(Couleur);
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }

        public static Image MinimumDecomposition(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, MinimumDecomposition(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion

        #region Single color channel
        #region Red Channel
        public static Color FromRedColorChannel(Color Couleur)
        {
            int temp = Couleur.R;
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }
        public static Image FromRedColorChannel(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, FromRedColorChannel(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion
        #region Green Channel
        public static Color FromGreenColorChannel(Color Couleur)
        {
            int temp = Couleur.G;
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }
        public static Image FromGreenColorChannel(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, FromGreenColorChannel(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion
        #region Blue Channel
        public static Color FromBlueColorChannel(Color Couleur)
        {
            int temp = Couleur.B;
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }
        public static Image FromBlueColorChannel(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, FromBlueColorChannel(bmOrigin.GetPixel(x, y)));
                }
            }
            return bmProcess;
        }
        #endregion
        #endregion

        #region Custom # of gray shades
        public static Color CustomNumberOfShades(Color Couleur, int Shades)
        {
            if (Shades < 2)
                Shades = 2;
            if (Shades > 256)
                Shades = 256;
            float ConversionFactor = 255 / (Shades - 1);
            float AverageValue = (Couleur.R + Couleur.G + Couleur.B) / 3;
            int temp = (int)(((AverageValue / ConversionFactor)) * ConversionFactor);
            return Color.FromArgb(Couleur.A, temp, temp, temp);
        }

        public static GrayScaleFunction CustomNumberOfShades(int Shades,Color Couleur)
        {
            return (Color CarryCouleur) => { int CarryShades = Shades; return CustomNumberOfShades(CarryCouleur, CarryShades); };
        }

        public static Image CustomNumberOfShades(Image imOrigin, int Shades)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            for (int y = 0; y < bmOrigin.Size.Height; y++)
            {
                for (int x = 0; x < bmOrigin.Size.Width; x++)
                {
                    bmProcess.SetPixel(x, y, CustomNumberOfShades(bmOrigin.GetPixel(x, y),Shades));
                }
            }
            return bmProcess;
        }


        #endregion


        #region HelperFunction
        private static int MaxColorComponent(Color Couleur)
        {
            return Math.Max(Couleur.R, Math.Max(Couleur.G, Couleur.B));
        }
        private static int MinColorComponent(Color Couleur)
        {
            return Math.Min(Couleur.R, Math.Min(Couleur.G, Couleur.B));
        }
        #endregion
    }
}
