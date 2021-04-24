using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_NHOM8.Models;

namespace MVC_NHOM8.Controllers
{
    public class QuyenDangNhapsController : Controller
    {
        private ProductDBContext db = new ProductDBContext();

        // GET: QuyenDangNhaps
        public ActionResult Index()
        {
            return View(db.QuyenDangNhaps.ToList());
        }

        // GET: QuyenDangNhaps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuyenDangNhap quyenDangNhap = db.QuyenDangNhaps.Find(id);
            if (quyenDangNhap == null)
            {
                return HttpNotFound();
            }
            return View(quyenDangNhap);
        }

        // GET: QuyenDangNhaps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuyenDangNhaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuyenDNID,TenQuyenDN")] QuyenDangNhap quyenDangNhap)
        {
            if (ModelState.IsValid)
            {
                db.QuyenDangNhaps.Add(quyenDangNhap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quyenDangNhap);
        }

        // GET: QuyenDangNhaps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuyenDangNhap quyenDangNhap = db.QuyenDangNhaps.Find(id);
            if (quyenDangNhap == null)
            {
                return HttpNotFound();
            }
            return View(quyenDangNhap);
        }

        // POST: QuyenDangNhaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuyenDNID,TenQuyenDN")] QuyenDangNhap quyenDangNhap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quyenDangNhap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quyenDangNhap);
        }

        // GET: QuyenDangNhaps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuyenDangNhap quyenDangNhap = db.QuyenDangNhaps.Find(id);
            if (quyenDangNhap == null)
            {
                return HttpNotFound();
            }
            return View(quyenDangNhap);
        }

        // POST: QuyenDangNhaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuyenDangNhap quyenDangNhap = db.QuyenDangNhaps.Find(id);
            db.QuyenDangNhaps.Remove(quyenDangNhap);
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
