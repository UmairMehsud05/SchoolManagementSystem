namespace SchoolMS
{
    partial class frmDailyAttendence
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlDailyClassAttendence = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FLPnlForDailyAttendence = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddlDailyClassAttendence);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 81);
            this.panel1.TabIndex = 0;
            // 
            // ddlDailyClassAttendence
            // 
            this.ddlDailyClassAttendence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDailyClassAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlDailyClassAttendence.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ddlDailyClassAttendence.FormattingEnabled = true;
            this.ddlDailyClassAttendence.Location = new System.Drawing.Point(67, 44);
            this.ddlDailyClassAttendence.Name = "ddlDailyClassAttendence";
            this.ddlDailyClassAttendence.Size = new System.Drawing.Size(148, 25);
            this.ddlDailyClassAttendence.TabIndex = 63;
            this.ddlDailyClassAttendence.SelectionChangeCommitted += new System.EventHandler(this.ddlDailyClassAttendence_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Select Any Class";
            // 
            // FLPnlForDailyAttendence
            // 
            this.FLPnlForDailyAttendence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPnlForDailyAttendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.FLPnlForDailyAttendence.Location = new System.Drawing.Point(0, 81);
            this.FLPnlForDailyAttendence.Name = "FLPnlForDailyAttendence";
            this.FLPnlForDailyAttendence.Size = new System.Drawing.Size(581, 261);
            this.FLPnlForDailyAttendence.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(210, 360);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 40);
            this.btnSubmit.TabIndex = 71;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmDailyAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(581, 421);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.FLPnlForDailyAttendence);
            this.Controls.Add(this.panel1);
            this.Name = "frmDailyAttendence";
            this.Text = "frmDailyAttendence";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ddlDailyClassAttendence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLPnlForDailyAttendence;
        private System.Windows.Forms.Button btnSubmit;
    }
}