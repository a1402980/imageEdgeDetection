using ImageEdgeDetectionTool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Drawing;

namespace ImageEdgeDetectionToolTests
{
    [TestClass]
    public class ImageEdgeDetectionToolTests
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
        public void NightFilterTestException()
        {
            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();

            Bitmap invalidBitmap = null;

            filters.NightFilter(invalidBitmap).Returns(x => throw new Exception());

            ImageController imageController = new ImageController(files, bitmap, filters);

            imageController.NightFilter(invalidBitmap);

            Assert.ThrowsException<Exception>(() => filters.NightFilter(invalidBitmap));
        }
        [TestMethod]
        public void ZenFilterTestException()
        {
            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();

            Bitmap invalidBitmap = null;

            filters.ZenFilter(invalidBitmap).Returns(x => throw new Exception());

            ImageController imageController = new ImageController(files, bitmap, filters);

            imageController.ZenFilter(invalidBitmap);

            Assert.ThrowsException<Exception>(() => filters.ZenFilter(invalidBitmap));
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

            Bitmap mockBitmap = Properties.Resources.panda;

            files.openFile().Returns<Bitmap>(mockBitmap);
            ImageController imageController = new ImageController(files, bitmaps);

            Bitmap expectedBitmap = imageController.openOriginalFile();

            Assert.AreEqual(expectedBitmap, mockBitmap);
        }
        [TestMethod]
        public void OutputFileTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            Bitmap mockBitmap = Properties.Resources.pandanight;
 
            files.saveFile(mockBitmap);

            ImageController imageController = new ImageController(files, bitmaps);

            imageController.saveModifiedFile(mockBitmap);

            Assert.IsTrue(true);
        }
        [TestMethod]
        public void InputFileExceptionTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            files.openFile().Returns(x => throw new Exception());
 
            ImageController imageController = new ImageController(files, bitmaps);

            Bitmap mockBitmap = imageController.openOriginalFile();

            Assert.ThrowsException<Exception>(() => files.openFile());
        }
        [TestMethod]
        public void OutputFileExceptionTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            Bitmap mockBitmap = Properties.Resources.pandanight;

            files.When(x => x.saveFile(mockBitmap)).Do(x => { throw new Exception(); });

            ImageController imageController = new ImageController(files, bitmaps);

            imageController.saveModifiedFile(mockBitmap);
            
            Assert.ThrowsException<Exception>(() => files.saveFile(mockBitmap));
        }
        [TestMethod]
        public void CopyToSquareCanvasTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            int canvasWidth = 593;
            Bitmap mockBitmap = Properties.Resources.panda;

            bitmaps.CopyToSquareCanvas(mockBitmap, canvasWidth).Returns<Bitmap>(mockBitmap);

            ImageController imageController = new ImageController(files, bitmaps);

            Bitmap expectedBitmap = imageController.CopyToSquareCanvas(mockBitmap, canvasWidth);

            Assert.AreEqual(expectedBitmap, mockBitmap);
        }

        [TestMethod]
        public void CopyToSuqareCanvasExceptionTest()
        {
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            int canvasWidth = 593;
            Bitmap mockBitmap = Properties.Resources.panda;

            bitmaps.CopyToSquareCanvas(mockBitmap, canvasWidth).Returns(x => throw new Exception());

            ImageController imageController = new ImageController(files, bitmaps);

            Bitmap expectedBitmap = imageController.CopyToSquareCanvas(mockBitmap, canvasWidth);

            Assert.ThrowsException<Exception>(() => bitmaps.CopyToSquareCanvas(mockBitmap, canvasWidth));
        }

    }
}
