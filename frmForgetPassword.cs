using SchoolManagementSystem.DL;
using SchoolMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class frmForgetPassword : MetroFramework.Forms.MetroForm
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        public static int ID;
        public static string adminName;

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            BLAdmin ad = new BLAdmin();
            ad.Email = txtEmail.Text;
            ad.Password = txtNewPassword.Text;
            ad.ConformPassword = txtConformPassword.Text;
            Admin_fun.ForgetPassword(ad);
            if(ad.EmailNotFound==true)
            {
                MessageBox.Show("Email doesn't found!");
            }
            else
            {
                if (ad.IsNew == true)
                {
                    MessageBox.Show("Your password is Updated");
                    this.Hide();
                    frmLogIN fm = new frmLogIN();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Your password doesn't matching!");
                }
            }
        }

        private void ChkboxforNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkboxforNewPass.Checked==true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
                ChkboxforNewPass.Text = "Hide Password";
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
                ChkboxforNewPass.Text = "Show Password";
            }
        }

        private void chkboxforCnfmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxforCnfmPass.Checked == true)
            {
                txtConformPassword.UseSystemPasswordChar = false;
                chkboxforCnfmPass.Text = "Hide Password";
            }
            else
            {
                txtConformPassword.UseSystemPasswordChar = true;
                chkboxforCnfmPass.Text = "Show Password";
            }
        }
    }
}
