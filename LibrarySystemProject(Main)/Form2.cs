using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LibrarySystemProject_Main_
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void lvwBookInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            lvwBookInventory.Columns.Add("No.", 50);
            lvwBookInventory.Columns.Add("Book", 180);
            lvwBookInventory.Columns.Add("Author", 150);
            lvwBookInventory.Columns.Add("Year \nPublished", 100);
            lvwBookInventory.Columns.Add("Copies \nAvailable", 100);
            lvwBookInventory.View = View.Details;
            lvwBookInventory.FullRowSelect = true;
            lvwBookInventory.GridLines = true;

            LoadBookData();
        }

        private void lblInventoryHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string book = txtBook.Text;
            string author = txtAuthor.Text;
            string yearPublished = txtYearPublished.Text;
            string copiesAvailable = txtCopiesAvailable.Text;

            if (string.IsNullOrWhiteSpace(book) || string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(yearPublished) || string.IsNullOrWhiteSpace(copiesAvailable))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newIndex = lvwBookInventory.Items.Count + 1;
            ListViewItem item = new ListViewItem(newIndex.ToString());
            item.SubItems.Add(book);
            item.SubItems.Add(author);
            item.SubItems.Add(yearPublished);
            item.SubItems.Add(copiesAvailable);
            lvwBookInventory.Items.Add(item);

            SaveBookData();

            txtBook.Clear();
            txtAuthor.Clear();
            txtYearPublished.Clear();
            txtCopiesAvailable.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwBookInventory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected item?", "Confirm Delete",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lvwBookInventory.Items.Remove(lvwBookInventory.SelectedItems[0]);
                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < lvwBookInventory.Items.Count; i++)
                {
                    lvwBookInventory.Items[i].Text = (i + 1).ToString();
                }

                SaveBookData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwBookInventory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lvwBookInventory.SelectedItems[0];

            txtBook.Text = selectedItem.SubItems[1].Text;
            txtAuthor.Text = selectedItem.SubItems[2].Text;
            txtYearPublished.Text = selectedItem.SubItems[3].Text;
            txtCopiesAvailable.Text = selectedItem.SubItems[4].Text;

            var result = MessageBox.Show("Save changes to this item?", "Confirm Edit",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                selectedItem.SubItems[1].Text = txtBook.Text;
                selectedItem.SubItems[2].Text = txtAuthor.Text;
                selectedItem.SubItems[3].Text = txtYearPublished.Text;
                selectedItem.SubItems[4].Text = txtCopiesAvailable.Text;

                MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveBookData();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBook.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtYearPublished.Text = string.Empty;
            txtCopiesAvailable.Text = string.Empty;
        }

        private void LoadBookData()
        {
            if (File.Exists("books.json"))
            {
                string json = File.ReadAllText("books.json");
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(json);

                foreach (var book in books)
                {
                    ListViewItem listItem = new ListViewItem(book.No);
                    listItem.SubItems.Add(book.BookTitle);
                    listItem.SubItems.Add(book.Author);
                    listItem.SubItems.Add(book.YearPublished);
                    listItem.SubItems.Add(book.CopiesAvailable.ToString());

                    lvwBookInventory.Items.Add(listItem);
                }
            }
        }

        private void SaveBookData()
        {
            List<Book> books = new List<Book>();

            foreach (ListViewItem item in lvwBookInventory.Items)
            {
                Book book = new Book
                {
                    No = item.Text,
                    BookTitle = item.SubItems[1].Text,
                    Author = item.SubItems[2].Text,
                    YearPublished = item.SubItems[3].Text,
                    CopiesAvailable = int.Parse(item.SubItems[4].Text)
                };

                books.Add(book);
            }

            string json = JsonConvert.SerializeObject(books, Formatting.Indented);
            File.WriteAllText("books.json", json);
        }
    }

    public class Book
    {
        public string No { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string YearPublished { get; set; }
        public int CopiesAvailable { get; set; }
    }
}
