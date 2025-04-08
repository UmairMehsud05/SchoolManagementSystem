using SchoolManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.BL
{
    public class BL_Attendence
    {
        public int AttendenceId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public BL_Class myclass { get; set; }
        public BL_Student mystudent { get; set; }
        
    }

    public class Attendence_fun
    {

        public static void Save(BL_Attendence s)
        {
            string q = "insert into tbl_Attendence values('" + s.ClassId + "','" + s.StudentId + "','" + s.Date + "','" + s.Status + "')";
            db.Query(q);
            Message.msg = "Attendence has been Submited!";
        }

        public static DataTable GetAllData(string date, int id)
        {
            string q = "select AttendenceId,a.ClassId,c.ClassName,a.StudentId,s.StudentName,a.Date, case a.Status when 0 then 'Absent' else 'Present' end as Status from tbl_Attendence a inner join tbl_Class c on a.ClassId = c.ClassId inner join tbl_Student s on a.StudentId = s.StudentId where convert(date,Date,101)='" + date + "' and a.ClassId='" + id + "'";
            DataTable dt = db.Table(q);
            return dt;
        }


        public static BL_Attendence GetDataById(int Id)
        {
            string q = "select a.AttendenceId,a.ClassId,c.ClassName,a.StudentId,s.StudentName,a.Date, case a.Status when 0 then 'Absent' else 'Present' end as Status from tbl_Attendence a join tbl_Class c on a.ClassId = c.ClassId join tbl_Student s on a.StudentId = s.StudentId where AttendenceId = '" + Id + "'";
            DataTable dt = db.Table(q);
                BL_Class b = new BL_Class()
                {
                    ClassName = Convert.ToString(dt.Rows[0]["ClassName"])
                };
                BL_Student s = new BL_Student()
                {
                    StudentName = Convert.ToString(dt.Rows[0]["StudentName"])
                };
                BL_Attendence a = new BL_Attendence()
                {
                    ClassId = Convert.ToInt32(dt.Rows[0]["ClassId"]),
                    StudentId = Convert.ToInt32(dt.Rows[0]["StudentId"]),
                    Date = Convert.ToDateTime(dt.Rows[0]["Date"]),
                    Status = Convert.ToInt32(dt.Rows[0]["Status"]),
                    myclass = b,
                    mystudent = s
                };
                return a;
        }


        public static void Update(BL_Attendence a)
        {
            string q = "update tbl_Attendence set Status='" + a.Status + "' where AttendenceId='"+a.AttendenceId+"'";
            db.Query(q);
            Message.msg = "Data has been Updated Successfully!";
        }

    }
}
