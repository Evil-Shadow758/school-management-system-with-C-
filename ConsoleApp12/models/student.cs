using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12.models
{
    public class Student : CommonDB
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }
    }
}
