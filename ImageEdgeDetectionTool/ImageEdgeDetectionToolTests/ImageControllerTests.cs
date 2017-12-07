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

            
            Bitmap expectedBitmap = null;

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
