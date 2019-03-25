using Microsoft.AspNetCore.Mvc;
using MyMusicCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicCollection.Controllers
{
    public class AlbumController : Controller
    {
        IAlbumRepository albumRepo;

        public AlbumController(IAlbumRepository albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        public ViewResult Index()
        {
            var model = albumRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = albumRepo.GetById(id);
            return View(model);
        }

        public object Create()
        {
            throw new NotImplementedException();
        }
        //public string Foo(int id)
        //{
        //    return (id.ToString());
        //}
    }
}
