using SchoolManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.BL
{
    public class BL_Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string FatherContact { get; set; }
        public string FatherEmail { get; set; }
        public string Address { get; set; }
        public string CNIC { get; set; }
        public string image { get; set; }
        public int PreviousClassId { get; set; }
        public int CurrentClassId { get; set; }
        public int Status { get; set; }
    }

    public class Student_fun
    {
        public static void Save(BL_Student s)
        {
            string q = "select * from tbl_Student where StudentId='" + s.StudentId + "'";
            DataTable dt = db.Table(q);
            if (dt.Rows.Count > 0)
            {
                q = "update tbl_Student set StudentName='" + s.StudentName + "',FatherName='" + s.FatherName + "',FatherContact='" + s.FatherContact + "',FatherEmail='" + s.FatherEmail + "',Address='" + s.Address + "',CNIC='" + s.CNIC + "',image='" + s.image + "',PreviousClassId='" + s.PreviousClassId + "',CurrentClassId='" + s.CurrentClassId + "',Status='" + s.Status + "' where StudentId='" + s.StudentId + "'";
                db.Query(q);
                Message.msg = "Student Detail has been Updated";
            }
            else
            {
                q = "insert into tbl_Student values('" + s.StudentName + "','" + s.FatherName + "','" + s.FatherContact + "','" + s.FatherEmail + "','" + s.Address + "','" + s.CNIC + "','" + s.image + "','" + s.PreviousClassId + "','" + s.CurrentClassId + "','" + s.Status + "')";
                db.Query(q);
                Message.msg = "Student has been Added Successfully!";
            }
        }

        public static DataTable GetAllData()
        {
            string q = "select * from tbl_Student";
            DataTable dt = db.Table(q);
            return dt;
        }

        public static BL_Student GetDataById(BL_Student c)
        {
            string q = "select * from tbl_Student where StudentId='" + c.StudentId + "'";
            DataTable dt = db.Table(q);
            c.StudentName = Convert.ToString(dt.Rows[0]["StudentName"]);
            c.FatherName = Convert.ToString(dt.Rows[0]["FatherName"]);
            c.FatherContact = Convert.ToString(dt.Rows[0]["FatherContact"]);
            c.FatherEmail = Convert.ToString(dt.Rows[0]["FatherEmail"]);
            c.Address = Convert.ToString(dt.Rows[0]["Address"]);
            c.CNIC = Convert.ToString(dt.Rows[0]["CNIC"]);
            c.image = Convert.ToString(dt.Rows[0]["image"]);
            c.PreviousClassId = Convert.ToInt32(dt.Rows[0]["PreviousClassId"]);
            c.CurrentClassId = Convert.ToInt32(dt.Rows[0]["CurrentClassId"]);
            c.Status = Convert.ToInt32(dt.Rows[0]["Status"]);
            return c;
        }

        public static void Delete(int id)
        {
            string q = "delete tbl_Student where StudentId='" + id + "'";
            db.Query(q);
            Message.msg = "Your Data has been Deleted Successfully!";
        }
    }
}
