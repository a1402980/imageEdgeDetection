using ImageEdgeDetectionTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Drawing;

namespace ImageEdgeDetectionToolTests
{
    [TestClass]
    public class ImageControllerTests
    {
        private TestContext testContextInstance;

        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        [TestMethod]
        public void NightFilterTest()
        {


            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();


            Bitmap sourceBitmap = Properties.Resources.panda;
            Bitmap mockBitmap = Properties.Resources.pandanight;

            ImageController imageController = new ImageController(files, bitmap, filters);

            imageController.NightFilter(sourceBitmap).Returns<Bitmap>(mockBitmap);

            Bitmap testBitmap = imageController.NightFilter(sourceBitmap);

            Assert.AreEqual(mockBitmap, testBitmap);




        }
        [TestMethod]
        public void ZenFilterTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();


            Bitmap sourceBitmap = Properties.Resources.panda;
            Bitmap mockBitmap = Properties.Resources.pandazen;

            ImageController imageController = new ImageController(files, bitmap, filters);

            imageController.ZenFilter(sourceBitmap).Returns<Bitmap>(mockBitmap);

            Bitmap testBitmap = imageController.ZenFilter(sourceBitmap);

            Assert.AreEqual(mockBitmap, testBitmap);

        }
        [TestMethod]
        public void InputFileTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            ImageController imageController = new ImageController(files, bitmaps);

            

            Assert.IsTrue(true);
        }
        [TestMethod]
        public void OutputFileTest()
        {

        }
        [TestMethod]
        public void InputFileExceptionTest()
        {

        }
    }
}
