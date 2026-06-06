using ConsoleApp12.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace SchoolSystem.models
{
    public class Teacher : CommonDB
    {
        public string Name { get; set; }

        public int CourseID { get; set; }

        public string Email { get; set; }
    }
}
