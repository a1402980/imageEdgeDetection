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
            var bitmaps = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();
            ImageController imageController = new ImageController(files, bitmaps, filters);

            Bitmap originalBitmap = Properties.Resources.panda;
            Bitmap expectedBitmap;
            imageController.NightFilter(originalBitmap);

            Bitmap actualBitmap = Properties.Resources.pandanight;


        }
        [TestMethod]
        public void ZenFilterTest()
        {

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
