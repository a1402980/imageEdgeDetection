using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetectionTool
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        private IFiles files = new InputOutputFiles();
        private IBitmap bitmap = new ExtBitmap();
      
        public MainForm()
        {
            InitializeComponent();
            
            //just some proof of concept stuff
            originalBitmap = previewBitmap = new Bitmap(ImageEdgeDetectionTool.Properties.Resources.panda);
            ImagePreview.Image = originalBitmap;

        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController(files, bitmap);

            Bitmap originalBitmap = imageController.openOriginalFile();

            previewBitmap = imageController.CopyToSquareCanvas(originalBitmap, ImagePreview.Width);
            ImagePreview.Image = previewBitmap;
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController(files, bitmap);
            imageController.saveModifiedFile(resultBitmap);
        }

        private void EdgeDetectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //initialize the preview
            previewBitmap = originalBitmap;

            string selected = EdgeDetectionList.SelectedItem.ToString();
            switch (selected)
            {
                case "-Original-":
                    {
                        previewBitmap = originalBitmap;
                        System.Diagnostics.Debug.WriteLine("111111111111111111111111111111111111111111");
                        break;
                    }
                case "Zen filter":
                    {
                        //previewBitmap = previewBitmap.Laplacian3x3Filter(true);

                        //just some proof of concept stuff
                        previewBitmap = previewBitmap.ZenFilter();
                        //previewBitmap = new Bitmap(ImageEdgeDetectionTool.Properties.Resources.tiger);
                        System.Diagnostics.Debug.WriteLine("222222222222222222222222222222222");
                        break;
                    }
                case "Night filter":
                    {
                        //just some proof of concept stuff
                        previewBitmap = previewBitmap.NightFilter();
                        //previewBitmap = new Bitmap(ImageEdgeDetectionTool.Properties.Resources.hippo);
                        System.Diagnostics.Debug.WriteLine("333333333333333333333333333333333");
                        //bitmapResult = selectedSource.Laplacian3x3Filter(true);
                        break;
                    }
                default:
                    {
                        break;
                    }
                    resultBitmap = previewBitmap;
            }
            //send the image into the preview
            ImagePreview.Image = previewBitmap;
        }
        
    }
}
