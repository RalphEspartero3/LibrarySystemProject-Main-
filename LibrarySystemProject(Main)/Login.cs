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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '*'; 
            }
        }

        private int failedAttempts = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (username == "admin" && password == "admin123")
            {
                failedAttempts = 0; 

                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.ShowDialog();
            }
            else
            {
                failedAttempts++;

                if (failedAttempts >= 3)
                {
                    MessageBox.Show("Too many failed attempts. Please wait 5 seconds before trying again.");
                    failedAttempts = 0; 

                    
                    button1.Enabled = false;
                    System.Threading.Tasks.Task.Delay(5000).ContinueWith(t =>
                    {
                        button1.Invoke((Action)(() => button1.Enabled = true));
                    });
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Please try again.");
                }
            }
        }

    }
}
