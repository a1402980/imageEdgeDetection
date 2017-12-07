using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetectionTool
{
    public interface IBitmap
    {
        Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght);
    }
}
