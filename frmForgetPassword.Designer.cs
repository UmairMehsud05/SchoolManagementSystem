namespace SchoolMS
{
    partial class frmForgetPassword
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConformPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkboxforNewPass = new System.Windows.Forms.CheckBox();
            this.chkboxforCnfmPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Black;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(116, 292);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(83, 40);
            this.btnLogIn.TabIndex = 25;
            this.btnLogIn.Text = "Conform";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(92, 181);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(148, 25);
            this.txtNewPassword.TabIndex = 24;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "New Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(92, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 25);
            this.txtEmail.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email";
            // 
            // txtConformPassword
            // 
            this.txtConformPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConformPassword.Location = new System.Drawing.Point(92, 247);
            this.txtConformPassword.Name = "txtConformPassword";
            this.txtConformPassword.Size = new System.Drawing.Size(148, 25);
            this.txtConformPassword.TabIndex = 27;
            this.txtConformPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Conform Password";
            // 
            // ChkboxforNewPass
            // 
            this.ChkboxforNewPass.AutoSize = true;
            this.ChkboxforNewPass.Location = new System.Drawing.Point(247, 188);
            this.ChkboxforNewPass.Name = "ChkboxforNewPass";
            this.ChkboxforNewPass.Size = new System.Drawing.Size(102, 17);
            this.ChkboxforNewPass.TabIndex = 28;
            this.ChkboxforNewPass.Text = "Show Password";
            this.ChkboxforNewPass.UseVisualStyleBackColor = true;
            this.ChkboxforNewPass.CheckedChanged += new System.EventHandler(this.ChkboxforNewPass_CheckedChanged);
            // 
            // chkboxforCnfmPass
            // 
            this.chkboxforCnfmPass.AutoSize = true;
            this.chkboxforCnfmPass.Location = new System.Drawing.Point(246, 255);
            this.chkboxforCnfmPass.Name = "chkboxforCnfmPass";
            this.chkboxforCnfmPass.Size = new System.Drawing.Size(102, 17);
            this.chkboxforCnfmPass.TabIndex = 29;
            this.chkboxforCnfmPass.Text = "Show Password";
            this.chkboxforCnfmPass.UseVisualStyleBackColor = true;
            this.chkboxforCnfmPass.CheckedChanged += new System.EventHandler(this.chkboxforCnfmPass_CheckedChanged);
            // 
            // frmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 371);
            this.Controls.Add(this.chkboxforCnfmPass);
            this.Controls.Add(this.ChkboxforNewPass);
            this.Controls.Add(this.txtConformPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "frmForgetPassword";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "frmForgetPassword";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConformPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkboxforNewPass;
        private System.Windows.Forms.CheckBox chkboxforCnfmPass;
    }
}