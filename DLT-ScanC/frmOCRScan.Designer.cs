namespace DLT_ScanC
{
    partial class frmOCRScan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnScanBarcode = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtZoneX = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtZoneHeight = new System.Windows.Forms.TextBox();
            this.txtZoneY = new System.Windows.Forms.TextBox();
            this.txtZoneWidth = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 47);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblResult);
            this.splitContainer1.Size = new System.Drawing.Size(700, 424);
            this.splitContainer1.SplitterDistance = 537;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(4, 13);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "label1";
            // 
            // btnScanBarcode
            // 
            this.btnScanBarcode.Location = new System.Drawing.Point(0, 12);
            this.btnScanBarcode.Name = "btnScanBarcode";
            this.btnScanBarcode.Size = new System.Drawing.Size(75, 23);
            this.btnScanBarcode.TabIndex = 1;
            this.btnScanBarcode.Text = "ScanBarcode";
            this.btnScanBarcode.UseVisualStyleBackColor = true;
            this.btnScanBarcode.Click += new System.EventHandler(this.btnScanBarcode_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(3, 477);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(697, 92);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtZoneX
            // 
            this.txtZoneX.Location = new System.Drawing.Point(233, 15);
            this.txtZoneX.Name = "txtZoneX";
            this.txtZoneX.Size = new System.Drawing.Size(44, 20);
            this.txtZoneX.TabIndex = 40;
            this.txtZoneX.Text = "0";
            this.txtZoneX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(109, 15);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(132, 16);
            this.Label6.TabIndex = 44;
            this.Label6.Text = "Upper Left Corner (X,Y)";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZoneHeight
            // 
            this.txtZoneHeight.Location = new System.Drawing.Point(473, 15);
            this.txtZoneHeight.Name = "txtZoneHeight";
            this.txtZoneHeight.Size = new System.Drawing.Size(44, 20);
            this.txtZoneHeight.TabIndex = 43;
            this.txtZoneHeight.Text = "0";
            this.txtZoneHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtZoneY
            // 
            this.txtZoneY.Location = new System.Drawing.Point(281, 15);
            this.txtZoneY.Name = "txtZoneY";
            this.txtZoneY.Size = new System.Drawing.Size(44, 20);
            this.txtZoneY.TabIndex = 41;
            this.txtZoneY.Text = "0";
            this.txtZoneY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtZoneWidth
            // 
            this.txtZoneWidth.Location = new System.Drawing.Point(425, 15);
            this.txtZoneWidth.Name = "txtZoneWidth";
            this.txtZoneWidth.Size = new System.Drawing.Size(44, 20);
            this.txtZoneWidth.TabIndex = 42;
            this.txtZoneWidth.Text = "0";
            this.txtZoneWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(349, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(144, 16);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Width/Height";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOCRScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 572);
            this.Controls.Add(this.txtZoneX);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtZoneHeight);
            this.Controls.Add(this.txtZoneY);
            this.Controls.Add(this.txtZoneWidth);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnScanBarcode);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmOCRScan";
            this.Text = "frmOCRScan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnScanBarcode;
        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.TextBox txtZoneX;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtZoneHeight;
        internal System.Windows.Forms.TextBox txtZoneY;
        internal System.Windows.Forms.TextBox txtZoneWidth;
        internal System.Windows.Forms.Label Label2;
    }
}