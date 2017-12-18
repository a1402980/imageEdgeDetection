using ImageEdgeDetectionTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Drawing;

namespace ImageEdgeDetectionToolTests
{
    [TestClass]
    public class ApplicationLayerAndClassesTests
    {
        // InputOutputClass open file test
        [TestMethod]
        public void InputOutputClassOpenFileTest()
        {
            // get the class through interface
            IFiles files = new InputOutputFiles();

            // set the testbitmap to be equals to what you open from the explorer
            Bitmap testBitmap = files.openFile();

            // test if the bitmap is not null
            Assert.IsNotNull(testBitmap);

        }
        // InputOutputClass save file test
        [TestMethod]
        public void InputOutputClassSaveFileTest()
        {
            // get the class through interface
            IFiles files = new InputOutputFiles();

            // set testbitmap equals to an image
            Bitmap testBitmap = Properties.Resources.pandanight;

            // run the method to save file
            files.saveFile(testBitmap);

            Assert.IsTrue(true);

        }

        // ExtBitmap class copy to square canvas test
        [TestMethod]
        public void ExtBitmapCopyToSquareCanvasTest()
        {
            // get the class through interface
            IBitmap bitmap = new ExtBitmap();

            // get an image and set a canvas width
            Bitmap originalBitmap = Properties.Resources.panda;
            int canvasWidth = 559;

            // run the method to copy the image to the suqare canvas
            bitmap.CopyToSquareCanvas(originalBitmap, canvasWidth);

            Assert.IsTrue(true);
        }

        // Filters class zen filter test
        [TestMethod]
        public void FiltersClassZenFilterTest()
        {
            // get the class through the interface
            IFilters filters = new Filters();

            // set the original bitmap, result bitmap and the expected bitmap
            Bitmap originalBitmap = Properties.Resources.panda;
            Bitmap expectedBitmap = Properties.Resources.pandazen;
            Bitmap resultBitmap = filters.ZenFilter(originalBitmap);

            // compare every pixel of result bitmap and expectedbitmap
            for (int i = 0; i < resultBitmap.Width; i++)
            {
                for (int x = 0; x < resultBitmap.Height; x++)
                {
                    Color cResult = resultBitmap.GetPixel(i, x);
                    Color cExpected = expectedBitmap.GetPixel(i, x);
                    Assert.AreEqual(cExpected, cResult);
                }
            }
        }
        // Filters class night filter test
        [TestMethod]
        public void FiltersClassNightFilterTest()
        {
            // get the class through the interface
            IFilters filters = new Filters();

            // set the original bitmap, result bitmap and the expected bitmap
            Bitmap originalBitmap = Properties.Resources.panda;
            Bitmap expectedBitmap = Properties.Resources.pandanight;
            Bitmap resultBitmap = filters.NightFilter(originalBitmap);

            for (int i = 0; i < resultBitmap.Width; i++)
            {
                for (int x = 0; x < resultBitmap.Height; x++)
                {
                    Color cResult = resultBitmap.GetPixel(i, x);
                    Color cExpected = expectedBitmap.GetPixel(i, x);
                    Assert.AreEqual(cExpected, cResult);
                }
            }
        }
    }
}
