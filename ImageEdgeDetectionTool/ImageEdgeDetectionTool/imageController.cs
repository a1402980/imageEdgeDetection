using System;
using System.Drawing;
using System.Windows.Forms;

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
        public ImageController(IFiles files, IBitmap bitmap)
        {
            this.files = files;
            this.bitmap = bitmap;
        }
        // method that uses the IFile interface to open the file dialog and load the file the user selects
        public Bitmap openOriginalFile()
        {
            Bitmap originalBitmap = null;
            try
            {
                originalBitmap = files.openFile();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return originalBitmap;
        }

        // method that uses the IFile interface to save the image to which the filter was applied 
        public void saveModifiedFile(Bitmap resultBitmap)
        {
            try
            {
                files.saveFile(resultBitmap);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method that take the file loaded from the computer and copies it to the square canvas in the form to match the canvas
        public Bitmap CopyToSquareCanvas(Bitmap originalBitmap, int canvasWidthLenght)
        {
            Bitmap previewBitmap = null;
            try
            {
                previewBitmap = bitmap.CopyToSquareCanvas(originalBitmap, canvasWidthLenght);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return previewBitmap;
        }

        // method that applies the Nigh Filter to the image loaded
        public Bitmap NightFilter(Bitmap sourceBitmap)
        {
            try
            {
                sourceBitmap = filters.NightFilter(sourceBitmap);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sourceBitmap;
        }
        // method that applies the Zen Filter to the image loaded
        public Bitmap ZenFilter(Bitmap sourceBitmap)
        {
            try
            {
                sourceBitmap = filters.ZenFilter(sourceBitmap);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sourceBitmap;
        }
    }
}
