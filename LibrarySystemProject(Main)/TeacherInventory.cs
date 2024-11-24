using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LibrarySystemProject_Main_
{
    public partial class TeacherInventory : Form
    {
        public TeacherInventory()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeacherInventory_Load(object sender, EventArgs e)
        {
            lvwTeacherInventory.Columns.Add("No.", 50);
            lvwTeacherInventory.Columns.Add("Name", 150);
            lvwTeacherInventory.Columns.Add("Department", 300);

            lvwTeacherInventory.View = View.Details;
            lvwTeacherInventory.FullRowSelect = true;
            lvwTeacherInventory.GridLines = true;

            lvwTeacherInventory.SelectedIndexChanged += new EventHandler(this.lvwTeacherInventory_SelectedIndexChanged);

            LoadTeacherData();
        }

        private void lvwTeacherInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDepartment.Text = string.Empty;
            txtProfName.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string teacherName = txtProfName.Text;
            string department = txtDepartment.Text;

            if (string.IsNullOrWhiteSpace(teacherName) || string.IsNullOrWhiteSpace(department))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            foreach (ListViewItem item in lvwTeacherInventory.Items)
            {
                if (item.SubItems[1].Text == teacherName)
                {
                    MessageBox.Show("This teacher already exists.");
                    return;
                }
            }

            string teacherNo = (lvwTeacherInventory.Items.Count + 1).ToString();

            ListViewItem listItem = new ListViewItem(teacherNo);
            listItem.SubItems.Add(teacherName);
            listItem.SubItems.Add(department);

            lvwTeacherInventory.Items.Add(listItem);

            SaveTeacherData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwTeacherInventory.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwTeacherInventory.SelectedItems[0];
                string newTeacherName = txtProfName.Text;
                string newDepartment = txtDepartment.Text;

                if (string.IsNullOrWhiteSpace(newTeacherName) || string.IsNullOrWhiteSpace(newDepartment))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                foreach (ListViewItem item in lvwTeacherInventory.Items)
                {
                    if (item != selectedItem && item.SubItems[1].Text == newTeacherName)
                    {
                        MessageBox.Show("This teacher already exists.");
                        return;
                    }
                }

                selectedItem.SubItems[1].Text = newTeacherName;
                selectedItem.SubItems[2].Text = newDepartment;

                SaveTeacherData();
            }
            else
            {
                MessageBox.Show("Please select a teacher to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwTeacherInventory.SelectedItems.Count > 0)
            {
                lvwTeacherInventory.Items.Remove(lvwTeacherInventory.SelectedItems[0]);
                SaveTeacherData();
            }
            else
            {
                MessageBox.Show("Please select a teacher to delete.");
            }
        }

        private void LoadTeacherData()
        {
            if (File.Exists("teachers.json"))
            {
                string json = File.ReadAllText("teachers.json");
                List<Teacher> teachers = JsonConvert.DeserializeObject<List<Teacher>>(json);

                foreach (var teacher in teachers)
                {
                    ListViewItem listItem = new ListViewItem(teacher.No);
                    listItem.SubItems.Add(teacher.Name);
                    listItem.SubItems.Add(teacher.Department);

                    lvwTeacherInventory.Items.Add(listItem);
                }
            }
        }

        private void SaveTeacherData()
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (ListViewItem item in lvwTeacherInventory.Items)
            {
                Teacher teacher = new Teacher
                {
                    No = item.Text,
                    Name = item.SubItems[1].Text,
                    Department = item.SubItems[2].Text
                };

                teachers.Add(teacher);
            }

            string json = JsonConvert.SerializeObject(teachers, Formatting.Indented);
            File.WriteAllText("teachers.json", json);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvwTeacherInventory.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwTeacherInventory.SelectedItems[0];
                string profName = selectedItem.SubItems[2].Text;

                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a teacher to proceed.");
            }
        }

    }

    public class Teacher
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
