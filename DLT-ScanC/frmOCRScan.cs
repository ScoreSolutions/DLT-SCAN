using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using OCRTools;

namespace DLT_ScanC
{
    public partial class frmOCRScan : Form
    {
        public frmOCRScan()
        {
            InitializeComponent();
        }

        private void btnScanBarcode_Click(object sender, EventArgs e)
        {

        }

        //private string myFileName = @"D:\MyProject\DLT-Scan\TestBarcode.jpg";
        //OCR oc = new OCR();

        //private void btnScanBarcode_Click(object sender, EventArgs e)
        //{
        //    oc.BitmapImage = oc.PictureBox.Copy();
        //    if (oc.BitmapImage.Size.Height <= 1)
        //    {
        //        System.Windows.Forms.MessageBox.Show(
        //            "Error: Nothing selected. lasso barcode with your mouse, and click Process Mouse Selection");
        //        return;
        //    }
        //    oc.Process();
        //    oc.SetListViewBarcode(listView1);

        //    lblResult.Text = oc.Text;
        //}

        //private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    txtZoneX.Text = oc.PictureBox.X.ToString();
        //    txtZoneY.Text = oc.PictureBox.Y.ToString();
        //    txtZoneWidth.Text = oc.PictureBox.Width.ToString();
        //    txtZoneHeight.Text = oc.PictureBox.Height.ToString();
        //}

        //private void form_load(object sender, EventArgs e)
        //{
        //    oc.OCRType = OCRType.Barcode;
        //    oc.SetPictureBox(pictureBox1);
        //    oc.LoadPictureBox(myFileName);

        //}

        //private void pictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    txtZoneX.Text = oc.PictureBox.X.ToString();
        //    txtZoneY.Text = oc.PictureBox.Y.ToString();
        //    txtZoneWidth.Text = oc.PictureBox.Width.ToString();
        //    txtZoneHeight.Text = oc.PictureBox.Height.ToString();
        //}
    }
}
