using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
