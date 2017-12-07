using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionTool
{
    public static class Filters
    {
        //night filter IMPORTED
        public static Bitmap NightFilter(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = Filters.ApplyFilter(new Bitmap(sourceBitmap), 1, 1, 1, 25);
            return resultBitmap;
        }

        public static Bitmap ZenFilter(this Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = Filters.ApplyFilter(new Bitmap(sourceBitmap), 1, 10, 1, 1);
            return resultBitmap;
        }



        //apply color filter at your own taste IMPORTED
        public static Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                    temp.SetPixel(i, x, cLayer);
                }

            }
            return temp;
        }
    }
}
