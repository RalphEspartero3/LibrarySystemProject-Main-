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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();    
            this.Hide();
            inventory.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentInventory student = new StudentInventory();
            this.Hide();
            student.ShowDialog();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            TeacherInventory teacher = new TeacherInventory();
            this.Hide();    
            teacher.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }
    }
}
