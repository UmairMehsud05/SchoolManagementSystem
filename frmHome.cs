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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            studentdetails();
            feedetails();
            classdetails();
        }

        public void studentdetails()
        {
            DataTable dt= Student_fun.GetAllData();
            lblStudents.Text = Convert.ToString(dt.Rows.Count);
        }

        public void feedetails()
        {
            DataTable dt = Fee_fun.GetAllData();
            lblFeeSubmittedStudents.Text = Convert.ToString(dt.Rows.Count);
        }

        public void classdetails()
        {
            DataTable dt = Class_fun.GetAllData();
            lblAvailableClasses.Text = Convert.ToString(dt.Rows.Count);
        }
        
    }
}
