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
        // night filter test with interface substitutes
        [TestMethod]
        public void NightFilterTest()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();

            // set the sourcebitmap and mockbitmap
            Bitmap sourceBitmap = Properties.Resources.panda;
            Bitmap mockBitmap = Properties.Resources.pandanight;

            // fool the substitute to return to us a mockbitmap
            filters.NightFilter(sourceBitmap).Returns<Bitmap>(mockBitmap);

            // pass the substitutes to image controller
            ImageController imageController = new ImageController(files, bitmap, filters);

            // set testbitmap equals to what the imagecontroller nightfilter method returns
            Bitmap testBitmap = imageController.NightFilter(sourceBitmap);

            // assert if mockbitmap and testbitmap are the equal
            Assert.AreEqual(testBitmap, mockBitmap);
        }

        // night filter test exception with interface substitutes
        [TestMethod]
        public void NightFilterTestException()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();

            // set a invalidbitmap
            Bitmap invalidBitmap = null;

            // fool the substitute to return to us an exception
            filters.NightFilter(invalidBitmap).Returns(x => throw new Exception());

            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmap, filters);

            // run the method night filter of the controller
            imageController.NightFilter(invalidBitmap);

            // assert if it throws an exception
            Assert.ThrowsException<Exception>(() => filters.NightFilter(invalidBitmap));
        }

        // zen filter test exception with interface substitutes
        [TestMethod]
        public void ZenFilterTestException()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();

            // set a invalidbitmap
            Bitmap invalidBitmap = null;

            // fool the substitute to return to us an exception
            filters.ZenFilter(invalidBitmap).Returns(x => throw new Exception());

            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmap, filters);

            // run the method zen filter of the controller
            imageController.ZenFilter(invalidBitmap);

            // assert if it throws an exception
            Assert.ThrowsException<Exception>(() => filters.ZenFilter(invalidBitmap));
        }

        // zen filter test with interface substitutes
        [TestMethod]
        public void ZenFilterTest()
        {
            //substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();

            // set a sourcebitmap and a mockbitmap 
            Bitmap sourceBitmap = Properties.Resources.panda;
            Bitmap mockBitmap = Properties.Resources.pandazen;

            // fool the substitute to return to us a bitmap
            filters.ZenFilter(sourceBitmap).Returns<Bitmap>(mockBitmap);

            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmap, filters);

            // set testbitmap equal to what imagecontroller zenfilter method returns
            Bitmap testBitmap = imageController.ZenFilter(sourceBitmap);

            // assert if mockbitmap and testbitmap are equal
            Assert.AreEqual(testBitmap, mockBitmap);
        }

        // input file test with interface substitutes
        [TestMethod]
        public void InputFileTest()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            // set a mockbitmap 
            Bitmap mockBitmap = Properties.Resources.panda;

            // fool the substitute to return to us the mockbitmap
            files.openFile().Returns<Bitmap>(mockBitmap);

            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmaps);

            // set expectedbitmap equals to what the imagecontroller method returns
            Bitmap expectedBitmap = imageController.openOriginalFile();

            // assert if expectedbitmap and mockbitmap are equal
            Assert.AreEqual(expectedBitmap, mockBitmap);
        }

        // output file test with interface substitutes
        [TestMethod]
        public void OutputFileTest()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            // set a mockbitmap 
            Bitmap mockBitmap = Properties.Resources.pandanight;
 
            // run the method saveFile
            files.saveFile(mockBitmap);

            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmaps);

            // run the method saveModifiedFile of the controller
            imageController.saveModifiedFile(mockBitmap);

            Assert.IsTrue(true);
        }

        // input file exception test with interface substitutes
        [TestMethod]
        public void InputFileExceptionTest()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            // fool the substitute to return to us a thrown exception
            files.openFile().Returns(x => throw new Exception());
 
            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmaps);

            // set the mockbitmap equals to what imagecontroller openOriginalFile returns
            Bitmap mockBitmap = imageController.openOriginalFile();

            // assert if the exception was thrown
            Assert.ThrowsException<Exception>(() => files.openFile());
        }

        // output file exception test using interface substitutes
        [TestMethod]
        public void OutputFileExceptionTest()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            // set a mockbitmap
            Bitmap mockBitmap = Properties.Resources.pandanight;

            // fool the substitute to return to us a thrown exception
            files.When(x => x.saveFile(mockBitmap)).Do(x => { throw new Exception(); });

            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmaps);

            // run the method saveModifiedFile from the controller
            imageController.saveModifiedFile(mockBitmap);

            // assert if the exception was thrown
            Assert.ThrowsException<Exception>(() => files.saveFile(mockBitmap));
        }

        // copy to square canvas test using interface substitutes
        [TestMethod]
        public void CopyToSquareCanvasTest()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            // set a canvasWiddth and a mockbitmap
            int canvasWidth = 593;
            Bitmap mockBitmap = Properties.Resources.panda;

            // fool the interface to return us a mockbitmap
            bitmaps.CopyToSquareCanvas(mockBitmap, canvasWidth).Returns<Bitmap>(mockBitmap);

            // pass the substitutes to the controller 
            ImageController imageController = new ImageController(files, bitmaps);

            // set the expectedBitmap equal to what imagecontroller copytosquarecanvas returns
            Bitmap expectedBitmap = imageController.CopyToSquareCanvas(mockBitmap, canvasWidth);

            // assert if the images are equal
            Assert.AreEqual(expectedBitmap, mockBitmap);
        }
        
        // copy to square canvas exception test with interface substitutes
        [TestMethod]
        public void CopyToSuqareCanvasExceptionTest()
        {
            // substitute the interfaces using NSubstitute
            var files = Substitute.For<IFiles>();
            var bitmaps = Substitute.For<IBitmap>();

            // set a canvasWiddth and a mockbitmap
            int canvasWidth = 593;
            Bitmap mockBitmap = Properties.Resources.panda;

            // fool the interface to return us a thrown exception
            bitmaps.CopyToSquareCanvas(mockBitmap, canvasWidth).Returns(x => throw new Exception());

            // pass the substitutes to the controller
            ImageController imageController = new ImageController(files, bitmaps);

            // set the expectedBitmap equal to what imagecontroller copytosquarecanvas returns
            Bitmap expectedBitmap = imageController.CopyToSquareCanvas(mockBitmap, canvasWidth);

            // assert if an exception was thrown
            Assert.ThrowsException<Exception>(() => bitmaps.CopyToSquareCanvas(mockBitmap, canvasWidth));
        }

    }
}
