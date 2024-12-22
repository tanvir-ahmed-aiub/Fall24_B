using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroCodeFirst.EF.Tables
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public float Cgpa { get; set; }
    }
}