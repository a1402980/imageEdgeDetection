using ImageEdgeDetectionTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Drawing;

namespace ImageEdgeDetectionToolTests
{
    [TestClass]
    public class ApplicationLayerAndClassesTests
    {

        public static Bitmap openFile()
        {
            InputOutputFiles inputFiles = new InputOutputFiles();

            return inputFiles.openFile();

        }
        [TestMethod]
        public void OpenFileFromInterfaceTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            Bitmap testBitmap = openFile();
            Bitmap originalBitmap = Properties.Resources.panda;
 
            ImageController image = new ImageController(files, bitmaps);

            image.openOriginalFile();
            
 
        }
    }
}
