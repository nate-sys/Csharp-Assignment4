using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public char gender { get; set; }
        public DateTime dob { get; set; }
        public string phone { get; set; }

        public void save()
        {
            Console.WriteLine("The student has been saved to db");
        }
    }
}
