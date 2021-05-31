using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnimePrimeVideo.Models;
using System.Data.Entity;
using System.Data.SqlClient;

namespace AnimePrimeVideo.Controllers
{
    
    public class AnimeController : Controller
    {
        Context DB = new Context();
        // GET: Anime
        public ActionResult Index()
        {
            ViewBag.VozList = DB.ActorVoz.ToList();
            var AnimeBD = DB.Animes.Include(g => g.Genero).Include(g => g.AnimeVoz);
            return View(AnimeBD);
        }

        // GET: Anime/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Anime/Create
        public ActionResult Create()
        {
            ViewBag.GeneroID = new SelectList(DB.Genero, "ID", "Nom_Genero");
            ViewBag.VozList = new MultiSelectList(DB.ActorVoz, "ID", "ActorDeVoz");
            return View();
        }

        // POST: Anime/Create
        [HttpPost]
        public ActionResult Create(AnimeModelo anime)
        {
            try
            {
                // TODO: Add insert logic here
                DB.Animes.Add(anime);
                foreach (var vozID in anime.AnimeVozID)
                {
                    var obj = new AnimeVocesModelo()
                    {
                        VozID = vozID,
                        AnimeID = anime.ID
                    };
                    DB.AnimeVoces.Add(obj);

                }
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Anime/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Anime/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Anime/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Anime/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
