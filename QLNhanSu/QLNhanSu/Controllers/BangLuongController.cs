using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLNhanSu.Models;

namespace QLNhanSu.Controllers
{
    public class BangLuongController : Controller
    {
        private QLNhanSuDBContext db = new QLNhanSuDBContext();

        // GET: BagnLuong
        public ActionResult Index()
        {
            return View(db.BangLuongs.ToList());
        }

        // GET: BagnLuong/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BangLuong bangLuong = db.BangLuongs.Find(id);
            if (bangLuong == null)
            {
                return HttpNotFound();
            }
            return View(bangLuong);
        }

        // GET: BagnLuong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BagnLuong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenNV,Luong,Phucap")] BangLuong bangLuong)
        {
            if (ModelState.IsValid)
            {
                db.BangLuongs.Add(bangLuong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bangLuong);
        }

        // GET: BagnLuong/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BangLuong bangLuong = db.BangLuongs.Find(id);
            if (bangLuong == null)
            {
                return HttpNotFound();
            }
            return View(bangLuong);
        }

        // POST: BagnLuong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenNV,Luong,Phucap")] BangLuong bangLuong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bangLuong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bangLuong);
        }

        // GET: BagnLuong/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BangLuong bangLuong = db.BangLuongs.Find(id);
            if (bangLuong == null)
            {
                return HttpNotFound();
            }
            return View(bangLuong);
        }

        // POST: BagnLuong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BangLuong bangLuong = db.BangLuongs.Find(id);
            db.BangLuongs.Remove(bangLuong);
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
