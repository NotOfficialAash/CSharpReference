using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book //A class is like a custom created Data type
    {
        //Giving variables to the new data type
        public string title;
        public string author;
        public int pages;

        //Constructor in Classes
        public Book(string aTitle, string aAuthor, int aPages)
        {
            // A simple constructor created so that an object can be created within a single line
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }

}
