using System.Drawing;


namespace ImageEdgeDetectionTool
{
    class Filters : IFilters
    {
        
        public Bitmap NightFilter(Bitmap sourceBitmap)
        {
            //set the parameters for the apply filter method to apply the Night filter
            Bitmap resultBitmap = ApplyFilter(new Bitmap(sourceBitmap), 1, 1, 1, 25);
            return resultBitmap;
        }

        public Bitmap ZenFilter(Bitmap sourceBitmap)
        {
            //set the parameters for the apply filter method to apply the Zen filter
            Bitmap resultBitmap = ApplyFilter(new Bitmap(sourceBitmap), 1, 10, 1, 1);
            return resultBitmap;
        }



        //Apply a filter with with values that are inserted with the RGBA values
        public Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green)
        {
            //make a copy of the bitmap passed with the method
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            //apply the filter to the width and height of the image
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
