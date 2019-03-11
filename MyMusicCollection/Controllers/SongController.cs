using Microsoft.AspNetCore.Mvc;
using MyMusicCollection.Models;
using MyMusicCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusicCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository repo;

        public SongController(ISongRepository repo)
        {
            this.repo =repo;
        }

        public ViewResult Index()
        {
            var model = repo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            repo.Create(song);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Song song)
        {
            repo.Delete(song);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Song song)
        {
            repo.Update(song);
            return RedirectToAction("Details/" + song.Id);
        }
    }
}
