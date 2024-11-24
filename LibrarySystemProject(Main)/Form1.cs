using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemProject_Main_
{
    public partial class frmWelcomePage : Form
    {
        public frmWelcomePage()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void cboxBorrowerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBrwrType_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void btnLogin_Click(object sender, EventArgs e)
        {

          frmLogin login = new frmLogin();  
          this.Hide();
          login.ShowDialog();
        }
        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
