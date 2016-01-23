using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Func.Utilities;
using Func.Master;
using IEAutomation;
using SHDocVw;
using mshtml;

namespace DLT_Upload
{
    public partial class frmFileUpload : Form
    {
        string _err = "";
        public frmFileUpload()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath;
                ListPDFFile(new DateTime(2011, 6, 27), DateTime.Today, txtFolder.Text);
            }
        }

        private void frmFileUpload_Load(object sender, EventArgs e)
        {
            txtFolder.Text = Config.GetConfigValue(Config.ConfigReportFolder, "ReportFolder");
            ListPDFFile(new DateTime(2011,6,27), DateTime.Today, txtFolder.Text);
        }

        private void ListPDFFile(DateTime dateFrom, DateTime dateTo, string fldName) {
            if (Directory.Exists(fldName) == false)
            {
                MessageBox.Show("ไม่พบโฟลเดอร์ที่ระบุ");
                txtFolder.Focus();
                txtFolder.SelectAll();
                return;
            }

            FileFunc fnc = new FileFunc();
            gvFileList.AutoGenerateColumns = false;
            //gvFileList.DataSource = fnc.GetPDFFileList(dateFrom, dateTo, fldName);
            gvFileList.DataSource = fnc.GetFileList(dateFrom, dateTo, fldName, "JPG");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtFolder.Text) == false)
            {
                MessageBox.Show("ไม่พบโฟลเดอร์ที่ระบุ");
                txtFolder.Focus();
                txtFolder.SelectAll();
                return;
            }else if(gvFileList.SelectedRows.Count==0){
                MessageBox.Show("กรุณาเลือกไฟล์ที่ต้องการอัพโหลด");
                txtFolder.Focus();
                txtFolder.SelectAll();
                return;
            }

            this.Enabled = false;
            for (int i=0;i<gvFileList.SelectedRows.Count;i++){
                string fileName = gvFileList.SelectedRows[i].Cells["colFileName"].Value.ToString();
                if (UploadFile(fileName) == true)
                {

                }
                else {
                    MessageBox.Show(_err);
                    this.Enabled = true;
                    return;
                }
            }

            this.Enabled = true;
        }

        private bool UploadFile(string filePath) {
            bool ret = false;
            IEDriver ie = new IEDriver();
            if (ie.ErrorMessage == "")
            {
                ie.Navigate("www.google.com");
                ret = true;
            }
            else {
                _err = ie.ErrorMessage;
            }
            return ret;
        }


        public InternetExplorer ie2;
        
        private void TestForIE() {
            object empty = "";
            ie2.Navigate("www.google.com", ref empty, ref empty, ref empty, ref empty);
            
            mshtml.IHTMLDocument2 doc = ie2.Document as mshtml.IHTMLDocument2;

            mshtml.IHTMLWindow2 window = doc.Script as mshtml.IHTMLWindow2;
            window.execScript("MyJavaScript(43535)", "javascript");
            //IHTMLWindow2 window = ie.Document.parentWindow;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestForIE();
        }
    }
}
