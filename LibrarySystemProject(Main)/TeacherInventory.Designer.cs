namespace LibrarySystemProject_Main_
{
    partial class TeacherInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInventory));
            this.lblInventoryHeader = new System.Windows.Forms.Label();
            this.lvwTeacherInventory = new System.Windows.Forms.ListView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInventoryHeader
            // 
            this.lblInventoryHeader.AutoSize = true;
            this.lblInventoryHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblInventoryHeader.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryHeader.Location = new System.Drawing.Point(252, 9);
            this.lblInventoryHeader.Name = "lblInventoryHeader";
            this.lblInventoryHeader.Size = new System.Drawing.Size(89, 22);
            this.lblInventoryHeader.TabIndex = 28;
            this.lblInventoryHeader.Text = "Teacher";
            // 
            // lvwTeacherInventory
            // 
            this.lvwTeacherInventory.BackColor = System.Drawing.Color.Tan;
            this.lvwTeacherInventory.HideSelection = false;
            this.lvwTeacherInventory.Location = new System.Drawing.Point(12, 34);
            this.lvwTeacherInventory.Name = "lvwTeacherInventory";
            this.lvwTeacherInventory.Size = new System.Drawing.Size(560, 183);
            this.lvwTeacherInventory.TabIndex = 29;
            this.lvwTeacherInventory.UseCompatibleStateImageBehavior = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(467, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 27);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(21, 231);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 18);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Professor\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(21, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Department:";
            // 
            // txtProfName
            // 
            this.txtProfName.Location = new System.Drawing.Point(177, 229);
            this.txtProfName.Name = "txtProfName";
            this.txtProfName.Size = new System.Drawing.Size(263, 20);
            this.txtProfName.TabIndex = 35;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(177, 261);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(263, 20);
            this.txtDepartment.TabIndex = 36;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 27);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(211, 297);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 27);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 27);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(422, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 27);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(467, 258);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(89, 27);
            this.btnProceed.TabIndex = 42;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(467, 225);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 27);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TeacherInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystemProject_Main_.Properties.Resources.bgforeverypage;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtProfName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lvwTeacherInventory);
            this.Controls.Add(this.lblInventoryHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherInventory";
            this.Load += new System.EventHandler(this.TeacherInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventoryHeader;
        private System.Windows.Forms.ListView lvwTeacherInventory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProfName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnBack;
    }
}