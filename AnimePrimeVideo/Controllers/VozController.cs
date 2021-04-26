using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnimePrimeVideo.Models;

namespace AnimePrimeVideo.Controllers
{
    public class VozController : Controller
    {
        Context DB = new Context();
        // GET: Voz
        public ActionResult Index()
        {
            var VozList = DB.ActorVoz.ToList();
            return View(VozList);
        }

        // GET: Voz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Voz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Voz/Create
        [HttpPost]
        public ActionResult Create(VozModelo voz)
        {
            try
            {
                // TODO: Add insert logic here

               using (var db = new Context())
                {
                    db.ActorVoz.Add(voz);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Voz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Voz/Edit/5
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

        // GET: Voz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Voz/Delete/5
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
