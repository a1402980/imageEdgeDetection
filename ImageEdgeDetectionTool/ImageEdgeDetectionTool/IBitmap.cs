using System.Drawing;

namespace ImageEdgeDetectionTool
{
    // the bitmap interface which copies the image to the square canvas
    public interface IBitmap
    {
        Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght);
    }
}
