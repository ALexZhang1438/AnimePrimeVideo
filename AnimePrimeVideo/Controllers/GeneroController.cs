using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnimePrimeVideo.Models;

namespace AnimePrimeVideo.Controllers
{
    public class GeneroController : Controller
    {
        Context DB = new Context();
        // GET: Genero
        public ActionResult Index()
        {
            var genero = DB.Genero.ToList();
            return View(genero);
        }

        // GET: Genero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Genero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genero/Create
        [HttpPost]
        public ActionResult Create(GeneroModelo genero)
        {
            try
            {  
                using (var db = new Context())
                {
                    db.Genero.Add(genero);
                    db.SaveChanges();
                }
                return RedirectToAction("create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Genero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Genero/Edit/5
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

        // GET: Genero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Genero/Delete/5
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
