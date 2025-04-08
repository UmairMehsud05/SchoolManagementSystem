namespace SchoolMS
{
    partial class frmStudent
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
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.AddStudents = new MetroFramework.Controls.MetroTabPage();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.ddlCurrentCLass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ddlPreviousCLass = new System.Windows.Forms.ComboBox();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.StudentDetails = new MetroFramework.Controls.MetroTabPage();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.btnStudentPic = new System.Windows.Forms.Button();
            this.StudentPicBox = new System.Windows.Forms.PictureBox();
            this.Tab.SuspendLayout();
            this.AddStudents.SuspendLayout();
            this.StudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.AddStudents);
            this.Tab.Controls.Add(this.StudentDetails);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1014, 518);
            this.Tab.TabIndex = 0;
            // 
            // AddStudents
            // 
            this.AddStudents.Controls.Add(this.btnStudentPic);
            this.AddStudents.Controls.Add(this.StudentPicBox);
            this.AddStudents.Controls.Add(this.ddlStatus);
            this.AddStudents.Controls.Add(this.ddlCurrentCLass);
            this.AddStudents.Controls.Add(this.label8);
            this.AddStudents.Controls.Add(this.label2);
            this.AddStudents.Controls.Add(this.btnSave);
            this.AddStudents.Controls.Add(this.ddlPreviousCLass);
            this.AddStudents.Controls.Add(this.txtCNIC);
            this.AddStudents.Controls.Add(this.txtContact);
            this.AddStudents.Controls.Add(this.label7);
            this.AddStudents.Controls.Add(this.label5);
            this.AddStudents.Controls.Add(this.txtAddress);
            this.AddStudents.Controls.Add(this.label6);
            this.AddStudents.Controls.Add(this.label3);
            this.AddStudents.Controls.Add(this.txtEmail);
            this.AddStudents.Controls.Add(this.label4);
            this.AddStudents.Controls.Add(this.txtFatherName);
            this.AddStudents.Controls.Add(this.label1);
            this.AddStudents.Controls.Add(this.txtName);
            this.AddStudents.Controls.Add(this.lblName);
            this.AddStudents.HorizontalScrollbarBarColor = true;
            this.AddStudents.Location = new System.Drawing.Point(4, 35);
            this.AddStudents.Name = "AddStudents";
            this.AddStudents.Size = new System.Drawing.Size(1006, 479);
            this.AddStudents.TabIndex = 0;
            this.AddStudents.Text = "Add Student";
            this.AddStudents.VerticalScrollbarBarColor = true;
            // 
            // ddlStatus
            // 
            this.ddlStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "InActive",
            "Active"});
            this.ddlStatus.Location = new System.Drawing.Point(242, 396);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(148, 25);
            this.ddlStatus.TabIndex = 61;
            // 
            // ddlCurrentCLass
            // 
            this.ddlCurrentCLass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlCurrentCLass.FormattingEnabled = true;
            this.ddlCurrentCLass.Location = new System.Drawing.Point(466, 315);
            this.ddlCurrentCLass.Name = "ddlCurrentCLass";
            this.ddlCurrentCLass.Size = new System.Drawing.Size(148, 25);
            this.ddlCurrentCLass.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "CurrentClass";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(466, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ddlPreviousCLass
            // 
            this.ddlPreviousCLass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlPreviousCLass.FormattingEnabled = true;
            this.ddlPreviousCLass.Location = new System.Drawing.Point(242, 315);
            this.ddlPreviousCLass.Name = "ddlPreviousCLass";
            this.ddlPreviousCLass.Size = new System.Drawing.Size(148, 25);
            this.ddlPreviousCLass.TabIndex = 53;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCNIC.Location = new System.Drawing.Point(466, 237);
            this.txtCNIC.Mask = "00000-0000000-0";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(148, 25);
            this.txtCNIC.TabIndex = 52;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(242, 153);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(148, 25);
            this.txtContact.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "PreviousClass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "CNIC";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(242, 237);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 25);
            this.txtAddress.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Contact";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(466, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 25);
            this.txtEmail.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Email";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(466, 72);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(148, 25);
            this.txtFatherName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "FatherName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(242, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 25);
            this.txtName.TabIndex = 41;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(239, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Name";
            // 
            // StudentDetails
            // 
            this.StudentDetails.Controls.Add(this.DGV);
            this.StudentDetails.Controls.Add(this.pnlStudent);
            this.StudentDetails.HorizontalScrollbarBarColor = true;
            this.StudentDetails.Location = new System.Drawing.Point(4, 35);
            this.StudentDetails.Name = "StudentDetails";
            this.StudentDetails.Size = new System.Drawing.Size(778, 421);
            this.StudentDetails.TabIndex = 1;
            this.StudentDetails.Text = "Student Detail";
            this.StudentDetails.VerticalScrollbarBarColor = true;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 76);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(778, 345);
            this.DGV.TabIndex = 4;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // pnlStudent
            // 
            this.pnlStudent.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudent.Location = new System.Drawing.Point(0, 0);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(778, 76);
            this.pnlStudent.TabIndex = 3;
            // 
            // btnStudentPic
            // 
            this.btnStudentPic.BackColor = System.Drawing.Color.CadetBlue;
            this.btnStudentPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentPic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentPic.ForeColor = System.Drawing.Color.White;
            this.btnStudentPic.Location = new System.Drawing.Point(754, 280);
            this.btnStudentPic.Name = "btnStudentPic";
            this.btnStudentPic.Size = new System.Drawing.Size(148, 32);
            this.btnStudentPic.TabIndex = 63;
            this.btnStudentPic.Text = "Change Profile";
            this.btnStudentPic.UseVisualStyleBackColor = false;
            this.btnStudentPic.Click += new System.EventHandler(this.btnStudentPic_Click);
            // 
            // StudentPicBox
            // 
            this.StudentPicBox.Location = new System.Drawing.Point(742, 75);
            this.StudentPicBox.Name = "StudentPicBox";
            this.StudentPicBox.Size = new System.Drawing.Size(172, 187);
            this.StudentPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPicBox.TabIndex = 62;
            this.StudentPicBox.TabStop = false;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1014, 518);
            this.Controls.Add(this.Tab);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Tab.ResumeLayout(false);
            this.AddStudents.ResumeLayout(false);
            this.AddStudents.PerformLayout();
            this.StudentDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage AddStudents;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.ComboBox ddlCurrentCLass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ddlPreviousCLass;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private MetroFramework.Controls.MetroTabPage StudentDetails;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Button btnStudentPic;
        private System.Windows.Forms.PictureBox StudentPicBox;
    }
}