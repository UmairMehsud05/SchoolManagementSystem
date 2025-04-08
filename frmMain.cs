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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        Form curForm;
        public frmMain()
        {
            InitializeComponent();
            lblName.Text = "WELCOME  "+ "'" + frmLogIN.AdminFirstName+" "+frmLogIN.AdminLastName +"'";
            loadform(btnHome, new frmHome());
        }


        void loadform(object sender, Form frm)
        {
            if (curForm != null)
            {
                curForm.Close();
            }
            curForm = frm;
            curForm.TopLevel = false;
            curForm.BackColor = Color.White;
            curForm.Dock = DockStyle.Fill;
            curForm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(curForm);
            curForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmHome());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmProfile());
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmClass());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmLogIN().Show();
            this.Hide();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmFee());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmStudent());
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            loadform(sender, new frmAttendence());
        }
    }
}
