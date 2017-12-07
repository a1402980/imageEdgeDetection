using System;
using System.Drawing;
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
        private IFilters filters = new Filters();
      
        public MainForm()
        {
            InitializeComponent();

            //disable the list and save when there is no image selected
            saveImage.Enabled = false;
            EdgeDetectionList.Enabled = false;
        }

        private void loadImage_Click(object sender, EventArgs e)
        {   
            //initialize the controller
            ImageController imageController = new ImageController(files, bitmap, filters);
            
            //call the open file method from the controller
            originalBitmap = imageController.openOriginalFile();

            //set the original bitma into a resized version of the selected file, so it fits on the preview
            originalBitmap = imageController.CopyToSquareCanvas(originalBitmap, ImagePreview.Width);

            //send the bitmap into the preview
            ImagePreview.Image = originalBitmap;

            //enable the save button and list
            saveImage.Enabled = true;
            EdgeDetectionList.Enabled = true;
            // set the list index back to 0 when you load a new image
            EdgeDetectionList.SelectedIndex = 0;
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            if (resultBitmap != null)
            {   
                //Initialize the controller
                ImageController imageController = new ImageController(files, bitmap, filters);

                //save the image
                imageController.saveModifiedFile(resultBitmap);
            }
            //show a message telling that the image has been saved
            MessageBox.Show("Your image has been saved successfully!", "Image saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset the form
            MainForm NewForm = new MainForm();
            NewForm.Show();
            this.Dispose(false);
        }

        private void EdgeDetectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Initialize the controller
            ImageController imageController = new ImageController(files, bitmap, filters);

            //initialize the preview
            previewBitmap = originalBitmap;

            //take the currently selected rows header and compare the value in a switch case
            string selected = EdgeDetectionList.SelectedItem.ToString();
            switch (selected)
            {
                case "-Original-":
                    {   
                        //if the selected is original, show the original
                        previewBitmap = originalBitmap;
                        break;
                    }
                case "Zen filter":
                    {
                        //set the previewBitmap with the selected filter
                        previewBitmap = imageController.ZenFilter(previewBitmap);
                        break;
                    }
                case "Night filter":
                    {
                        //set the previewBitmap with the selected filter
                        previewBitmap = imageController.NightFilter(previewBitmap);
                        break;
                    }
                default:
                    {
                        break;
                    }
                    
            }
            //send the image into the preview
            ImagePreview.Image = previewBitmap;
            resultBitmap = previewBitmap;
        }
        
    }
}
