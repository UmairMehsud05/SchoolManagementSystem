using SchoolManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS.BL
{
    public class BLAdmin
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public bool IsNew { get; set; }
        public string ConformPassword { get; set; }
        public bool EmailNotFound { get; set; }
    }

    public class Admin_fun
    {
        public static void createAccount(BLAdmin ad)
        {
            string q;
            q = "select * from Admin where Email='" + ad.Email + "'";
            DataTable dt = db.Table(q);
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0]["AdminID"])!=0)
            {
                ad.IsNew = false;
            }
            else
            {
                q = "insert into Admin values('" + ad.FirstName + "','" + ad.LastName + "','" + ad.Email + "','" + ad.Contact + "','" + ad.Gender + "','" + ad.Password + "','" + ad.CNIC + "','" + ad.Address + "','" + ad.Image + "')";
                db.Query(q);
                ad.IsNew = true;
            }
        }

        public static void LogIn(BLAdmin ad)
        {
            string q = "select * from Admin where Email='" + ad.Email + "' and Password='" + ad.Password + "'";
            DataTable dt = db.Table(q);
            if(dt.Rows.Count>0)
            {
                ad.AdminId = Convert.ToInt32(dt.Rows[0]["AdminID"]);
                ad.FirstName = dt.Rows[0]["FirstName"].ToString();
                ad.LastName = dt.Rows[0]["LastName"].ToString();
                ad.IsNew = false;
            }
            else
            {
                ad.IsNew = true;
            }
        }

        public static void ForgetPassword(BLAdmin ad)
        {
            string q;
            string email = ad.Email;
            string newpass = ad.Password;
            string conformpass = ad.ConformPassword;
            q = "select * from Admin";
            DataTable d = db.Table(q);
            for(int i=0; i<d.Rows.Count;i++)
            {
                string matchemail = Convert.ToString(d.Rows[i]["Email"]);
                if(email == matchemail)
                {
                    int id = Convert.ToInt32(d.Rows[i]["AdminId"]);
                    if (newpass == conformpass)
                    {
                        ad.AdminId = Convert.ToInt32(d.Rows[i]["AdminId"]);
                        ad.FirstName = d.Rows[i]["FirstName"].ToString();
                        ad.LastName = d.Rows[i]["LastName"].ToString();
                        q = "update Admin set Password='" + newpass + "' where AdminId='" + id + "'";
                        db.Query(q);
                        ad.IsNew = true;
                    }
                    else
                    {
                        ad.IsNew = false;
                    }
                    ad.EmailNotFound = false;
                    break;
                }
                else
                {
                    ad.EmailNotFound = true;
                }
            }
        }

        public static BLAdmin Profile()
        {
            BLAdmin ad = new BLAdmin();
            string q = "select * from Admin where AdminId='" + frmLogIN.AdminID + "'";
            DataTable dt = db.Table(q);
            if(dt.Rows.Count>0)
            {
                ad.AdminId = Convert.ToInt32(dt.Rows[0]["AdminId"]);
                ad.FirstName= Convert.ToString(dt.Rows[0]["FirstName"]);
                ad.LastName= Convert.ToString(dt.Rows[0]["LastName"]);
                ad.Email= Convert.ToString(dt.Rows[0]["Email"]);
                ad.Contact= Convert.ToString(dt.Rows[0]["Contact"]);
                ad.CNIC= Convert.ToString(dt.Rows[0]["CNIC"]);
                ad.Address= Convert.ToString(dt.Rows[0]["Address"]);
                ad.Password= Convert.ToString(dt.Rows[0]["Password"]);
                ad.Gender= Convert.ToInt32(dt.Rows[0]["Gender"]);
                ad.Image = Convert.ToString(dt.Rows[0]["Image"]);
            }
            return ad;
        }

        public static void UpdateProfile(BLAdmin ad)
        {
            string q = "update Admin set FirstName='" + ad.FirstName + "',LastName='" + ad.LastName + "',Email='" + ad.Email + "',Contact='" + ad.Contact + "',Gender='" + ad.Gender + "',Password='" + ad.Password + "',CNIC='" + ad.CNIC + "',Address='" + ad.Address + "',image='" + ad.Image + "' where AdminId='" + frmLogIN.AdminID + "'";
            db.Query(q);
            Message.msg = "Profile Updated!";
        }
    }
}

