namespace LibrarySystemProject_Main_
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.lvwBookInventory = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblInventoryHeader = new System.Windows.Forms.Label();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtCopiesAvailable = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYearPublished = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblCopyAvailable = new System.Windows.Forms.Label();
            this.lblYrPublished = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwBookInventory
            // 
            this.lvwBookInventory.BackColor = System.Drawing.Color.Tan;
            this.lvwBookInventory.HideSelection = false;
            this.lvwBookInventory.Location = new System.Drawing.Point(12, 31);
            this.lvwBookInventory.Name = "lvwBookInventory";
            this.lvwBookInventory.Size = new System.Drawing.Size(560, 200);
            this.lvwBookInventory.TabIndex = 0;
            this.lvwBookInventory.UseCompatibleStateImageBehavior = false;
            this.lvwBookInventory.SelectedIndexChanged += new System.EventHandler(this.lvwBookInventory_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(394, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(394, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(485, 249);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblInventoryHeader
            // 
            this.lblInventoryHeader.AutoSize = true;
            this.lblInventoryHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblInventoryHeader.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryHeader.Location = new System.Drawing.Point(241, 6);
            this.lblInventoryHeader.Name = "lblInventoryHeader";
            this.lblInventoryHeader.Size = new System.Drawing.Size(105, 22);
            this.lblInventoryHeader.TabIndex = 4;
            this.lblInventoryHeader.Text = "Inventory";
            this.lblInventoryHeader.Click += new System.EventHandler(this.lblInventoryHeader_Click);
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(125, 239);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(263, 20);
            this.txtBook.TabIndex = 17;
            // 
            // txtCopiesAvailable
            // 
            this.txtCopiesAvailable.Location = new System.Drawing.Point(141, 315);
            this.txtCopiesAvailable.Name = "txtCopiesAvailable";
            this.txtCopiesAvailable.Size = new System.Drawing.Size(247, 20);
            this.txtCopiesAvailable.TabIndex = 18;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(125, 263);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(263, 20);
            this.txtAuthor.TabIndex = 19;
            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(143, 289);
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.Size = new System.Drawing.Size(245, 20);
            this.txtYearPublished.TabIndex = 20;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.BackColor = System.Drawing.Color.Transparent;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(12, 239);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(53, 18);
            this.lblBook.TabIndex = 21;
            this.lblBook.Text = "Book:";
            // 
            // lblCopyAvailable
            // 
            this.lblCopyAvailable.AutoSize = true;
            this.lblCopyAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyAvailable.Location = new System.Drawing.Point(12, 317);
            this.lblCopyAvailable.Name = "lblCopyAvailable";
            this.lblCopyAvailable.Size = new System.Drawing.Size(123, 18);
            this.lblCopyAvailable.TabIndex = 22;
            this.lblCopyAvailable.Text = "Copy Available:";
            // 
            // lblYrPublished
            // 
            this.lblYrPublished.AutoSize = true;
            this.lblYrPublished.BackColor = System.Drawing.Color.Transparent;
            this.lblYrPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYrPublished.Location = new System.Drawing.Point(12, 291);
            this.lblYrPublished.Name = "lblYrPublished";
            this.lblYrPublished.Size = new System.Drawing.Size(125, 18);
            this.lblYrPublished.TabIndex = 23;
            this.lblYrPublished.Text = "Year Published:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuthor.Location = new System.Drawing.Point(12, 265);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 18);
            this.lblAuthor.TabIndex = 24;
            this.lblAuthor.Text = "Author:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(3, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(105, 27);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(467, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 27);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(487, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystemProject_Main_.Properties.Resources.bgforeverypage;
            this.ClientSize = new System.Drawing.Size(584, 339);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblYrPublished);
            this.Controls.Add(this.lblCopyAvailable);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.txtYearPublished);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtCopiesAvailable);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblInventoryHeader);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvwBookInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwBookInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblInventoryHeader;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtCopiesAvailable;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYearPublished;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblCopyAvailable;
        private System.Windows.Forms.Label lblYrPublished;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClear;
    }
}