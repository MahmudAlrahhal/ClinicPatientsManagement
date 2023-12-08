using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtPassword.Text.Equals("123"))
            {
                frmRegisterPatient frm = new frmRegisterPatient();
                frm.ShowDialog();
            }
        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
