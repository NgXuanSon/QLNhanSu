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
    public class KyLuatController : Controller
    {
        private QLNhanSuDBContext db = new QLNhanSuDBContext();

        // GET: KyLuat
        public ActionResult Index()
        {
            return View(db.KyLuats.ToList());
        }

        // GET: KyLuat/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KyLuat kyLuat = db.KyLuats.Find(id);
            if (kyLuat == null)
            {
                return HttpNotFound();
            }
            return View(kyLuat);
        }

        // GET: KyLuat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KyLuat/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenNV,LoaiKyLuat,MucDoKyLuat,LyDo,LoaiHinhPhat")] KyLuat kyLuat)
        {
            if (ModelState.IsValid)
            {
                db.KyLuats.Add(kyLuat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kyLuat);
        }

        // GET: KyLuat/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KyLuat kyLuat = db.KyLuats.Find(id);
            if (kyLuat == null)
            {
                return HttpNotFound();
            }
            return View(kyLuat);
        }

        // POST: KyLuat/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenNV,LoaiKyLuat,MucDoKyLuat,LyDo,LoaiHinhPhat")] KyLuat kyLuat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kyLuat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kyLuat);
        }

        // GET: KyLuat/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KyLuat kyLuat = db.KyLuats.Find(id);
            if (kyLuat == null)
            {
                return HttpNotFound();
            }
            return View(kyLuat);
        }

        // POST: KyLuat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KyLuat kyLuat = db.KyLuats.Find(id);
            db.KyLuats.Remove(kyLuat);
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
