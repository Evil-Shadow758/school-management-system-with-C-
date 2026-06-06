using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.models
{
    public class Course : CommonDB
    {
        public string Subject { get; set; }

        public string Time { get; set; }

        public double Price { get; set; }
    }
}
