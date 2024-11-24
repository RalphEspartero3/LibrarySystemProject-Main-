namespace LibrarySystemProject_Main_
{
    partial class StudentInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInventory));
            this.lvwStudentInventory = new System.Windows.Forms.ListView();
            this.lblInventoryHeader = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwStudentInventory
            // 
            this.lvwStudentInventory.BackColor = System.Drawing.Color.Tan;
            this.lvwStudentInventory.HideSelection = false;
            this.lvwStudentInventory.Location = new System.Drawing.Point(12, 27);
            this.lvwStudentInventory.Name = "lvwStudentInventory";
            this.lvwStudentInventory.Size = new System.Drawing.Size(560, 183);
            this.lvwStudentInventory.TabIndex = 1;
            this.lvwStudentInventory.UseCompatibleStateImageBehavior = false;
            this.lvwStudentInventory.SelectedIndexChanged += new System.EventHandler(this.lvwStudentInventory_SelectedIndexChanged);
            // 
            // lblInventoryHeader
            // 
            this.lblInventoryHeader.AutoSize = true;
            this.lblInventoryHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblInventoryHeader.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryHeader.Location = new System.Drawing.Point(248, 2);
            this.lblInventoryHeader.Name = "lblInventoryHeader";
            this.lblInventoryHeader.Size = new System.Drawing.Size(82, 22);
            this.lblInventoryHeader.TabIndex = 27;
            this.lblInventoryHeader.Text = "Student";
            this.lblInventoryHeader.Click += new System.EventHandler(this.lblInventoryHeader_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(467, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 27);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(15, 254);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(144, 18);
            this.lblStudentName.TabIndex = 29;
            this.lblStudentName.Text = "Name of Student: ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAuthor.Location = new System.Drawing.Point(15, 283);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(141, 18);
            this.lblAuthor.TabIndex = 30;
            this.lblAuthor.Text = "Year and Section:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Student Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(172, 254);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(263, 20);
            this.txtStudentName.TabIndex = 32;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(172, 281);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(263, 20);
            this.txtSection.TabIndex = 33;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(172, 226);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(263, 20);
            this.txtStudentNo.TabIndex = 34;
            this.txtStudentNo.TextChanged += new System.EventHandler(this.txtStudentNo_TextChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(141, 307);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(89, 27);
            this.btnProceed.TabIndex = 35;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(362, 307);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 27);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 27);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(452, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 27);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(452, 247);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 27);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(252, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 27);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // StudentInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LibrarySystemProject_Main_.Properties.Resources.bgforeverypage;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblInventoryHeader);
            this.Controls.Add(this.lvwStudentInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInventory";
            this.Load += new System.EventHandler(this.StudentInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwStudentInventory;
        private System.Windows.Forms.Label lblInventoryHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
    }
}