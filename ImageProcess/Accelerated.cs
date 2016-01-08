using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing.Imaging; 

namespace ImageProcess
{
    public class Accelerated
    {
        [DllImport(@"C:\Users\Francis\Documents\AcceleratedFilter\Debug\AcceleratedFilter.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GrayScaleAverage(IntPtr Src, IntPtr Copy, int width, int height, int stride);
        public static Image Copy(Image imOrigin)
        {
            Bitmap bmOrigin = new Bitmap(imOrigin);
            Bitmap bmProcess = new Bitmap(bmOrigin.Size.Width, bmOrigin.Size.Height);
            Rectangle rect = new Rectangle(0, 0, bmOrigin.Width, bmOrigin.Height);
            BitmapData bmpDT_src =  bmOrigin.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            BitmapData bmpDT_cpy = bmProcess.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            IntPtr src_ptr = bmpDT_src.Scan0;
            IntPtr cpy_ptr = bmpDT_cpy.Scan0;
            GrayScaleAverage(src_ptr, cpy_ptr, bmpDT_cpy.Width, bmpDT_cpy.Height, bmpDT_cpy.Stride);

            bmOrigin.UnlockBits(bmpDT_src);
            bmProcess.UnlockBits(bmpDT_cpy);

            return bmProcess;
        }
    }
}
