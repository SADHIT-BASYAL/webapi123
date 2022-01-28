using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi123.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string gender { get; set; }
        public int? age { get; set; }
        public int? studentclass { get; set; }
        public int? TeacherId { get; set; }

    }
}