using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicCollection.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string SongImageLocation { get; set; }
        public string SongInfo { get; set; }
        public virtual Album Album { get; set; }
        public int AlbumId { get; set; }
        public string SongReviewContent { get; set; }

        public Song()
        {

        }
    }
}
