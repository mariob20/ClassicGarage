using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClassicGarage.DAL;
using ClassicGarage.Models;

namespace ClassicGarage.Controllers
{
    public class AdvertismentModelsController : Controller
    {
        private GarageContex db = new GarageContex();

        // GET: AdvertismentModels
        public ActionResult Index()
        {
            var advertisment = db.Advertisment.Include(a => a.Car);
            return View(advertisment.ToList());
        }

        // GET: AdvertismentModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvertismentModels advertismentModels = db.Advertisment.Find(id);
            if (advertismentModels == null)
            {
                return HttpNotFound();
            }
            return View(advertismentModels);
        }

        // GET: AdvertismentModels/Create
        public ActionResult Create()
        {
            ViewBag.CarId = new SelectList(db.Car, "ID", "Make");
            return View();
        }

        // POST: AdvertismentModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CarId,Active")] AdvertismentModels advertismentModels)
        {
            if (ModelState.IsValid)
            {
                db.Advertisment.Add(advertismentModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarId = new SelectList(db.Car, "ID", "Make", advertismentModels.CarId);
            return View(advertismentModels);
        }

        // GET: AdvertismentModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvertismentModels advertismentModels = db.Advertisment.Find(id);
            if (advertismentModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarId = new SelectList(db.Car, "ID", "Make", advertismentModels.CarId);
            return View(advertismentModels);
        }

        // POST: AdvertismentModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CarId,Active")] AdvertismentModels advertismentModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertismentModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarId = new SelectList(db.Car, "ID", "Make", advertismentModels.CarId);
            return View(advertismentModels);
        }

        // GET: AdvertismentModels/Delete/5
        public ActionResult Delete(int? id)
        {
           
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvertismentModels advertismentModels = db.Advertisment.Find(id);
            if (advertismentModels == null)
            {
                return HttpNotFound();
            }
            return View(advertismentModels);
        }

        // POST: AdvertismentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdvertismentModels advertismentModels = db.Advertisment.Find(id);
            db.Advertisment.Remove(advertismentModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
