using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Movie
    {
        public string movtitle;
        public string movdirector;
        private string movrating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            movtitle = aTitle;
            movdirector = aDirector;
            Rating = aRating;
        }

        //Getters and Setters
        public string Rating
        {
            get 
            { 
                return movrating; 
            }
            set 
            {
                if(value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    movrating = value;
                }
                else
                {
                    movrating = "NR";
                }
            }
        }
    }
}
