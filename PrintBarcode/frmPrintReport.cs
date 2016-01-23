using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Func.Master;
using Para.TABLE;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Func.Utilities;

namespace PrintBarcode
{
    public partial class frmPrintReport : Form
    {
        private Label label5;
        private Button btnPrintBarcode;
        private Panel panel2;
        private DataGridView dgDocType;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewCheckBoxColumn colCheckBox;
        private DataGridViewTextBoxColumn colDocTypeCode;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private TextBox txtDoctypeName;
        private TextBox txtDocTypeCode;
        private Button btnSave;
        private DataGridViewTextBoxColumn colDoctypeName;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintReport));
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgDocType = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDocTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctypeName = new System.Windows.Forms.TextBox();
            this.txtDocTypeCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocType)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "ประเภทเอกสาร :";
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPrintBarcode.Location = new System.Drawing.Point(408, 12);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(121, 34);
            this.btnPrintBarcode.TabIndex = 23;
            this.btnPrintBarcode.Text = "พิมพ์บาร์โค้ด";
            this.btnPrintBarcode.UseVisualStyleBackColor = true;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgDocType);
            this.panel2.Location = new System.Drawing.Point(12, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 541);
            this.panel2.TabIndex = 24;
            // 
            // dgDocType
            // 
            this.dgDocType.AllowUserToAddRows = false;
            this.dgDocType.AllowUserToDeleteRows = false;
            this.dgDocType.AllowUserToResizeColumns = false;
            this.dgDocType.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDocType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDocType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCheckBox,
            this.colDocTypeCode,
            this.colDoctypeName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDocType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDocType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDocType.Location = new System.Drawing.Point(0, 0);
            this.dgDocType.Name = "dgDocType";
            this.dgDocType.RowHeadersVisible = false;
            this.dgDocType.RowTemplate.Height = 25;
            this.dgDocType.Size = new System.Drawing.Size(551, 541);
            this.dgDocType.TabIndex = 0;
            this.dgDocType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDoctype_CellDoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "id";
            this.colID.Name = "colID";
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colID.Visible = false;
            // 
            // colCheckBox
            // 
            this.colCheckBox.FalseValue = "N";
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCheckBox.TrueValue = "Y";
            this.colCheckBox.Width = 30;
            // 
            // colDocTypeCode
            // 
            this.colDocTypeCode.DataPropertyName = "doctype_code";
            this.colDocTypeCode.HeaderText = "";
            this.colDocTypeCode.Name = "colDocTypeCode";
            this.colDocTypeCode.Width = 60;
            // 
            // colDoctypeName
            // 
            this.colDoctypeName.DataPropertyName = "doctype_name";
            this.colDoctypeName.HeaderText = "ประเภทเอกสาร";
            this.colDoctypeName.MinimumWidth = 10;
            this.colDoctypeName.Name = "colDoctypeName";
            this.colDoctypeName.ReadOnly = true;
            this.colDoctypeName.Width = 400;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtID.Location = new System.Drawing.Point(308, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 30;
            this.txtID.Text = "0";
            this.txtID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "ชื่อเอกสาร :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "รหัสเอกสาร :";
            // 
            // txtDoctypeName
            // 
            this.txtDoctypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDoctypeName.Location = new System.Drawing.Point(110, 95);
            this.txtDoctypeName.Name = "txtDoctypeName";
            this.txtDoctypeName.Size = new System.Drawing.Size(318, 26);
            this.txtDoctypeName.TabIndex = 27;
            // 
            // txtDocTypeCode
            // 
            this.txtDocTypeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDocTypeCode.Location = new System.Drawing.Point(112, 64);
            this.txtDocTypeCode.MaxLength = 5;
            this.txtDocTypeCode.Name = "txtDocTypeCode";
            this.txtDocTypeCode.Size = new System.Drawing.Size(103, 26);
            this.txtDocTypeCode.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Location = new System.Drawing.Point(20, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPrintReport
            // 
            this.ClientSize = new System.Drawing.Size(575, 716);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoctypeName);
            this.Controls.Add(this.txtDocTypeCode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPrintBarcode);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintReport";
            this.Load += new System.EventHandler(this.frmPrintReport_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDocType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public frmPrintReport()
        {
            InitializeComponent();
        }

        private void frmPrintReport_Load(object sender, EventArgs e)
        {
            SetDoctypeList();
        }

        private void SetDoctypeList()
        {
            DocTypeFunc fnc = new DocTypeFunc();
            DataTable dt = fnc.GetDocTypeAll(null);
            if (dt.Rows.Count > 0)
            {
                dgDocType.AutoGenerateColumns = false;
                dgDocType.DataSource = dt;
            }
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("BARCODE");
            dt.Columns.Add("DOCTYPE_NAME");

            bool IsSelect = false;
            for (int i = 0; i < dgDocType.Rows.Count;i++ )
            {
                if (dgDocType.Rows[i].Cells["colCheckBox"].Value == "Y")
                {
                    IsSelect = true;
                    DataRow dr = dt.NewRow();
                    DocTypeFunc fnc = new DocTypeFunc();
                    DocTypePara para = fnc.GetDocTypePara(Convert.ToInt64(dgDocType.Rows[i].Cells["colID"].Value.ToString()), null);

                    dr["BARCODE"] = "*" + Config.BarcodeStartDigit + para.DOCTYPE_CODE + "*";
                    dr["DOCTYPE_NAME"] = para.DOCTYPE_CODE + " " + para.DOCTYPE_NAME;
                    dt.Rows.Add(dr);
                }
            }

            if (IsSelect == false)
            {
                MessageBox.Show("กรุณาเลือกประเภทเอกสารที่ต้องการพิมพ์");
                dgDocType.Focus();
                return;
            }

            if (dt.Rows.Count > 0)
            {
                TableLogOnInfo logonInfo = new TableLogOnInfo();
                logonInfo.ConnectionInfo.DatabaseName = Config.DbGetDbName;
                logonInfo.ConnectionInfo.ServerName = Config.DbGetDataSource;
                logonInfo.ConnectionInfo.UserID = Config.DbGetUserID;
                logonInfo.ConnectionInfo.Password = Config.DbGetPwd;

                crtPrintBarcode rpt = new crtPrintBarcode();
                frmPrintPreview frm = new frmPrintPreview();
                rpt.SetDataSource(dt);
                rpt.Database.Tables[0].ApplyLogOnInfo(logonInfo);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void btnDocType_Click(object sender, EventArgs e)
        {
            frmDocType frm = new frmDocType();
            frm.ShowDialog();
            SetDoctypeList();
        }
        private void ClearForm()
        {
            txtID.Text = "0";
            txtDocTypeCode.Text = "";
            txtDoctypeName.Text = "";
        }

        private void gvDoctype_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = new DataGridViewRow();
            dgv = dgDocType.Rows[e.RowIndex];

            DocTypeFunc fnc = new DocTypeFunc();
            DocTypePara para = fnc.GetDocTypePara(Convert.ToInt64(dgv.Cells["colID"].Value), null);

            txtID.Text = para.ID.ToString();
            txtDocTypeCode.Text = para.DOCTYPE_CODE;
            txtDoctypeName.Text = para.DOCTYPE_NAME;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                DocTypePara para = new DocTypePara();
                para.ID = Convert.ToInt64(txtID.Text);
                para.DOCTYPE_CODE = txtDocTypeCode.Text;
                para.DOCTYPE_NAME = txtDoctypeName.Text;

                DocTypeFunc fnc = new DocTypeFunc();
                if (fnc.SaveDocType(para) == true)
                {
                    SetDoctypeList();
                    ClearForm();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                    txtDocTypeCode.Focus();
                }
                else
                {
                    MessageBox.Show(fnc.ErrorMessage);
                    txtDocTypeCode.Focus();
                    txtDocTypeCode.SelectAll();
                }
            }
        }

        private bool ValidateData()
        {
            bool ret = true;

            if (txtDocTypeCode.Text.Trim() == "")
            {
                ret = false;
                MessageBox.Show("กรุณาระบุรหัสเอกสาร");
                txtDocTypeCode.Focus();
            }
            else if (txtDocTypeCode.Text.Length != Func.Utilities.Config.DocTypeCodeLength)
            {
                ret = false;
                MessageBox.Show("จำนวนหลักของรหัสเอกสารไม่ถูกต้อง");
                txtDocTypeCode.Focus();
                txtDocTypeCode.SelectAll();
            }
            else if (txtDoctypeName.Text.Trim() == "")
            {
                ret = false;
                MessageBox.Show("กรุณาระบุชื่อเอกสาร");
                txtDoctypeName.Focus();
            }
            else
            {
                DocTypePara para = new DocTypePara();
                para.ID = Convert.ToInt64(txtID.Text);
                para.DOCTYPE_CODE = txtDocTypeCode.Text.Trim();
                para.DOCTYPE_NAME = txtDoctypeName.Text.Trim();

                DocTypeFunc fnc = new DocTypeFunc();
                if (fnc.ChkDupData(para) == true)
                {
                    ret = false;
                    MessageBox.Show(fnc.InfoMessage);
                    txtDocTypeCode.Focus();
                    txtDocTypeCode.SelectAll();
                }
            }

            return ret;
        }
    }
}
