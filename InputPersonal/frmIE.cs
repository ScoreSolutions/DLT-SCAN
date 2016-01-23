using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHDocVw;

namespace InputPersonal
{
    public partial class frmIE : Form
    {
        public frmIE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object o = null;
            SHDocVw.InternetExplorer ie = new SHDocVw.InternetExplorerClass();
            IWebBrowserApp wb = (IWebBrowserApp)ie;
            wb.Visible = true;
            //Do anything else with the window here that you wish
            wb.Navigate("www.google.com", ref o, ref o, ref o, ref o);

        }
    }
}
