using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;
        public static int songcount = 0; //Creating a static attribute

        public Songs (string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songcount++;
        }

    }
}
