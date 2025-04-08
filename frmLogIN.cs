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
    public partial class frmLogIN : MetroFramework.Forms.MetroForm
    {
        public frmLogIN()
        {
            InitializeComponent();
        }
        public static int AdminID;
        public static string AdminFirstName;
        public static string AdminLastName;



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            BLAdmin o = new BLAdmin();
            o.Email = txtEmail.Text;
            o.Password = txtPassword.Text;
            Admin_fun.LogIn(o);
            if(o.IsNew==false)
            {
                AdminID = o.AdminId;
                AdminFirstName = o.FirstName;
                AdminLastName = o.LastName;
                frmMain fm = new frmMain();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email or Password wrong!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword fp = new frmForgetPassword();
            fp.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(loginpassShowORHide.Checked==true)
            {
                txtPassword.UseSystemPasswordChar = false;
                loginpassShowORHide.Text = "Hide PassWord";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                loginpassShowORHide.Text = "Show PassWord";
            }
            
        }

        private void linkDonnotaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }
    }
}
