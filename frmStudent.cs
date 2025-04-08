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
    public partial class frmStudent : Form
    {
        public int id;

        public frmStudent()
        {
            InitializeComponent();
            dgv();
            PreviousClass();
            CurrentClass();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BL_Student s = new BL_Student();
            s.StudentId = id;
            s.StudentName = txtName.Text;
            s.FatherName = txtFatherName.Text;
            s.FatherContact = txtContact.Text;
            s.FatherEmail = txtEmail.Text;
            s.Address = txtAddress.Text;
            s.CNIC = txtCNIC.Text;
            s.PreviousClassId = Convert.ToInt32(ddlPreviousCLass.SelectedValue);
            s.CurrentClassId = Convert.ToInt32(ddlCurrentCLass.SelectedValue);
            s.Status = ddlStatus.SelectedIndex;
            s.image = SaveImage(StudentPicBox.Image);
            Student_fun.Save(s);
            MessageBox.Show(BL.Message.msg);
            dgv();
            Tab.SelectedTab = StudentDetails;
        }


        public void LoadImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            StudentPicBox.Image = Image.FromStream(ms, true);
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


        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["StudentId"].Value);
            if(e.ColumnIndex==0)
            {
                BL_Student s = new BL_Student();
                s.StudentId = id;
                Student_fun.GetDataById(s);
                txtName.Text = s.StudentName;
                txtFatherName.Text = s.FatherName;
                txtContact.Text = s.FatherContact;
                txtEmail.Text = s.FatherEmail;
                txtAddress.Text = s.Address;
                txtCNIC.Text = s.CNIC;
                ddlPreviousCLass.SelectedValue = s.PreviousClassId;
                ddlCurrentCLass.SelectedValue = s.CurrentClassId;
                ddlStatus.SelectedIndex = s.Status;
                LoadImage(s.image);
                btnSave.Text = "Update";
                Tab.SelectedTab = AddStudents;
            }
            else if(e.ColumnIndex==1)
            {
                Student_fun.Delete(id);
                MessageBox.Show(BL.Message.msg);
                dgv();
            }
        }


        public void dgv()
        {
            DGV.DataSource=Student_fun.GetAllData();
            DGV.Columns["StudentId"].Visible = false;
        }

        public void PreviousClass()
        {
            ddlPreviousCLass.DataSource = Class_fun.GetAllData();
            ddlPreviousCLass.ValueMember = "ClassId";
            ddlPreviousCLass.DisplayMember = "ClassName";
            ddlPreviousCLass.SelectedValue = -1;
        }
        public void CurrentClass()
        {
            ddlCurrentCLass.DataSource = Class_fun.GetAllData();
            ddlCurrentCLass.ValueMember = "ClassId";
            ddlCurrentCLass.DisplayMember = "ClassName";
            ddlCurrentCLass.SelectedValue = -1;
        }

        private void btnStudentPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StudentPicBox.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
