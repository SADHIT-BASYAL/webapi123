using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi123.Models;

namespace webapi123.Controllers
{
    public class NewApiController : ApiController
    {
        ApplicationDbContext db=new ApplicationDbContext();
        [HttpGet]
        public IHttpActionResult Index()
        {
            List<Student>obj=db.Students.ToList();  
            return Ok(obj);
        }

        public IHttpActionResult Index(int Id)
        {
            var obj=db.Students.Where(modal=>modal.Id==Id).FirstOrDefault();
            return Ok(obj);
        }


    }
}
