using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LibrarySystemProject_Main_
{
    public partial class StudentInventory : Form
    {
        public StudentInventory()
        {
            InitializeComponent();
        }

        private void lblInventoryHeader_Click(object sender, EventArgs e)
        {

        }

        private void lvwStudentInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNo.Text;
            string studentName = txtStudentName.Text;
            string section = txtSection.Text;

            if (string.IsNullOrWhiteSpace(studentNumber) || string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(section))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            foreach (ListViewItem item in lvwStudentInventory.Items)
            {
                if (item.SubItems[1].Text == studentNumber)
                {
                    MessageBox.Show("This student number already exists.");
                    return;
                }
            }

            string studentNo = (lvwStudentInventory.Items.Count + 1).ToString();

            ListViewItem listItem = new ListViewItem(studentNo);
            listItem.SubItems.Add(studentNumber);
            listItem.SubItems.Add(studentName);
            listItem.SubItems.Add(section);

            lvwStudentInventory.Items.Add(listItem);

            SaveStudentData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwStudentInventory.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwStudentInventory.SelectedItems[0];
                string newStudentNumber = txtStudentNo.Text;
                string newStudentName = txtStudentName.Text;
                string newSection = txtSection.Text;

                if (string.IsNullOrWhiteSpace(newStudentNumber) || string.IsNullOrWhiteSpace(newStudentName) || string.IsNullOrWhiteSpace(newSection))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                foreach (ListViewItem item in lvwStudentInventory.Items)
                {
                    if (item != selectedItem && item.SubItems[1].Text == newStudentNumber)
                    {
                        MessageBox.Show("This student number already exists.");
                        return;
                    }
                }

                selectedItem.SubItems[1].Text = newStudentNumber;
                selectedItem.SubItems[2].Text = newStudentName;
                selectedItem.SubItems[3].Text = newSection;

                SaveStudentData();
            }
            else
            {
                MessageBox.Show("Please select a student to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwStudentInventory.SelectedItems.Count > 0)
            {
                lvwStudentInventory.Items.Remove(lvwStudentInventory.SelectedItems[0]);
                SaveStudentData();
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (lvwStudentInventory.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwStudentInventory.SelectedItems[0];
                string studentName = selectedItem.SubItems[2].Text;

                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.ShowDialog();
                   
       
            }
            else
            {
                MessageBox.Show("Please select a student to proceed.");
            }
        }

        private void StudentInventory_Load(object sender, EventArgs e)
        {
            lvwStudentInventory.Columns.Add("No.", 50);
            lvwStudentInventory.Columns.Add("Student Number", 100);
            lvwStudentInventory.Columns.Add("Name", 150);
            lvwStudentInventory.Columns.Add("Section", 100);

            lvwStudentInventory.View = View.Details;
            lvwStudentInventory.FullRowSelect = true;
            lvwStudentInventory.GridLines = true;

            LoadStudentData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Text = string.Empty;
            txtSection.Text = string.Empty;
            txtStudentNo.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentData()
        {
            if (File.Exists("students.json"))
            {
                string json = File.ReadAllText("students.json");
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);

                foreach (var student in students)
                {
                    ListViewItem listItem = new ListViewItem(student.No);
                    listItem.SubItems.Add(student.StudentNumber);
                    listItem.SubItems.Add(student.Name);
                    listItem.SubItems.Add(student.Section);

                    lvwStudentInventory.Items.Add(listItem);
                }
            }
        }

        private void SaveStudentData()
        {
            List<Student> students = new List<Student>();

            foreach (ListViewItem item in lvwStudentInventory.Items)
            {
                Student student = new Student
                {
                    No = item.Text,
                    StudentNumber = item.SubItems[1].Text,
                    Name = item.SubItems[2].Text,
                    Section = item.SubItems[3].Text
                };

                students.Add(student);
            }

            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText("students.json", json);
        }
    }

    public class Student
    {
        public string No { get; set; }
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
    }
}
