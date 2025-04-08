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
    public partial class frmDailyAttendence : Form
    {
        public static DataTable dt = new DataTable();
        public static int id;
        public frmDailyAttendence()
        {
            InitializeComponent();
            Class();
        }

        public void Class()
        {
            ddlDailyClassAttendence.DataSource = Class_fun.GetAllData();
            ddlDailyClassAttendence.ValueMember = "ClassId";
            ddlDailyClassAttendence.DisplayMember = "ClassName";
            ddlDailyClassAttendence.SelectedValue = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count>0)
            {
                Control[] ctr = FLPnlForDailyAttendence.Controls.Find("chkstatus", false);
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    BL_Attendence o = new BL_Attendence();
                    o.ClassId = Convert.ToInt32(dt.Rows[0]["CurrentClassId"]);
                    o.StudentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
                    o.Date = DateTime.Now;
                    o.Status = (ctr[i] as CheckBox).Checked == true ? 1 : 0;
                    Attendence_fun.Save(o);
                    MessageBox.Show(BL.Message.msg);
                    FLPnlForDailyAttendence.Controls.Clear();
                    ddlDailyClassAttendence.SelectedValue = -1;
                }
            }
        }

        private void ddlDailyClassAttendence_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id= Convert.ToInt32(ddlDailyClassAttendence.SelectedValue);
            //dt = Class_fun.GetDataById(id);
            string q = "select * from tbl_Student where CurrentClassId='" + id + "'";
            dt = db.Table(q);
            if(dt.Rows.Count>0)
            {
                FLPnlForDailyAttendence.Controls.Clear();
                Label[] lblId = new Label[dt.Rows.Count];
                Label[] lblName = new Label[dt.Rows.Count];
                CheckBox[] chk = new CheckBox[dt.Rows.Count];
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    lblId[i] = new Label();
                    lblId[i].Text = dt.Rows[i]["StudentId"].ToString();


                    lblName[i] = new Label();
                    lblName[i].Text = dt.Rows[i]["StudentName"].ToString();

                    chk[i] = new CheckBox();
                    chk[i].Checked = true;
                    chk[i].Name = "chkstatus";

                    FLPnlForDailyAttendence.Controls.Add(lblId[i]);
                    FLPnlForDailyAttendence.Controls.Add(lblName[i]);
                    FLPnlForDailyAttendence.Controls.Add(chk[i]);
                }
            }
            else
            {
                FLPnlForDailyAttendence.Controls.Clear();
            }
        }
    }
}
