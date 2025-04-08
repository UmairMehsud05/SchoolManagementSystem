using SchoolManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.BL
{
    public class BL_Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Monthlyfee { get; set; }
        public string Admissionfee { get; set; }
        public int Status { get; set; }
    }

    public class Class_fun
    {

        public static void save(BL_Class c)
        {
            string q = "select * from tbl_Class where ClassId='" + c.ClassId + "'";
            DataTable dt = db.Table(q);
            if (dt.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dt.Rows[0]["ClassId"]);
                q = "update tbl_Class set ClassName='" + c.ClassName + "',Monthlyfee='" + c.Monthlyfee + "',Admissionfee='" + c.Admissionfee + "',Status='" + c.Status + "' where ClassId='" + id + "'";
                Message.msg = "Data has been Updated Successfully";
            }
            else
            {
                q = "insert into tbl_Class values('" + c.ClassName + "','" + c.Monthlyfee + "','" + c.Admissionfee + "','" + c.Status + "')";
                Message.msg = "Data has been inserted Successfully";
            }
            db.Query(q);
        }

        public static DataTable GetAllData()
        {
            string q = "select * from tbl_Class";
            DataTable dt = db.Table(q);
            return dt;
        }

        public static BL_Class GetDataById(int id)
        {
            string q = "select ClassId,ClassName,Monthlyfee,Admissionfee,Status, case Status when 0 then 'Inactive' else 'Active' end as Status from tbl_Class where ClassId='" + id + "'";
            DataTable dt = db.Table(q);
            BL_Class c = new BL_Class();
            c.ClassId = Convert.ToInt32(dt.Rows[0]["ClassId"]);
            c.ClassName = Convert.ToString(dt.Rows[0]["ClassName"]);
            c.Monthlyfee = Convert.ToString(dt.Rows[0]["Monthlyfee"]);
            c.Admissionfee = Convert.ToString(dt.Rows[0]["Admissionfee"]);
            c.Status = Convert.ToInt32(dt.Rows[0]["Status"]);
            return c;
        }

        public static void Delete(int id)
        {
            string q = "delete tbl_Class where ClassId='" + id + "'";
            db.Query(q);
            Message.msg = "Your Selected Data is Deleted Successfully!";
        }

    }
}
