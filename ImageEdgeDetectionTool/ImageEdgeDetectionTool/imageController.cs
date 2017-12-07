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
        private IFilters filters;

        public ImageController(IFiles files, IBitmap bitmap, IFilters filters)
        {
            this.files = files;
            this.bitmap = bitmap;
            this.filters = filters;
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

        public Bitmap NightFilter(Bitmap sourceBitmap)
        {
            sourceBitmap = filters.NightFilter(sourceBitmap);
            return sourceBitmap;
        }
        public Bitmap ZenFilter(Bitmap sourceBitmap)
        {
            sourceBitmap = filters.ZenFilter(sourceBitmap);
            return sourceBitmap;
        }
    }
}
