namespace SchoolMS
{
    partial class frmFee
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
            this.FeeTab = new MetroFramework.Controls.MetroTabPage();
            this.txtRemainingFee = new System.Windows.Forms.NumericUpDown();
            this.txtFee = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ddlFeeMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FeeDetailTab = new MetroFramework.Controls.MetroTabPage();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tab.SuspendLayout();
            this.FeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainingFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee)).BeginInit();
            this.FeeDetailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.FeeTab);
            this.Tab.Controls.Add(this.FeeDetailTab);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 1;
            this.Tab.Size = new System.Drawing.Size(697, 444);
            this.Tab.TabIndex = 0;
            // 
            // FeeTab
            // 
            this.FeeTab.Controls.Add(this.txtRemainingFee);
            this.FeeTab.Controls.Add(this.txtFee);
            this.FeeTab.Controls.Add(this.label2);
            this.FeeTab.Controls.Add(this.label4);
            this.FeeTab.Controls.Add(this.ddlStudent);
            this.FeeTab.Controls.Add(this.label1);
            this.FeeTab.Controls.Add(this.ddlClass);
            this.FeeTab.Controls.Add(this.label3);
            this.FeeTab.Controls.Add(this.ddlStatus);
            this.FeeTab.Controls.Add(this.label8);
            this.FeeTab.Controls.Add(this.btnSave);
            this.FeeTab.Controls.Add(this.ddlFeeMonth);
            this.FeeTab.Controls.Add(this.label7);
            this.FeeTab.HorizontalScrollbarBarColor = true;
            this.FeeTab.Location = new System.Drawing.Point(4, 35);
            this.FeeTab.Name = "FeeTab";
            this.FeeTab.Size = new System.Drawing.Size(689, 405);
            this.FeeTab.TabIndex = 0;
            this.FeeTab.Text = "Fee";
            this.FeeTab.VerticalScrollbarBarColor = true;
            // 
            // txtRemainingFee
            // 
            this.txtRemainingFee.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRemainingFee.Location = new System.Drawing.Point(348, 141);
            this.txtRemainingFee.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtRemainingFee.Name = "txtRemainingFee";
            this.txtRemainingFee.Size = new System.Drawing.Size(148, 25);
            this.txtRemainingFee.TabIndex = 78;
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtFee.Location = new System.Drawing.Point(124, 141);
            this.txtFee.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(148, 25);
            this.txtFee.TabIndex = 77;
            this.txtFee.ValueChanged += new System.EventHandler(this.txtFee_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Remaining Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Fee";
            // 
            // ddlStudent
            // 
            this.ddlStudent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlStudent.FormattingEnabled = true;
            this.ddlStudent.Location = new System.Drawing.Point(348, 70);
            this.ddlStudent.Name = "ddlStudent";
            this.ddlStudent.Size = new System.Drawing.Size(148, 25);
            this.ddlStudent.TabIndex = 72;
            this.ddlStudent.SelectionChangeCommitted += new System.EventHandler(this.ddlStudent_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Student ";
            // 
            // ddlClass
            // 
            this.ddlClass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlClass.FormattingEnabled = true;
            this.ddlClass.Location = new System.Drawing.Point(124, 70);
            this.ddlClass.Name = "ddlClass";
            this.ddlClass.Size = new System.Drawing.Size(148, 25);
            this.ddlClass.TabIndex = 70;
            this.ddlClass.SelectionChangeCommitted += new System.EventHandler(this.ddlClass_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Class";
            // 
            // ddlStatus
            // 
            this.ddlStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "InActive",
            "Active"});
            this.ddlStatus.Location = new System.Drawing.Point(348, 209);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(148, 25);
            this.ddlStatus.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 66;
            this.label8.Text = "Status";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(243, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ddlFeeMonth
            // 
            this.ddlFeeMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlFeeMonth.FormattingEnabled = true;
            this.ddlFeeMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.ddlFeeMonth.Location = new System.Drawing.Point(124, 209);
            this.ddlFeeMonth.Name = "ddlFeeMonth";
            this.ddlFeeMonth.Size = new System.Drawing.Size(148, 25);
            this.ddlFeeMonth.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Fee Month";
            // 
            // FeeDetailTab
            // 
            this.FeeDetailTab.Controls.Add(this.dataGV);
            this.FeeDetailTab.Controls.Add(this.pnlTop);
            this.FeeDetailTab.HorizontalScrollbarBarColor = true;
            this.FeeDetailTab.Location = new System.Drawing.Point(4, 35);
            this.FeeDetailTab.Name = "FeeDetailTab";
            this.FeeDetailTab.Size = new System.Drawing.Size(689, 405);
            this.FeeDetailTab.TabIndex = 1;
            this.FeeDetailTab.Text = "Fee Details";
            this.FeeDetailTab.VerticalScrollbarBarColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(689, 76);
            this.pnlTop.TabIndex = 2;
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV.Location = new System.Drawing.Point(0, 76);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(689, 329);
            this.dataGV.TabIndex = 3;
            this.dataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // frmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(697, 444);
            this.Controls.Add(this.Tab);
            this.Name = "frmFee";
            this.Text = "frmFee";
            this.Tab.ResumeLayout(false);
            this.FeeTab.ResumeLayout(false);
            this.FeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemainingFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFee)).EndInit();
            this.FeeDetailTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage FeeTab;
        private MetroFramework.Controls.MetroTabPage FeeDetailTab;
        private System.Windows.Forms.NumericUpDown txtRemainingFee;
        private System.Windows.Forms.NumericUpDown txtFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ddlFeeMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel pnlTop;
    }
}