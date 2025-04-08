using SchoolMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public bool IsNew;


        void clear()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtGender.SelectedIndex = -1;
            txtPassword.Text = string.Empty;
            txtCNIC.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        public string SaveImage(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            BLAdmin o = new BLAdmin();
            o.FirstName = txtFirstName.Text;
            o.LastName = txtLastName.Text;
            o.Email = txtEmail.Text;
            o.Contact = txtContact.Text;
            o.Gender = txtGender.SelectedIndex;
            o.Password = txtPassword.Text;
            o.CNIC = txtCNIC.Text;
            o.Address = txtAddress.Text;
            o.Image = SaveImage(PicBoxSignUp.Image);
            Admin_fun.createAccount(o);
            if (o.IsNew==true)
            {
                MessageBox.Show("Successfully Created Your Account");
                clear();
            }
            else
            {
                MessageBox.Show("Already have an account on this Email.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogIN fr = new frmLogIN();
            fr.Show();
            this.Hide();
        }

        private void PassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PassCheckbox.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                PassCheckbox.Text = "Hide Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                PassCheckbox.Text = "Show Password";
            }
        }

        private void btnSignUpPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PicBoxSignUp.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
