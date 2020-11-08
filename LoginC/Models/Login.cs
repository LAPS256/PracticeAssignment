using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace LoginC.Models
{
    public class Login
    {
        public int rid { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string rname { get; set; }
        [Required]
        [Display(Name = "Email id")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string remailid { get; set; }
        [Display(Name = "Password")]

        [DataType(DataType.Password)]

        [Required(ErrorMessage = "Password required")]
        public string Userpassword { set; get; }
        [Display(Name = "Confirm new password")]
        [Required(ErrorMessage = "Enter Confirm Password")]
        [Compare("Userpassword", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        public string c_pwd { get; set; }
    }
    public class Enterintotable
    {
        public void InsertUser(Login li)
        {
            DataClasses2DataContext db = new DataClasses2DataContext();
            register rs = new register();
            rs.rid = li.rid;
            rs.rname = li.rname;
            rs.remailid = li.remailid;
            rs.Userpassword = li.Userpassword;
            db.registers.InsertOnSubmit(rs);
            db.SubmitChanges();

        }
    }
    public class Searchuser
    {

        public string searchk(Login li)
        {

            DataClasses2DataContext db = new DataClasses2DataContext();
            register rs = new register();
            string passout = "";
            // var pass = from m in db.registers where m.emailid == li.Emailid select m.userpassword;  
            var pass = from m in db.registers where m.remailid == li.remailid select m.Userpassword;
            foreach (string query in pass)
            {
                passout = query;

            }
            return passout;

        }

    }
}