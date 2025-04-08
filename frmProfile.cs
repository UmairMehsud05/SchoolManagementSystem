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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
            Profile();
        }

        public void Profile()
        {
            BLAdmin ad = Admin_fun.Profile();
            txtFirstName.Text = ad.FirstName;
            txtLastName.Text = ad.LastName;
            txtEmail.Text = ad.Email;
            txtContact.Text = ad.Contact;
            txtCNIC.Text = ad.CNIC;
            txtPassword.Text = ad.Password;
            txtGender.SelectedIndex = ad.Gender;
            txtAddress.Text = ad.Address;
            LoadImage(ad.Image);
        }

        public void LoadImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            ProfilePicBox.Image = Image.FromStream(ms, true);
            //true means we want to load colorfull images.
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


    private void PassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(PassCheckbox.Checked==true)
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

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            BLAdmin ad = new BLAdmin();
            ad.FirstName=txtFirstName.Text;
            ad.LastName=txtLastName.Text;
            ad.Email=txtEmail.Text;
            ad.Contact=txtContact.Text;
            ad.CNIC=txtCNIC.Text;
            ad.Password=txtPassword.Text;
            ad.Gender=txtGender.SelectedIndex;
            ad.Address=txtAddress.Text;
            ad.Image = SaveImage(ProfilePicBox.Image);
            Admin_fun.UpdateProfile(ad);
            MessageBox.Show(BL.Message.msg);
        }

        private void btnProfilePic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ProfilePicBox.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
