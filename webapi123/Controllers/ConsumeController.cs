using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using webapi123.Models;

namespace webapi123.Controllers
{
    public class ConsumeController : Controller
    {
        // GET: Consume
        HttpClient Client=new HttpClient();

        
        public ActionResult Index()
        {
            List<Student> lst = new List<Student>();
            Client.BaseAddress = new Uri("https://localhost:44301/api/newapi");
            var response = Client.GetAsync("newapi");
            response.Wait();

            var test=response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Student>>();
               display.Wait();
                lst=display.Result;
            }
            return View(lst);
        }
        
    }
}