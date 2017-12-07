using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetectionTool
{
    public class ImageController
    {
        private IFiles files;
        private IBitmap bitmap;

        public ImageController(IFiles files, IBitmap bitmap)
        {
            this.files = files;
            this.bitmap = bitmap;
        }
        public ImageController()
        {

        }

        public Bitmap openOriginalFile()
        {
            Bitmap originalBitmap = files.openFile();
            return originalBitmap;
        }

        public void saveModifiedFile(Bitmap resultBitmap)
        {
            files.saveFile(resultBitmap);
        }
        public Bitmap CopyToSquareCanvas(Bitmap originalBitmap, int canvasWidthLenght)
        {
            Bitmap previewBitmap = bitmap.CopyToSquareCanvas(originalBitmap, canvasWidthLenght);
            return previewBitmap;
        }
    }
}
