namespace School_Management_System
{
    partial class StudentForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblfather = new System.Windows.Forms.Label();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 26);
            this.txtName.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(20, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(60, 20);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name:";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblcontact.Location = new System.Drawing.Point(20, 105);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(77, 20);
            this.lblcontact.TabIndex = 2;
            this.lblcontact.Text = "Contact:";
            // 
            // lblfather
            // 
            this.lblfather.AutoSize = true;
            this.lblfather.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfather.Location = new System.Drawing.Point(20, 68);
            this.lblfather.Name = "lblfather";
            this.lblfather.Size = new System.Drawing.Size(118, 20);
            this.lblfather.TabIndex = 3;
            this.lblfather.Text = "Father Name:";
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(140, 65);
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(220, 26);
            this.txtFather.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(140, 102);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(220, 26);
            this.txtContact.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(390, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(390, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(20, 260);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 62;
            this.dgvStudents.RowTemplate.Height = 28;
            this.dgvStudents.Size = new System.Drawing.Size(740, 180);
            this.dgvStudents.TabIndex = 8;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(420, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(140, 20);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search by Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(570, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(390, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(20, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(265, 38);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Student Management";
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.lblname);
            this.grpStudent.Controls.Add(this.txtName);
            this.grpStudent.Controls.Add(this.lblfather);
            this.grpStudent.Controls.Add(this.txtFather);
            this.grpStudent.Controls.Add(this.lblcontact);
            this.grpStudent.Controls.Add(this.txtContact);
            this.grpStudent.Controls.Add(this.btnSave);
            this.grpStudent.Controls.Add(this.btnDelete);
            this.grpStudent.Controls.Add(this.btnUpdate);
            this.grpStudent.Location = new System.Drawing.Point(20, 60);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(740, 160);
            this.grpStudent.TabIndex = 13;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Details";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblHeader);
            this.Name = "StudentForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblfather;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpStudent;
    }
}