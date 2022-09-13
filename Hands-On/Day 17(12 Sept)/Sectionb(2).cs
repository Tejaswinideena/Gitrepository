using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept12
{
    [Developer("New Album", SongName = "Yuvan Playlist")]
    public class Song
    {
        [Developer("Name of the song", SongName = "Oru Nalil")]
        public string SongName { get; set; }

        [Developer("Language of the song", Language = "Tamil")]
        public string Language { get; set; }

        [Developer("Lyrics", Lyrics = "abcd efgh ijkl mn....\nfor full Lyrics [click here]")]

        public string Lyrics { get; set; }


        public Song(string name, string lang, string lyrics)
        {
            SongName = name;
            Language = lang;
            Lyrics = lyrics;
        }
    }
}