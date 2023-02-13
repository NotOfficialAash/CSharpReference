using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        //Creating Class for Object Method
        public string omname;
        public string ommajor;
        public double omgpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            omname = aName;
            ommajor = aMajor;
            omgpa = aGpa;
        }

        public bool HasHonors() //A method in class for an object
        {
            if (omgpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
