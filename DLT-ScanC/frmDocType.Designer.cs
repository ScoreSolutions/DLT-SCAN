namespace DLT_ScanC
{
    partial class frmDocType
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctypeName = new System.Windows.Forms.TextBox();
            this.txtDocTypeCode = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gvDoctype = new System.Windows.Forms.DataGridView();
            this.colDocTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctype)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtDoctypeName);
            this.splitContainer1.Panel1.Controls.Add(this.txtDocTypeCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvDoctype);
            this.splitContainer1.Size = new System.Drawing.Size(766, 478);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(239, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            this.txtID.Text = "0";
            this.txtID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ชื่อเอกสาร :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "รหัสเอกสาร :";
            // 
            // txtDoctypeName
            // 
            this.txtDoctypeName.Location = new System.Drawing.Point(130, 48);
            this.txtDoctypeName.Name = "txtDoctypeName";
            this.txtDoctypeName.Size = new System.Drawing.Size(318, 20);
            this.txtDoctypeName.TabIndex = 3;
            // 
            // txtDocTypeCode
            // 
            this.txtDocTypeCode.Location = new System.Drawing.Point(130, 22);
            this.txtDocTypeCode.MaxLength = 5;
            this.txtDocTypeCode.Name = "txtDocTypeCode";
            this.txtDocTypeCode.Size = new System.Drawing.Size(75, 20);
            this.txtDocTypeCode.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(222, 94);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "ลบ";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gvDoctype
            // 
            this.gvDoctype.AllowUserToAddRows = false;
            this.gvDoctype.AllowUserToDeleteRows = false;
            this.gvDoctype.AllowUserToResizeRows = false;
            this.gvDoctype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDoctype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocTypeCode,
            this.colDocTypeName,
            this.colID});
            this.gvDoctype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDoctype.Location = new System.Drawing.Point(0, 0);
            this.gvDoctype.MultiSelect = false;
            this.gvDoctype.Name = "gvDoctype";
            this.gvDoctype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDoctype.Size = new System.Drawing.Size(766, 341);
            this.gvDoctype.TabIndex = 0;
            this.gvDoctype.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDoctype_CellDoubleClick);
            // 
            // colDocTypeCode
            // 
            this.colDocTypeCode.DataPropertyName = "doctype_code";
            this.colDocTypeCode.HeaderText = "รหัสเอกสาร";
            this.colDocTypeCode.Name = "colDocTypeCode";
            // 
            // colDocTypeName
            // 
            this.colDocTypeName.DataPropertyName = "doctype_name";
            this.colDocTypeName.HeaderText = "ชื่อเอกสาร";
            this.colDocTypeName.Name = "colDocTypeName";
            this.colDocTypeName.Width = 350;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "id";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // frmDocType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 478);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDocType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "กำหนดประเภทเอกสาร";
            this.Load += new System.EventHandler(this.frmDocType_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvDoctype;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoctypeName;
        private System.Windows.Forms.TextBox txtDocTypeCode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
    }
}