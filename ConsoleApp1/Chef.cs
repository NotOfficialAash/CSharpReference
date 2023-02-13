using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakeSpecialDish() //Virtual keyword is to indicate that it can be ovverriden
                                              //in sub classes
        {
            Console.WriteLine("The chef makes BBQ ribs");
        }
    }
}
