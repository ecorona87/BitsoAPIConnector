using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitsoDesktopUI
{
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();
        }

        private void frmAuth_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            frmBitsoUI formBitsoUI = new frmBitsoUI(txtKey.Text, txtSecret.Text);
            formBitsoUI.Show();
            this.Hide();
        }
    }
}
