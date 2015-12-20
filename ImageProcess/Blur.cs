using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess
{
    public class Blur
    {
        //
        // Algorithms From https://www.youtube.com/watch?v=C_zFhWdM4ic
        //
        public static Image Mean(Image imOrigin, int size = 1)
        {

            //if(imOrigin.Size.x)
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);

            //Corner Blur

            bmProcess.SetPixel(0, 0, Color.FromArgb(
                (
                bmProcess.GetPixel(0, 0).ToArgb() +
                bmProcess.GetPixel(1, 0).ToArgb() +
                bmProcess.GetPixel(0, 1).ToArgb() +
                bmProcess.GetPixel(1, 1).ToArgb()
                ) / 4)
                );
            bmProcess.SetPixel(bmOrigin.Size.Width - 1, 0, Color.FromArgb(
                (
                bmOrigin.GetPixel(bmOrigin.Size.Width - 1, 0).ToArgb() +
                bmOrigin.GetPixel(bmOrigin.Size.Width - 2, 0).ToArgb() +
                bmOrigin.GetPixel(bmOrigin.Size.Width - 1, 1).ToArgb() +
                bmOrigin.GetPixel(bmOrigin.Size.Width - 2, 1).ToArgb()
                ) / 4)
                );
            bmProcess.SetPixel(0, bmOrigin.Size.Height - 1, Color.FromArgb(
                (
                bmOrigin.GetPixel(0, bmOrigin.Size.Height - 1).ToArgb() +
                bmOrigin.GetPixel(1, bmOrigin.Size.Height - 1).ToArgb() +
                bmOrigin.GetPixel(0, bmOrigin.Size.Height - 2).ToArgb() +
                bmOrigin.GetPixel(1, bmOrigin.Size.Height - 2).ToArgb()
                ) / 4)
                );
            bmProcess.SetPixel(bmOrigin.Size.Width - 1, bmOrigin.Size.Height - 1, Color.FromArgb(
                (
                bmOrigin.GetPixel(bmOrigin.Size.Width - 1, bmOrigin.Size.Height - 1).ToArgb() +
                bmOrigin.GetPixel(bmOrigin.Size.Width - 2, bmOrigin.Size.Height - 1).ToArgb() +
                bmOrigin.GetPixel(bmOrigin.Size.Width - 1, bmOrigin.Size.Height - 2).ToArgb() +
                bmOrigin.GetPixel(bmOrigin.Size.Width - 2, bmOrigin.Size.Height - 2).ToArgb()
                ) / 4)
                );

            //Edge Blur
            //Horizontale
            for (int i = 1; i < bmOrigin.Size.Width-1; i++)
            {
                bmProcess.SetPixel(i, 0, Color.FromArgb(
                    (
                    bmOrigin.GetPixel(i - 1, 0).ToArgb() +
                    bmOrigin.GetPixel(i, 0).ToArgb() +
                    bmOrigin.GetPixel(i + 1, 0).ToArgb() +
                    bmOrigin.GetPixel(i - 1, 1).ToArgb() +
                    bmOrigin.GetPixel(i, 1).ToArgb() +
                    bmOrigin.GetPixel(i + 1, 1).ToArgb()
                    ) / 6
                    ));
                bmProcess.SetPixel(i, bmOrigin.Size.Height-1, Color.FromArgb(
                    (
                    bmOrigin.GetPixel(i - 1, bmOrigin.Size.Height - 1).ToArgb() +
                    bmOrigin.GetPixel(i, bmOrigin.Size.Height - 1).ToArgb() +
                    bmOrigin.GetPixel(i + 1, bmOrigin.Size.Height - 1).ToArgb() +
                    bmOrigin.GetPixel(i - 1, bmOrigin.Size.Height - 2).ToArgb() +
                    bmOrigin.GetPixel(i, bmOrigin.Size.Height - 2).ToArgb() +
                    bmOrigin.GetPixel(i + 1, bmOrigin.Size.Height - 2).ToArgb()
                    ) / 6
                    ));
            }
            //verticale
            for (int i = 1; i < bmOrigin.Size.Height-1; i++)
            {
                bmProcess.SetPixel(0, i, Color.FromArgb(
                    (
                    bmOrigin.GetPixel(0, i - 1).ToArgb() +
                    bmOrigin.GetPixel(0, i).ToArgb() +
                    bmOrigin.GetPixel(0, i + 1).ToArgb() +
                    bmOrigin.GetPixel(1, i - 1).ToArgb() +
                    bmOrigin.GetPixel(1, i).ToArgb() +
                    bmOrigin.GetPixel(1, i + 1).ToArgb()
                    ) / 6
                    ));
                bmProcess.SetPixel(bmOrigin.Size.Width - 1, i, Color.FromArgb(
                    (
                    bmOrigin.GetPixel(bmOrigin.Size.Width - 1, i - 1).ToArgb() +
                    bmOrigin.GetPixel(bmOrigin.Size.Width - 1, i).ToArgb() +
                    bmOrigin.GetPixel(bmOrigin.Size.Width - 1, i + 1).ToArgb() +
                    bmOrigin.GetPixel(bmOrigin.Size.Width - 2, i - 1).ToArgb() +
                    bmOrigin.GetPixel(bmOrigin.Size.Width - 2, i).ToArgb() +
                    bmOrigin.GetPixel(bmOrigin.Size.Width - 2, i + 1).ToArgb()
                    ) / 6
                    ));
            }


            //Center Blur
            for (int y = size; y < bmOrigin.Size.Height - size; y++)
            {
                for (int x = size; x < bmOrigin.Size.Width - size; x++)
                {
                    bmProcess.SetPixel(x, y, Color.FromArgb(
                        (
                    bmOrigin.GetPixel(x - size, y - size).ToArgb() +
                    bmOrigin.GetPixel(x, y - size).ToArgb() +
                    bmOrigin.GetPixel(x + size, y - size).ToArgb() +
                    bmOrigin.GetPixel(x + size, y).ToArgb() +
                    bmOrigin.GetPixel(x + size, y + size).ToArgb() +
                    bmOrigin.GetPixel(x, y - size).ToArgb() +
                    bmOrigin.GetPixel(x - size, y - size).ToArgb() +
                    bmOrigin.GetPixel(x - size, y).ToArgb() +
                    bmOrigin.GetPixel(x, y).ToArgb()
                    ) / 9

                    ));

                }
            }
            return bmProcess;
        }
        private static Color AverageColor()
        {
            // À faire
            return Color.FromArgb(1);
        }
    }
}
