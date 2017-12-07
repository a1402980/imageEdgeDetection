using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageEdgeDetectionTool
{
    // bitmap class that uses IBitmap interface 
    public class ExtBitmap : IBitmap
    {
        // method that will take the image loaded and copy it to the square canvas in the form
        public Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float ratio = 1.0f;
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            ratio = (float)maxSide / (float)canvasWidthLenght;

            Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            Graphics graphicsResult = Graphics.FromImage(bitmapResult);
            graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
            graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

            graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
            graphicsResult.Flush();
            
            return bitmapResult;
        }
    }
}
