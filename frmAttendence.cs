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
    public partial class frmAttendence : Form
    {
        public static int id;

        public frmAttendence()
        {
            InitializeComponent();
            ClassAttendence();
            btnUpdate.Enabled = false;
            //dgv(DateTime.Now.ToString("MM-dd-yyyy"), Convert.ToInt32(ddlSearchByClass.SelectedValue));
            dgv(DateTime.Now.ToString("MM-dd-yyyy"), Convert.ToInt32(ddlSearchByClass.SelectedValue));
        }

        public void ClassAttendence()
        {
            ddlSearchByClass.DataSource = Class_fun.GetAllData();
            ddlSearchByClass.ValueMember = "ClassId";
            ddlSearchByClass.DisplayMember = "ClassName";
            ddlSearchByClass.SelectedValue = -1;
        }

        private void btnInsertDailyAttendence_Click(object sender, EventArgs e)
        {
            new frmDailyAttendence().ShowDialog();
            dgv(DateTime.Now.ToString("MM-dd-yyyy"), Convert.ToInt32(ddlSearchByClass.SelectedValue));
        }

        public void dgv(string date,int id)
        {
            DGV.DataSource=Attendence_fun.GetAllData(date, id);
            DGV.Columns["AttendenceId"].Visible = false;
            DGV.Columns["ClassId"].Visible = false;
            DGV.Columns["StudentId"].Visible = false;
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["AttendenceId"].Value);
            if(e.ColumnIndex==0)
            {
                BL_Attendence o= Attendence_fun.GetDataById(id);
                txtClassName.Text = o.myclass.ClassName;
                txtStudentName.Text = o.mystudent.StudentName;
                ddlStatus.SelectedIndex = o.Status;
            }  
        }

        private void ddlSearchByClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgv(DateTime.Now.ToString("MM-dd-yyyy"), Convert.ToInt32(ddlSearchByClass.SelectedValue));
        }

        private void dtpSearchByDate_ValueChanged(object sender, EventArgs e)
        {
            dgv(dtpSearchByDate.Value.ToString("MM-dd-yyyy"), Convert.ToInt32(ddlSearchByClass.SelectedValue));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtClassName.Text.Length>0 && txtStudentName.Text.Length>0 && ddlStatus.SelectedIndex>-1)
            {
                if(id>0)
                {
                    btnUpdate.Enabled = true;
                    BL_Attendence o = new BL_Attendence();
                    o.AttendenceId = id;
                    o.Status = ddlStatus.SelectedIndex;
                    Attendence_fun.Update(o);
                    MessageBox.Show(BL.Message.msg);
                    dgv(DateTime.Now.ToString("MM-dd-yyyy"), Convert.ToInt32(ddlSearchByClass.SelectedValue));
                    id = 0;
                }
                else
                {
                    MessageBox.Show("Please select attendence Details First!");
                }
            }else
            {
                btnUpdate.Enabled = false;
            }
            
        }
    }
}
