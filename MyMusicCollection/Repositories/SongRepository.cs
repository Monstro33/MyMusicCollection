using MyMusicCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicCollection.Repositories
{
    public class SongRepository : ISongRepository
    {
        MusicContext db;

        public SongRepository(MusicContext db)
        {
            this.db = db;
        }

        public IEnumerable<Song> GetAll()
        {
            return db.Songs.ToList();
        }

        public object GetById(int id)
        {
            return db.Songs.Single(song => song.Id == id);
        }

        public void Create(Song song)
        {
            db.Songs.Add(song);
            db.SaveChanges();
        }
        public void Delete(Song song)
        {
            db.Songs.Remove(song);
            db.SaveChanges();
        }
        public void Update(Song song)
        {
            db.Songs.Update(song);
            db.SaveChanges();
        }

        Song ISongRepository.GetById(int id)
        {
            return db.Songs.Single(song => song.Id == id);
        }
    }
}
