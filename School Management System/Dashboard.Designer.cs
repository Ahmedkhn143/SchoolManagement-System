namespace School_Management_System
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sidePanel.Controls.Add(this.btnStudents);
            this.sidePanel.Controls.Add(this.btnTeachers);
            this.sidePanel.Controls.Add(this.btnAttendance);
            this.sidePanel.Controls.Add(this.btnFees);
            this.sidePanel.Controls.Add(this.btnPasswordTool);
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(224, 600);
            this.sidePanel.TabIndex = 0;
            // 
            // btnStudents
            // 
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(0, 0);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(224, 70);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "  Manage Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.Location = new System.Drawing.Point(0, 60);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(230, 60);
            this.btnTeachers.TabIndex = 1;
            this.btnTeachers.Text = "  Manage Teachers";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(0, 120);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(230, 60);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = "  Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnFees
            // 
            this.btnFees = new System.Windows.Forms.Button();
            this.btnFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFees.FlatAppearance.BorderSize = 0;
            this.btnFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFees.ForeColor = System.Drawing.Color.White;
            this.btnFees.Location = new System.Drawing.Point(0, 180);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(230, 60);
            this.btnFees.TabIndex = 3;
            this.btnFees.Text = "  Fees";
            this.btnFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFees.UseVisualStyleBackColor = true;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // btnPasswordTool
            // 
            this.btnPasswordTool = new System.Windows.Forms.Button();
            this.btnPasswordTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPasswordTool.FlatAppearance.BorderSize = 0;
            this.btnPasswordTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordTool.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPasswordTool.ForeColor = System.Drawing.Color.White;
            this.btnPasswordTool.Location = new System.Drawing.Point(0, 240);
            this.btnPasswordTool.Name = "btnPasswordTool";
            this.btnPasswordTool.Size = new System.Drawing.Size(230, 60);
            this.btnPasswordTool.TabIndex = 4;
            this.btnPasswordTool.Text = "  Password Tool";
            this.btnPasswordTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswordTool.UseVisualStyleBackColor = true;
            this.btnPasswordTool.Click += new System.EventHandler(this.btnPasswordTool_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Location = new System.Drawing.Point(0, 540);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(224, 60);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.lblUserInfo);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(224, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(776, 70);
            this.headerPanel.TabIndex = 1;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUserInfo.Location = new System.Drawing.Point(661, 35);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(64, 25);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "User...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SCHOOL MANAGEMENT SYSTEM";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(224, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 530);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - School Management System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblUserInfo;
    }
}
