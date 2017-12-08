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
            //Create a substitute for the Interfaces
            //var userRepository = Substitute.For<IUserRepository>();
            //var smsSender = Substitute.For<ISmsSender>();

            var files = Substitute.For<IFiles>();
            var bitmap = Substitute.For<IBitmap>();
            var filters = Substitute.For<IFilters>();

            //Create a local user
            //User user = CreateUser();
            var sourceBitmap = new Bitmap(ImageEdgeDetectionTool.Properties.Resources.hippo);
            var mockBitmap = new Bitmap(ImageEdgeDetectionTool.Properties.Resources.hippo_night);

            //Create a controller
            ImageController imageController = new ImageController(files, bitmap, filters);
            //LoginController testLoginController = new LoginController(smsSender, userRepository);

            //Propose to return something from GetById
            imageController.NightFilter(previewBitmap).Returns<Bitmap>(mockBitmap);
            //userRepository.GetById("sally").Returns<User>(user);

            //Exec SendNewPassword
            //testLoginController.SendNewPassword("sally");
            testBitmap = imageController.NightFilter(sourceBitmap);

            //Password should have been changed
            Assert.AreEqual(mockBitmap, testBitmap);
            //Assert.AreNotEqual(user.Password, "sally");
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
