using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Func.Utilities;
using Func.Master;
using Para.TABLE;
using System.IO;
using iTextSharp.text.pdf;

namespace PrintReports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bPreview_Click(object sender, EventArgs e)
        {
            //System.Data.SqlClient.SqlDataReader SqlReader = null;
            DataTable DT = new DataTable();
            DataRow dr = DT.NewRow();

            string  d1,d2 ;
            DateTime dt1 = DateTime.Parse(dateTimePicker1.Text); 
            int Year1 = dt1.Year;
            int Month1 = dt1.Month;
            int day1 = dt1.Day;

            DateTime dt2 = DateTime.Parse(dateTimePicker2.Text);
            int Year2 = dt2.Year;
            int Month2 = dt2.Month;
            int day2 = dt2.Day;

            if (Year1 > 2500)
            {
                d1 = (Year1 - 543).ToString() + "-" + Month1.ToString("00") + "-" + day1.ToString("00");
                d2 = (Year2 - 543).ToString() + "-" + Month2.ToString("00") + "-" + day2.ToString("00");

            }
            else {
                d1 = Year1.ToString() + "-" + Month1.ToString("00") + "-" + day1.ToString("00");
                d2 = Year2.ToString() + "-" + Month2.ToString("00") + "-" + day2.ToString("00");
            }

            string sql = "select h.staff_code as id ,p.first_name +' '+p.last_name name, sum(h.pdf_page) page, ";
            sql += " convert(varchar(10),h.create_on,103) date  ";
            sql += " from scan_history h inner join personal p ";
            sql += " on h.staff_code =p.staff_code  ";
            sql += " where convert(varchar(10),h.create_on,120) between '" + d1 + "' and '" + d2 + "' ";
            sql += " group by h.staff_code, p.first_name, p.last_name, convert(varchar(10),h.create_on,103)";
            sql += " order by h.staff_code";

            Func.Master.ScanHistoryFunc fnc = new Func.Master.ScanHistoryFunc();
            DT = fnc.GetDataBySql(sql);

            if (DT.Rows.Count > 0)
            {
                TableLogOnInfo logonInfo = new TableLogOnInfo();
                logonInfo.ConnectionInfo.DatabaseName = Config.DbGetDbName;
                logonInfo.ConnectionInfo.ServerName = Config.DbGetDataSource;
                logonInfo.ConnectionInfo.UserID = Config.DbGetUserID;
                logonInfo.ConnectionInfo.Password = Config.DbGetPwd;

                SummaryReport rpt = new SummaryReport();
                frmPrintPreview frm = new frmPrintPreview();
                rpt.SetDataSource(DT);
                rpt.Database.Tables[0].ApplyLogOnInfo(logonInfo);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtFolder.Text) == true)
            {
                //DateTime dt1 = DateTime.Parse(dateTimePicker1.Text);
                //DateTime dt2 = DateTime.Parse(dateTimePicker2.Text);

                Config.CreateReportFolder(txtFolder.Text);
                FileFunc fnc = new FileFunc();
                DataTable DT = fnc.GetPDFFileList(txtFolder.Text);

                if (DT.Rows.Count > 0)
                {
                    TableLogOnInfo logonInfo = new TableLogOnInfo();
                    logonInfo.ConnectionInfo.DatabaseName = Config.DbGetDbName;
                    logonInfo.ConnectionInfo.ServerName = Config.DbGetDataSource;
                    logonInfo.ConnectionInfo.UserID = Config.DbGetUserID;
                    logonInfo.ConnectionInfo.Password = Config.DbGetPwd;

                    SummaryReport rpt = new SummaryReport();
                    frmPrintPreview frm = new frmPrintPreview();

                    rpt.SetDataSource(DT);
                    rpt.Database.Tables[0].ApplyLogOnInfo(logonInfo);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                else 
                {
                    MessageBox.Show("ไม่พบข้อมูล");
                }
            }
            else {
                MessageBox.Show("ไม่พบโฟล์เดอร์ที่ระบุ");
            }
        }

        //private DataTable GetFileList(DateTime dateFrom, DateTime dateTo, string folderName) {
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("id");
        //    dt.Columns.Add("name");
        //    dt.Columns.Add("doctype_name");
        //    dt.Columns.Add("date");
        //    dt.Columns.Add("page",typeof(int));
        //    dt.Columns.Add("dateFrom");
        //    dt.Columns.Add("dateTo");
        //    dt.Columns.Add("SortDate");
        //    string[] file = Directory.GetFiles(folderName,"*",SearchOption.AllDirectories);
        //    var fle = from f in file where f.ToUpper().EndsWith("PDF") select f;
        //    foreach (var ff in fle) {
        //        FileInfo prop = new FileInfo(ff);
        //        if (Convert.ToInt64(prop.LastWriteTime.ToString("yyyyMMdd")) >= Convert.ToInt64(dateFrom.ToString("yyyyMMdd")) && Convert.ToInt64(prop.LastWriteTime.ToString("yyyyMMdd")) <= Convert.ToInt64(dateTo.ToString("yyyyMMdd")))
        //        {
        //            string staffCode = prop.Name.Substring(0, Config.StaffCodeLength);
        //            string doctypeCode = prop.Name.Substring(Config.StaffCodeLength + 1).ToUpper().Replace(".PDF","");
        //            DataRow dr = dt.NewRow();
        //            dr["id"] = staffCode;
        //            dr["name"] = GetStaffName(staffCode);
        //            dr["doctype_name"] = GetDocTypeName(doctypeCode);
        //            dr["date"] = prop.LastWriteTime.ToString("dd/MM/yyyy");
        //            dr["page"] = GetPDFPagesCount(ff);
        //            dr["dateFrom"] = dateFrom.ToString("dd/MM/yyyy");
        //            dr["dateTo"] = dateTo.ToString("dd/MM/yyyy");
        //            dr["SortDate"] = prop.LastWriteTime.ToString("yyyyMMdd");

        //            dt.Rows.Add(dr);
        //        }
        //    }
        //    dt.DefaultView.Sort = "id asc";
        //    return dt.DefaultView.ToTable();
        //}

        //private string GetStaffName(string staffCode) {
        //    string ret = "";
        //    PersonalPara para = new PersonalPara();
        //    PersonalFunc fnc = new PersonalFunc();
        //    para = fnc.GetDataByStaffCode(staffCode);
        //    ret = para.TITLE_NAME + para.FIRST_NAME + " " + para.LAST_NAME;

        //    return ret;
        //}
        //private string GetDocTypeName(string doctypeCode) {
        //    string ret = "";
        //    DocTypeFunc fnc = new DocTypeFunc();
        //    DocTypePara para = new DocTypePara();
        //    para = fnc.GetDocTypeByDocTypeCode(doctypeCode);
        //    ret = para.DOCTYPE_NAME;
        //    return ret;
        //}

        //private int GetPDFPagesCount(string FileName)
        //{
        //    int page_count = 0;            
        //    try            
        //    {                
        //        //check for the extension                 
        //        string extension = Path.GetExtension(FileName);
        //        if (extension.ToUpper() == ".PDF")
        //        {
        //            //Create instance for the PDF reader                    
        //            PdfReader pdf_fie = new PdfReader(FileName);
        //            //read it's pagecount                    
        //            page_count = pdf_fie.NumberOfPages;
        //            //close the file                    
        //            pdf_fie.Close();
        //        }
        //    }
        //    catch (PdfException ex) {
        //        //ex.Message();
        //    } 
        //    return page_count;
        //}

        private void txtBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFolder.Text = Config.GetConfigValue(Config.ConfigReportFolder, "ReportFolder");
        } 

    }
}
