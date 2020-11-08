using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginC.Models
{
    public class EmpClass
    {
        public int Empid { get; set; }

        public string Empname { get; set; }

        public string Email { get; set; }

        public string Location { get; set; }
    }
}