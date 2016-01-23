using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Func.Master;
using Func.Utilities;
using Para.TABLE;

namespace InputPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                if (SavePersonal() == true)
                {
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                    ClearForm();
                    SetTitleNameCombo();
                    txtStaffCode.Focus();
                }
            }
        }

        private bool ValidateData()
        {
            bool ret = true;
            if (txtStaffCode.Text.Trim().Length != Config.StaffCodeLength)
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

        private void ClearForm()
        {
            txtID.Text = "0";
            txtStaffCode.Text = "";
            cmbTitleName.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStaffCode.Focus();
        }

        private bool SavePersonal()
        {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
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

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
