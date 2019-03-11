using MyMusicCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicCollection.Repositories
{
    public interface ISongRepository
    {
        IEnumerable<Song> GetAll();
        Song GetById(int id);
        void Create(Song song);
        void Delete(Song song);
        void Update(Song song);
    }
}
