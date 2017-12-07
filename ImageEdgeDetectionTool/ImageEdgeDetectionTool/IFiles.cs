using System.Drawing;

namespace ImageEdgeDetectionTool
{
    // interface that is implement in the InputOutputFiles class to manipulate the input and output files
    // corresponding methods included
    public interface IFiles
    {
        Bitmap openFile();
        void saveFile(Bitmap resultBitmap);
    }
}
