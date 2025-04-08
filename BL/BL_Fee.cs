using SchoolManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.BL
{
    public class BL_Fee
    {
        public int FeeId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public string Fee { get; set; }
        public DateTime Date { get; set; }
        public string RemainingFee { get; set; }
        public int FeeMonth { get; set; }
        public int Status { get; set; }
        
    }

    public class Fee_fun
    {

        public static DataTable StudentByClassId(int id)
        {
            string q = "select * from tbl_Student where CurrentClassId='" + id + "'";
            DataTable dt = db.Table(q);
            return dt;
        }

        //public static DataTable TotalFee(BL_Fee f)
        //{
        //    string q = "select * from tbl_Class where ClassId='" + f.ClassId + "'";
        //    DataTable dt = db.Table(q);
        //    return dt;
        //}

        public static void Save(BL_Fee f)
        {
            string q = "select * from tbl_Fee where StudentId='" + f.StudentId + "'";
            DataTable dt = db.Table(q);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["FeeId"]) != f.FeeId)
            {
                Message.msg = "You have already added this Data!";
            }
            else if(dt.Rows.Count>0)
            {
                q = "update tbl_Fee set ClassId='" + f.ClassId + "',StudentId='" + f.StudentId + "',Fee='" + f.Fee + "',Date='" + f.Date + "',RemainingFee='" + f.RemainingFee + "',FeeMonth='" + f.FeeMonth + "',Status='" + f.Status + "' where FeeId='" + f.FeeId + "'";
                Message.msg = "Data has been Updated Successfully!";
            }
            else
            {
                q = "insert into tbl_Fee values('" + f.ClassId + "','" + f.StudentId + "','" + f.Fee + "','" + f.Date + "','" + f.RemainingFee + "','" + f.FeeMonth + "','" + f.Status + "')";
                Message.msg = "Data has been inserted Successfully!";
            }
            db.Query(q);
        }

        public static DataTable GetAllData()
        {
            string q = "select * from tbl_Fee";
            DataTable dt = db.Table(q);
            return dt;
        }

        public static BL_Fee GetDataById(BL_Fee f)
        {
            string q = "select * from tbl_Fee where FeeId='" + f.FeeId + "'";
            DataTable dt = db.Table(q);
            f.ClassId = Convert.ToInt32(dt.Rows[0]["ClassId"]);
            f.StudentId = Convert.ToInt32(dt.Rows[0]["StudentId"]);
            f.Fee = Convert.ToString(dt.Rows[0]["Fee"]);
            f.Date = Convert.ToDateTime(dt.Rows[0]["Date"]);
            f.RemainingFee = Convert.ToString(dt.Rows[0]["RemainingFee"]);
            f.FeeMonth = Convert.ToInt32(dt.Rows[0]["FeeMonth"]);
            f.Status = Convert.ToInt32(dt.Rows[0]["Status"]);
            return f;
        }

        public static void Delete(int id)
        {
            string q = "delete tbl_Fee where FeeId='" + id + "'";
            db.Query(q);
            Message.msg = "Your Data has been Delete Successfully!";
        }

    }
}
