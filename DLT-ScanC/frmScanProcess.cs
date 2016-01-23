using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using ScanLib.TwainLib;
using ScanLib.GdiPlusLib;
using ScanLib.OCRToolsBarcode;
using System.IO;
using System.Runtime.InteropServices;
using Func.Utilities;
using Func.Master;
using ScanLib.PdfMerge;
using Para.TABLE;


namespace DLT_ScanC
{
    public partial class frmScanProcess : System.Windows.Forms.Form, IMessageFilter
    {
        private Twain tw;
        BITMAPINFOHEADER bmi;
        Rectangle bmprect = new Rectangle(0, 0, 0, 0);
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
        IntPtr dibhand;
        IntPtr bmpptr;
        IntPtr pixptr;

        

        public frmScanProcess()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        internal class BITMAPINFOHEADER
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;
        }

        private void EndingScan()
        {
            Application.RemoveMessageFilter(this);
            this.Enabled = true;
            this.Activate();
            this.txtStaffCode.Focus();
            this.txtStaffCode.SelectAll();
        }

        string _err = "";

        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            //            bool ret = false;
            TwainCommand cmd = tw.PassMessage(ref m);
            if (cmd == null)
                return false;

            if (cmd == TwainCommand.Not)
            {
                //EndingScan();
                return false;
            }
            switch (cmd)
            {
                case TwainCommand.CloseRequest:
                    {
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.CloseOk:
                    {
                        EndingScan();
                        tw.CloseSrc();
                        break;
                    }
                case TwainCommand.DeviceEvent:
                    {
                        break;
                    }
                case TwainCommand.TransferReady:
                    {
                        ArrayList pics = tw.TransferPictures();
                        DataTable dt = new DataTable();
                        dt.Columns.Add("FilePath");

                        if (pics.Count > 0)
                        {
                            progressBar1.Value = 0;
                            progressBar1.Maximum = pics.Count;
                            for (int i = 0; i < pics.Count; i++)
                            {
                                lblProgress.Text = "กำลังสร้างไฟล์ที่ " + (i+1) + " จาก " + pics.Count;
                                string filePath = "";
                                if (txtIsFirstPage.Text == "N")
                                {//ถ้าเป็นรายการแรกจะไม่เข้าตรงนี้
                                    string staffCode = txtStaffCode.Text; //.Substring(Config.StaffCodeLength);
                                    txtFileRunning.Text = GenFileName(txtFolder.Text, txtStaffCode.Text + "_" + txtDocTypeCode.Text);
                                    filePath = @"" + txtFolder.Text + txtStaffCode.Text + "_" + txtDocTypeCode.Text + "_" + txtFileRunning.Text + ".JPG"; //txtFileName.Text;
                                }
                                else {
                                    //กรณีเป็นแผ่นแรกที่ Scan  (txtIsFirstPage.Text == "Y")
                                    filePath = txtFolder.Text  + "Barcode001.JPG";
                                }

                                IntPtr img = (IntPtr)pics[i];
                                bmpptr = Twain.GlobalLock(img);
                                pixptr = GetPixelInfo(bmpptr);
                                Guid clsid;
                                GetCodecClsid(filePath, out clsid);
                                IntPtr img2 = IntPtr.Zero;
                                Twain.GdipCreateBitmapFromGdiDib(bmpptr, pixptr, ref img2);
                                Twain.GdipSaveImageToFile(img2, filePath, ref clsid, IntPtr.Zero);
                                Twain.GdipDisposeImage(img2);

                                string pdfFile = txtFolder.Text +  txtStaffCode.Text + "\\" + txtStaffCode.Text + "_" + txtDocTypeCode.Text + ".PDF";
                                lblProgress.Text = "กำลังประมวลผลไฟล์ที่ " + (i + 1) + " จาก " + pics.Count;
                                if (ScanBarcode(filePath) == true)
                                {  //And Delete barcode file
                                    if (System.IO.File.Exists(filePath) == true)
                                        File.Delete(filePath);

                                    string staffCode = txtStaffCode.Text;
                                    if (System.IO.Directory.Exists(txtFolder.Text + staffCode) == false)
                                        System.IO.Directory.CreateDirectory(txtFolder.Text + staffCode);
                                    
                                }
                                else
                                {
                                    if (txtIsFirstPage.Text == "N") //ถ้าเป็นเอกสารที่ไม่ใช่หน้าแรก
                                    {
                                        if (File.Exists(pdfFile) == true)
                                            ProcessDupFile(pdfFile, filePath);
                                        else
                                            PdfMerge.CreateTmpPDFFile(pdfFile, filePath);

                                        DataRow dr = dt.NewRow();
                                        dr["FilePath"] = filePath;
                                        dt.Rows.Add(dr);

                                        SaveScanHistory(dr, pdfFile);
                                    }
                                    else {
                                        //ถ้าเป็นเอกสารหน้าแรก
                                        EndingScan();
                                        tw.CloseSrc();
                                        _err = "เอกสารหน้าแรกจะต้องเป็นบาร์โค้ดเท่านั้น";
                                        MessageBox.Show(_err);
                                        if (File.Exists(txtFolder.Text + "\\Barcode001.jpg") == true)
                                            File.Delete(txtFolder.Text + "\\Barcode001.jpg");

                                        break;
                                    }
                                }

                                txtIsFirstPage.Text = "N";
                                progressBar1.Value = (i + 1);
                            }

                            if (_err == "")
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    DataRow dr = dt.Rows[i];
                                    if (System.IO.File.Exists(dr["FilePath"].ToString()) == true)
                                        File.Delete(dr["FilePath"].ToString());
                                }
                                EndingScan();
                                tw.CloseSrc();
                                MessageBox.Show("ดำเนินการเรียบร้อย");
                            }
                        }
                        else {
                            EndingScan();
                            tw.CloseSrc();
                        }
                        break;
                    }
            }
            return true;
        }

        private void ProcessDupFile(string pdfFile, string jpgFile) {
            string CurrPDFFile = txtFolder.Text  + txtStaffCode.Text + "_" + txtDocTypeCode.Text + "_TMP.PDF";
            PdfMerge.CreateTmpPDFFile(CurrPDFFile, jpgFile);

            string oldFile = pdfFile;
            FileInfo oldProp = new FileInfo(oldFile);

            string tmpOldFile = oldProp.DirectoryName + "\\" + oldProp.Name.ToUpper().Replace(".PDF", "") + "_TMP.PDF";
            File.Copy(oldFile, tmpOldFile);

            string[] strFile = { tmpOldFile, CurrPDFFile };
            PdfMerge.MergeFiles(oldFile, strFile);

            if (File.Exists(CurrPDFFile) == true)
                File.Delete(CurrPDFFile);
            if (File.Exists(tmpOldFile) == true)
                File.Delete(tmpOldFile);
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            string[] strFile = System.IO.Directory.GetFiles(@"D:\Tmp\ScanForTest");
            foreach (string str in strFile) {
                string pdfFile = @"D:\Tmp\ScanForTest\TmpPdfFile.pdf";

                if (File.Exists(pdfFile) == true)
                {
                    ProcessDupFile(pdfFile, str);
                }
                else
                    PdfMerge.CreateTmpPDFFile(pdfFile, str);
            }

        }

        private string GetClientIP() {
            string ret = "";
            string myHost = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostByName(myHost);
            System.Net.IPAddress myIP = myIPs.AddressList[0];
            ret = myIP.ToString();
            return ret;
        }

        private void SaveScanHistory(DataRow dr, string pdfFile) {
            FileInfo jpg = new FileInfo(dr["FilePath"].ToString());
            FileInfo pdf = new FileInfo(pdfFile);

            Para.TABLE.ScanHistoryPara para = new Para.TABLE.ScanHistoryPara();
            para.STAFF_CODE = txtStaffCode.Text.Trim();
            para.DOCTYPE_CODE = txtDocTypeCode.Text.Trim();
            para.CLIENT_SCAN = System.Environment.MachineName;
            para.CLIENT_IP = GetClientIP();
            para.OUTPUT_FOLDER = jpg.DirectoryName;
            para.PDF_FILENAME = pdf.Name;
            //para.PDF_PAGE = Convert.ToInt64(txtFileRunning.Text);

            ScanHistoryFunc fnc = new ScanHistoryFunc();
            fnc.SaveScanHistory(para);
        }

        private bool ScanBarcode(string filePath)
        {
            bool ret = false;
            if (System.IO.File.Exists(filePath) == false)
            {
                MessageBox.Show("Cannon Open Image File");
                ret = false;
            }
            else
            {
                string barcode = "";
                OCRToolsBarcode ocr = new OCRToolsBarcode();
                barcode = ocr.OCRZoneProcess(filePath);
                if (barcode != "")
                {
                    if (barcode.Length != Config.BarcodeLength)
                    {
                        ret = false;
                    }
                    else if (barcode.Substring(0, Config.BarcodeStartDigit.Length) != Config.BarcodeStartDigit)
                    {
                        ret = false;
                    }
                    else
                    {
                        //txtStaffCode.Text = barcode.Substring(Config.BarcodeStartDigit.Length, Config.StaffCodeLength);
                        txtDocTypeCode.Text = barcode.Substring(Config.BarcodeStartDigit.Length);
                        ret = true;
                    }
                }
            }
            return ret;
        }

        private string ResizeImageFromFile(string scrFileName){
            FileInfo FileProps = new FileInfo(scrFileName);
            Image originalImage = System.Drawing.Image.FromFile(scrFileName);
            Bitmap b = new Bitmap(originalImage, 600, 800);
            b.SetResolution(72, 72);
            
            string[] tmpFileName = FileProps.Name.Split('.');
            string newFileName = FileProps.Directory + "\\" + tmpFileName[0] + "_NEW";

            b.Save(newFileName + ".JPG");
            return newFileName + ".JPG";
        }

        private string GenFileName(string folderName, string startFileName) {
            string ret = "";
            if (System.IO.Directory.Exists(folderName) == true) {
                try
                {
                    string[] fleName = System.IO.Directory.GetFiles(folderName);
                    var file = from f in fleName
                                where f.StartsWith(folderName + startFileName)
                                orderby f descending
                                select f.Replace(folderName, "");

                    List<string> f1 = file.Take(1).ToList();
                    if (f1.Count() == 0)
                    {
                        ret = "1".PadLeft(Config.FileRunningLength, '0');
                    }
                    else
                    {
                        foreach (var ff in f1)
                        {
                            string[] fName = ff.Split('.');
                            if (fName[0].Length == (startFileName.Length + Config.FileRunningLength + 1))
                            {// ถ้าจำนวน Digit เท่ากันกับไฟล์ล่าสุดที่ได้รับมา
                                string tmpFile = fName[0].ToString().Substring(fName[0].Length - Config.FileRunningLength);
                                ret = (Convert.ToInt16(tmpFile) + 1).ToString().PadLeft(Config.FileRunningLength,'0');
                            }
                            else
                            {
                                ret = "1".PadLeft(Config.FileRunningLength, '0');
                            }
                        }
                    }
                }
                catch (ArgumentNullException e) {
                    e.ToString();
                    ret = "1".PadLeft(Config.FileRunningLength, '0');
                }
            }

            return ret;
        }

        private bool GetCodecClsid(string filename, out Guid clsid)
        {
            clsid = Guid.Empty;
            string ext = Path.GetExtension(filename);
            if (ext == null)
                return false;
            ext = "*" + ext.ToUpper();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FilenameExtension.IndexOf(ext) >= 0)
                {
                    clsid = codec.Clsid;
                    return true;
                }
            }
            return false;
        }

        protected IntPtr GetPixelInfo(IntPtr bmpptr)
        {
            bmi = new BITMAPINFOHEADER();
            Marshal.PtrToStructure(bmpptr, bmi);

            bmprect.X = bmprect.Y = 0;
            bmprect.Width = bmi.biWidth;
            bmprect.Height = bmi.biHeight;

            if (bmi.biSizeImage == 0)
                bmi.biSizeImage = ((((bmi.biWidth * bmi.biBitCount) + 31) & ~31) >> 3) * bmi.biHeight;

            int p = bmi.biClrUsed;
            if ((p == 0) && (bmi.biBitCount <= 8))
                p = 1 << bmi.biBitCount;
            p = (p * 4) + bmi.biSize + (int)bmpptr;
            return (IntPtr)p;
        }


        private bool ValidateData() {
            bool ret = true;
            if (txtFolder.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาระบุชื่อโฟลเดอร์");
                txtFolder.Focus();
                ret = false;
            }
            else if (ChkExistFloder(txtFolder.Text) == false)
            {
                MessageBox.Show("ไม่มีโฟลเดอร์ที่ระบุ");
                txtFolder.Focus();
                ret = false;
            }
            else if (txtStaffCode.Text.Trim().Length != Config.StaffCodeLength) 
            {
                MessageBox.Show("รหัสเจ้าหน้าที่ไม่ถูกต้อง");
                txtStaffCode.Focus();
                txtStaffCode.SelectAll();
                ret = false;
            }
            else if (cmbTitleName.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาระบุคำนำหน้าชื่อ");
                cmbTitleName.Focus();
                ret = false;
            }
            else if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาระบุชื่อเจ้าหน้าที่");
                txtFirstName.Focus();
                ret = false;
            }
            return ret;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                if (SavePersonal() == true)
                {
                    txtFileRunning.Text = "";
                    txtIsFirstPage.Text = "Y";
                    //txtStaffCode.Text = "";
                    txtDocTypeCode.Text = "";

                    Config.CreateDefaultOutput(txtFolder.Text);
                    StartScan();
                }
            }
        }

        private void ClearForm() {
            txtID.Text = "0";
            txtStaffCode.Text = "";
            cmbTitleName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private bool SavePersonal() {
            bool ret = false;
            PersonalPara para = new PersonalPara();
            para.ID = (txtID.Text != "" ? Convert.ToInt64(txtID.Text) : 0);
            para.STAFF_CODE = txtStaffCode.Text.Trim();
            para.TITLE_NAME = cmbTitleName.Text.Trim();
            para.FIRST_NAME = txtFirstName.Text.Trim();
            para.LAST_NAME = txtLastName.Text.Trim();

            PersonalFunc fnc = new PersonalFunc();
            ret = fnc.SavePersonal(para);
            return ret;
        }

        private bool ChkExistFloder(String fldName) {
            bool ret = true;
            if (Directory.Exists(fldName) == false)
                ret = false;

            return ret;
        }

        private void StartScan() {
            tw = new Twain();
            tw.Init(this.Handle);
            if (Config.GetConfigValue("Config", "SelectScanDriver") == "1")
            {
                tw.Select();
            }
            this.Enabled = false;
            Application.AddMessageFilter(this);
            tw.Acquire();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                txtFolder.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void btnDocType_Click(object sender, EventArgs e)
        {
            frmDocType frm = new frmDocType();
            frm.ShowDialog();
        }

        private void frmScanProcess_Load(object sender, EventArgs e)
        {
            txtFolder.Text = Config.DefaultOutput;
            SetTitleNameCombo();
        }

        private void SetTitleNameCombo()
        {
            PrintBarcodeFunc fnc = new PrintBarcodeFunc();
            DataTable dt = fnc.GetTitleNameList();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbTitleName.Items.Add(dr["title_name"].ToString());
                }
            }
        }

        private void txtStaffCode_TextChanged(object sender, EventArgs e)
        {
            PersonalPara para = new PersonalPara();
            PersonalFunc fnc = new PersonalFunc();
            para = fnc.GetDataByStaffCode(txtStaffCode.Text.Trim());
            txtID.Text = para.ID.ToString();
            cmbTitleName.Text = para.TITLE_NAME;
            txtFirstName.Text = para.FIRST_NAME;
            txtLastName.Text = para.LAST_NAME;
        }
    }
}
