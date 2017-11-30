using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEdgeDetectionTool
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap selectedBitmap = null;
        private Bitmap resultBitmap = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadImage_Click(object sender, EventArgs e)
        {

        }

        private void saveImage_Click(object sender, EventArgs e)
        {

        }

        private void EdgeDetectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = EdgeDetectionList.SelectedItem.ToString();
            switch (selected)
            {
            case "-Original-":
                {
                    resultBitmap = originalBitmap;
                    break;
                }
            case "Zen filter":
                {
                    //bitmapResult = s.Laplacian3x3Filter(false);
                    break;
                }
            case "Some filter":
                {
                    //bitmapResult = selectedSource.Laplacian3x3Filter(true);
                    break;
                }
            default:
                {
                    break;
                }
            }
        }

    }
}
