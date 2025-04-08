namespace SchoolMS
{
    partial class frmAttendence
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
            this.label1 = new System.Windows.Forms.Label();
            this.ddlSearchByClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSearchByDate = new System.Windows.Forms.DateTimePicker();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnInsertDailyAttendence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search By Class";
            // 
            // ddlSearchByClass
            // 
            this.ddlSearchByClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSearchByClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlSearchByClass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlSearchByClass.FormattingEnabled = true;
            this.ddlSearchByClass.Location = new System.Drawing.Point(288, 93);
            this.ddlSearchByClass.Name = "ddlSearchByClass";
            this.ddlSearchByClass.Size = new System.Drawing.Size(148, 25);
            this.ddlSearchByClass.TabIndex = 61;
            this.ddlSearchByClass.SelectionChangeCommitted += new System.EventHandler(this.ddlSearchByClass_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Search By Date";
            // 
            // dtpSearchByDate
            // 
            this.dtpSearchByDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpSearchByDate.Location = new System.Drawing.Point(454, 93);
            this.dtpSearchByDate.Name = "dtpSearchByDate";
            this.dtpSearchByDate.Size = new System.Drawing.Size(200, 25);
            this.dtpSearchByDate.TabIndex = 63;
            this.dtpSearchByDate.ValueChanged += new System.EventHandler(this.dtpSearchByDate_ValueChanged);
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.ddlStatus.Location = new System.Drawing.Point(96, 292);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(148, 25);
            this.ddlStatus.TabIndex = 69;
            // 
            // txtClassName
            // 
            this.txtClassName.Enabled = false;
            this.txtClassName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.Location = new System.Drawing.Point(96, 158);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(148, 25);
            this.txtClassName.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Status";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(96, 223);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(148, 25);
            this.txtStudentName.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Class Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(96, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 40);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.DGV.Location = new System.Drawing.Point(288, 124);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(724, 343);
            this.DGV.TabIndex = 71;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // btnInsertDailyAttendence
            // 
            this.btnInsertDailyAttendence.BackColor = System.Drawing.Color.Black;
            this.btnInsertDailyAttendence.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertDailyAttendence.ForeColor = System.Drawing.Color.White;
            this.btnInsertDailyAttendence.Location = new System.Drawing.Point(96, 399);
            this.btnInsertDailyAttendence.Name = "btnInsertDailyAttendence";
            this.btnInsertDailyAttendence.Size = new System.Drawing.Size(148, 68);
            this.btnInsertDailyAttendence.TabIndex = 72;
            this.btnInsertDailyAttendence.Text = "Click Here For Daily Attendence";
            this.btnInsertDailyAttendence.UseVisualStyleBackColor = false;
            this.btnInsertDailyAttendence.Click += new System.EventHandler(this.btnInsertDailyAttendence_Click);
            // 
            // frmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1168, 549);
            this.Controls.Add(this.btnInsertDailyAttendence);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSearchByDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlSearchByClass);
            this.Controls.Add(this.label1);
            this.Name = "frmAttendence";
            this.Text = "frmAttendence";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlSearchByClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSearchByDate;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.Button btnInsertDailyAttendence;
    }
}