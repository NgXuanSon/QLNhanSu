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
    public class KhenThuongController : Controller
    {
        private QLNhanSuDBContext db = new QLNhanSuDBContext();

        // GET: KhenThuong
        public ActionResult Index()
        {
            return View(db.KhenThuongs.ToList());
        }

        // GET: KhenThuong/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhenThuong khenThuong = db.KhenThuongs.Find(id);
            if (khenThuong == null)
            {
                return HttpNotFound();
            }
            return View(khenThuong);
        }

        // GET: KhenThuong/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhenThuong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TenNV,DanhHieuKhenthuong,MaSoKhenThuong,TienThuong")] KhenThuong khenThuong)
        {
            if (ModelState.IsValid)
            {
                db.KhenThuongs.Add(khenThuong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khenThuong);
        }

        // GET: KhenThuong/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhenThuong khenThuong = db.KhenThuongs.Find(id);
            if (khenThuong == null)
            {
                return HttpNotFound();
            }
            return View(khenThuong);
        }

        // POST: KhenThuong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TenNV,DanhHieuKhenthuong,MaSoKhenThuong,TienThuong")] KhenThuong khenThuong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khenThuong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khenThuong);
        }

        // GET: KhenThuong/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhenThuong khenThuong = db.KhenThuongs.Find(id);
            if (khenThuong == null)
            {
                return HttpNotFound();
            }
            return View(khenThuong);
        }

        // POST: KhenThuong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KhenThuong khenThuong = db.KhenThuongs.Find(id);
            db.KhenThuongs.Remove(khenThuong);
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
