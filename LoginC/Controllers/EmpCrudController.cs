using LoginC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginC.Controllers
{
    public class EmpCrudController : ApiController
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public IHttpActionResult Getemprecords()
        {
            
            var emprecords = dc.Administrators.ToList();
            return Ok(emprecords);



        }
        public IHttpActionResult GetempById(int id)
        {

            var displayempdata = (from x in dc.Administrators where x.Empid == id select x).FirstOrDefault();
            return Ok(displayempdata);





        }
        [HttpPost]
        public IHttpActionResult Insertemp(Administrator ne)
        {
            dc.Administrators.InsertOnSubmit(ne);
            dc.SubmitChanges();
            return Ok();

        }
        public IHttpActionResult Put(EmpClass ec)
        {
          var Updatdata = (from x in dc.Administrators where x.Empid == ec.Empid select x).FirstOrDefault();
            if (Updatdata != null)
            {
                Updatdata.Empid = ec.Empid;
                Updatdata.Empname = ec.Empname;
                Updatdata.Email = ec.Email;
                Updatdata.Location = ec.Location;
                dc.SubmitChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var deletedata = (from x in dc.Administrators where x.Empid == id select x).FirstOrDefault();
            dc.Administrators.DeleteOnSubmit(deletedata);
            dc.SubmitChanges();
            return Ok();


        }
    }
}
