using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetectionTool
{
    public class imageController
    {
        private IFiles files;
        private IBitmap bitmap;

        public imageController(IFiles files, IBitmap bitmap)
        {
            this.files = files;
            this.bitmap = bitmap;
        }
        public imageController()
        {

        }

        public Bitmap openOriginalFile()
        {
            Bitmap originalBitmap = files.openFile();
            return originalBitmap;
        }
        public Bitmap CopyToSquareCanvas(Bitmap originalBitmap, int canvasWidthLenght)
        {
            Bitmap previewBitmap = bitmap.CopyToSquareCanvas(originalBitmap, canvasWidthLenght);
            return previewBitmap;
        }
    }
}
