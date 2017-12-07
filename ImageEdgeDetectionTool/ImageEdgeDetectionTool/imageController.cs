using System.Drawing;

namespace ImageEdgeDetectionTool
{
    // a controller that uses the interfaces of the project
    public class ImageController
    {
    
        private IFiles files;
        private IBitmap bitmap;
        private IFilters filters;

        // all interfaces included in the constructor for later use in the presentation layer
        public ImageController(IFiles files, IBitmap bitmap, IFilters filters)
        {
            this.files = files;
            this.bitmap = bitmap;
            this.filters = filters;
        }
        // method that uses the IFile interface to open the file dialog and load the file the user selects
        public Bitmap openOriginalFile()
        {
            Bitmap originalBitmap = files.openFile();
            return originalBitmap;
        }

        // method that uses the IFile interface to save the image to which the filter was applied 
        public void saveModifiedFile(Bitmap resultBitmap)
        {
            files.saveFile(resultBitmap);
        }

        // method that take the file loaded from the computer and copies it to the square canvas in the form to match the canvas
        public Bitmap CopyToSquareCanvas(Bitmap originalBitmap, int canvasWidthLenght)
        {
            Bitmap previewBitmap = bitmap.CopyToSquareCanvas(originalBitmap, canvasWidthLenght);
            return previewBitmap;
        }

        // method that applies the Nigh Filter to the image loaded
        public Bitmap NightFilter(Bitmap sourceBitmap)
        {
            sourceBitmap = filters.NightFilter(sourceBitmap);
            return sourceBitmap;
        }
        // method that applies the Zen Filter to the image loaded
        public Bitmap ZenFilter(Bitmap sourceBitmap)
        {
            sourceBitmap = filters.ZenFilter(sourceBitmap);
            return sourceBitmap;
        }
    }
}
