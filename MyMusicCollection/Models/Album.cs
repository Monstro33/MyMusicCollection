using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicCollection.Models
{
    public class Album
    {
        public string AlbumName { get; set; }
        public int Id { get; set; }
        public string AlbumImageLocation { get; set; }
        public string AlbumInfo { get; set; }
        public virtual IEnumerable<Song> Songs { get; set; }
        public string AlbumReviewContent { get; set; }

        public Album()
        {

        }
    }
}
