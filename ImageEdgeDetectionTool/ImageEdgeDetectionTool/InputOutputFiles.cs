using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEdgeDetectionTool
{
    // manipulation of input/output files that implement the IFiles interface
    public class InputOutputFiles : IFiles
    {
        public InputOutputFiles()
        {

        }

        // method that will be called through the interface to open the file dialog and load the image
        public Bitmap openFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Bitmap originalBitmap = null;

            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // reading the file and setting the bitmap equal to what the streamreader read
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
            }
            return originalBitmap;
        }

        // method that will be called through the interface to save the image after the filter has been applied
        public void saveFile(Bitmap resultBitmap)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Specify a file name and file path";
            sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                ImageFormat imgFormat = ImageFormat.Png;

                if (fileExtension == "BMP")
                {
                    imgFormat = ImageFormat.Bmp;
                }
                else if (fileExtension == "JPG")
                {
                    imgFormat = ImageFormat.Jpeg;
                }

                // when the user click save button a streamwrite will be instanciated and save the image name and the image with the filter
                StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                streamWriter.Flush();
                streamWriter.Close();

            }
        }
    }
}
