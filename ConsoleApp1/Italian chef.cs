using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Italian_chef : Chef //Inherting all the functions from chef class
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        public override void MakeSpecialDish() //Accessing a method from chef class and overriding it
        {
            Console.WriteLine("The chef makes Chicken parm");
        }
    }
}
