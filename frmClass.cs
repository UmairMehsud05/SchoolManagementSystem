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
    public partial class frmClass : Form
    {
        int id;
        public frmClass()
        {
            InitializeComponent();
            dgv();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BL_Class c = new BL_Class();
            c.ClassId = id;
            c.ClassName = txtClass.Text;
            c.Monthlyfee = txtMonthlyFee.Text;
            c.Admissionfee = txtAdmissionFee.Text;
            c.Status = ddlStatus.SelectedIndex;
            Class_fun.save(c);
            MessageBox.Show(BL.Message.msg);
            dgv();
        }

        public void dgv()
        {
            DGV.DataSource = Class_fun.GetAllData();
            DGV.Columns["ClassId"].Visible = false;
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["ClassId"].Value);
            if (e.ColumnIndex==0)
            {
                BL_Class c = Class_fun.GetDataById(id);
                id = c.ClassId;
                txtClass.Text = c.ClassName;
                txtMonthlyFee.Text = c.Monthlyfee;
                txtAdmissionFee.Text = c.Admissionfee;
                ddlStatus.SelectedIndex = c.Status;
                btnSave.Text = "Update";
            }
            else if(e.ColumnIndex==1)
            {
                Class_fun.Delete(id);
                MessageBox.Show(BL.Message.msg);
                dgv();
            }
        }
    }
}
