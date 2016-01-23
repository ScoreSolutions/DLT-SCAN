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

namespace PrintBarcode
{
    public partial class frmDocType : Form
    {
        public frmDocType()
        {
            InitializeComponent();
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
                    getDocTypeAllList();
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

        private bool ValidateData() {
            bool ret = true;
            
            if (txtDocTypeCode.Text.Trim() == "") {
                ret = false;
                MessageBox.Show("กรุณาระบุรหัสเอกสาร");
                txtDocTypeCode.Focus();
            }else if(txtDocTypeCode.Text.Length != Func.Utilities.Config.DocTypeCodeLength){
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
            else{
                DocTypePara para = new DocTypePara();
                para.ID = Convert.ToInt64(txtID.Text);
                para.DOCTYPE_CODE = txtDocTypeCode.Text.Trim();
                para.DOCTYPE_NAME = txtDoctypeName.Text.Trim();

                DocTypeFunc fnc = new DocTypeFunc();
                if (fnc.ChkDupData(para) == true) {
                    ret = false;
                    MessageBox.Show(fnc.InfoMessage);
                    txtDocTypeCode.Focus();
                    txtDocTypeCode.SelectAll();
                }
            }

            return ret;
        }

        private void getDocTypeAllList() {
            DocTypeFunc fnc = new DocTypeFunc();
            gvDoctype.AutoGenerateColumns = false;
            gvDoctype.DataSource = fnc.GetDocTypeAll(null);
        }

        private void frmDocType_Load(object sender, EventArgs e)
        {
            getDocTypeAllList();
        }
        private void ClearForm() {
            txtID.Text = "0";
            txtDocTypeCode.Text = "";
            txtDoctypeName.Text = "";
        }

        private void gvDoctype_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = new DataGridViewRow();
            dgv = gvDoctype.Rows[e.RowIndex];

            DocTypeFunc fnc = new DocTypeFunc();
            DocTypePara para = fnc.GetDocTypePara(Convert.ToInt64(dgv.Cells["colID"].Value), null);

            txtID.Text = para.ID.ToString();
            txtDocTypeCode.Text = para.DOCTYPE_CODE;
            txtDoctypeName.Text = para.DOCTYPE_NAME;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "0") {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
                return;
            }

            DocTypeFunc fnc = new DocTypeFunc();
            if (fnc.DeleteDocType(Convert.ToInt16(txtID.Text)) == true)
            {
                ClearForm();
                getDocTypeAllList();
                MessageBox.Show("ลบข้อมูลเรียบร้อย");
            }
            else {
                MessageBox.Show(fnc.ErrorMessage);
            }


        }

        private void gvDoctype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
