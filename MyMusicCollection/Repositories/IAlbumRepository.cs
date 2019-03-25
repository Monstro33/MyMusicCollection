using MyMusicCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicCollection.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album GetById(int id);

    }
}
