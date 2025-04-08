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
    public partial class frmFee : Form
    {
        public static int ID;
        public static string totalfee;
        public frmFee()
        {
            InitializeComponent();
            txtClass();
            dgv();
        }

        public void txtClass()
        {
            ddlClass.DataSource = Class_fun.GetAllData();
            ddlClass.ValueMember = "ClassId";
            ddlClass.DisplayMember = "ClassName";
            ddlClass.SelectedValue = -1;
        }


        private void ddlClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ddlStudent.SelectedValue = -1;
            ID = Convert.ToInt32(ddlClass.SelectedValue);
            ddlStudent.DataSource = Fee_fun.StudentByClassId(ID);
            ddlStudent.ValueMember = "StudentId";
            ddlStudent.DisplayMember = "StudentName";
            ddlStudent.SelectedValue = -1;
            txtFee.Text = string.Empty;
        }

        private void ddlStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(ddlClass.SelectedValue);
            BL_Class s = Class_fun.GetDataById(ID);
            txtFee.Text = s.Monthlyfee;
            totalfee = txtFee.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BL_Fee f = new BL_Fee();
            f.FeeId = ID;
            f.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
            f.StudentId = Convert.ToInt32(ddlStudent.SelectedValue);
            f.Fee = txtFee.Text;
            f.Date = DateTime.Now;
            f.RemainingFee = txtRemainingFee.Text;
            f.FeeMonth = ddlFeeMonth.SelectedIndex;
            f.Status = ddlStatus.SelectedIndex;
            Fee_fun.Save(f);
            MessageBox.Show(BL.Message.msg);
            dgv();
            Tab.SelectedTab = FeeDetailTab;
            btnSave.Text = "Save";
        }

        private void txtFee_ValueChanged(object sender, EventArgs e)
        {
            //BL_Fee f = new BL_Fee();
            //f.ClassId = Convert.ToInt32(ddlClass.SelectedValue);
            //fee_fun.totalfee(f);
            txtRemainingFee.Text = Convert.ToString(Convert.ToInt32(totalfee) - Convert.ToInt32(txtFee.Text));
        }

        public void dgv()
        {
            dataGV.DataSource = Fee_fun.GetAllData();
            dataGV.Columns["FeeId"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells["FeeId"].Value);
            if(e.ColumnIndex==0)
            {
                BL_Fee f = new BL_Fee();
                f.FeeId = ID;
                Fee_fun.GetDataById(f);
                ddlClass.SelectedValue = f.ClassId;
                ddlStudent.SelectedValue = f.StudentId;
                txtFee.Text = f.Fee;
                txtRemainingFee.Text = f.RemainingFee;
                ddlFeeMonth.SelectedIndex = f.FeeMonth;
                ddlStatus.SelectedIndex = f.Status;
                Tab.SelectedTab = FeeTab;
                btnSave.Text = "Update";
            }
            else if(e.ColumnIndex==1)
            {
                Fee_fun.Delete(ID);
                MessageBox.Show(BL.Message.msg);
                dgv();
            }
        }
    }
    }
