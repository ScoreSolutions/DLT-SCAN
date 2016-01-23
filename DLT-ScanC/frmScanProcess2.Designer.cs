namespace DLT_ScanC
{
    partial class frmScanProcess2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScanProcess2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDocTypeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTitleName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDocType = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtFileRunning = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtIsFirstPage = new System.Windows.Forms.TextBox();
            this.txtDocTypeCode = new System.Windows.Forms.TextBox();
            this.txtFileTestOCR = new System.Windows.Forms.TextBox();
            this.txtStaffCode = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDocTypeName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTitleName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDocType);
            this.panel1.Controls.Add(this.lblProgress);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.txtFileRunning);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtIsFirstPage);
            this.panel1.Controls.Add(this.txtDocTypeCode);
            this.panel1.Controls.Add(this.txtFileTestOCR);
            this.panel1.Controls.Add(this.txtStaffCode);
            this.panel1.Controls.Add(this.txtFolder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 229);
            this.panel1.TabIndex = 0;
            // 
            // txtDocTypeName
            // 
            this.txtDocTypeName.Enabled = false;
            this.txtDocTypeName.Location = new System.Drawing.Point(183, 144);
            this.txtDocTypeName.Name = "txtDocTypeName";
            this.txtDocTypeName.Size = new System.Drawing.Size(240, 20);
            this.txtDocTypeName.TabIndex = 21;
            this.txtDocTypeName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(7, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "ประเภทเอกสาร :";
            this.label6.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(26, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(41, 20);
            this.txtID.TabIndex = 19;
            this.txtID.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(304, 118);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 20);
            this.txtLastName.TabIndex = 18;
            this.txtLastName.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(242, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "นามสกุล :";
            this.label5.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(111, 118);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(25, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "ชื่อเจ้าหน้าที่ :";
            this.label4.Visible = false;
            // 
            // cmbTitleName
            // 
            this.cmbTitleName.FormattingEnabled = true;
            this.cmbTitleName.Location = new System.Drawing.Point(111, 91);
            this.cmbTitleName.Name = "cmbTitleName";
            this.cmbTitleName.Size = new System.Drawing.Size(121, 21);
            this.cmbTitleName.TabIndex = 3;
            this.cmbTitleName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "คำนำหน้าชื่อ :";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(41, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "รหัสแฟ้ม :";
            // 
            // btnDocType
            // 
            this.btnDocType.Location = new System.Drawing.Point(404, 90);
            this.btnDocType.Name = "btnDocType";
            this.btnDocType.Size = new System.Drawing.Size(91, 23);
            this.btnDocType.TabIndex = 10;
            this.btnDocType.Text = "ประเภทเอกสาร";
            this.btnDocType.UseVisualStyleBackColor = true;
            this.btnDocType.Visible = false;
            this.btnDocType.Click += new System.EventHandler(this.btnDocType_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblProgress.Location = new System.Drawing.Point(3, 177);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(11, 16);
            this.lblProgress.TabIndex = 11;
            this.lblProgress.Text = ".";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 199);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // txtFileRunning
            // 
            this.txtFileRunning.Location = new System.Drawing.Point(304, 92);
            this.txtFileRunning.Name = "txtFileRunning";
            this.txtFileRunning.Size = new System.Drawing.Size(28, 20);
            this.txtFileRunning.TabIndex = 5;
            this.txtFileRunning.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStart.Location = new System.Drawing.Point(111, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(420, 63);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(420, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtIsFirstPage
            // 
            this.txtIsFirstPage.Location = new System.Drawing.Point(338, 92);
            this.txtIsFirstPage.Name = "txtIsFirstPage";
            this.txtIsFirstPage.Size = new System.Drawing.Size(24, 20);
            this.txtIsFirstPage.TabIndex = 2;
            this.txtIsFirstPage.Text = "Y";
            this.txtIsFirstPage.Visible = false;
            // 
            // txtDocTypeCode
            // 
            this.txtDocTypeCode.Location = new System.Drawing.Point(111, 144);
            this.txtDocTypeCode.Name = "txtDocTypeCode";
            this.txtDocTypeCode.Size = new System.Drawing.Size(64, 20);
            this.txtDocTypeCode.TabIndex = 5;
            this.txtDocTypeCode.Visible = false;
            this.txtDocTypeCode.TextChanged += new System.EventHandler(this.txtDocTypeCode_TextChanged);
            this.txtDocTypeCode.Leave += new System.EventHandler(this.txtDocTypeCode_Leave);
            // 
            // txtFileTestOCR
            // 
            this.txtFileTestOCR.Location = new System.Drawing.Point(263, 66);
            this.txtFileTestOCR.Name = "txtFileTestOCR";
            this.txtFileTestOCR.Size = new System.Drawing.Size(142, 20);
            this.txtFileTestOCR.TabIndex = 1;
            this.txtFileTestOCR.Text = "D:\\Tmp\\ScanForTest";
            this.txtFileTestOCR.Visible = false;
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.Location = new System.Drawing.Point(111, 38);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.Size = new System.Drawing.Size(121, 20);
            this.txtStaffCode.TabIndex = 2;
            this.txtStaffCode.TextChanged += new System.EventHandler(this.txtStaffCode_TextChanged);
            // 
            // txtFolder
            // 
            this.txtFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFolder.Location = new System.Drawing.Point(111, 10);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(314, 22);
            this.txtFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output :";
            // 
            // frmScanProcess2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 253);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScanProcess2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Solutions CO., LTD > Scan Image Processing";
            this.Load += new System.EventHandler(this.frmScanProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtStaffCode;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TextBox txtDocTypeCode;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDocType;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtFileRunning;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtIsFirstPage;
        private System.Windows.Forms.TextBox txtFileTestOCR;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTitleName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocTypeName;
    }
}