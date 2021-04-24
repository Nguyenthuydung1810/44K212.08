using MVC_NHOM8.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHOM8;

namespace MVC_NHOM8.Controllers
{
    public class SANPHAMController : Controller
    {
        // GET: SANPHAM
        public ActionResult Index()
        {
            var db = sanpham_bus.DanhSach();
            return View(db);
        }

        // GET: SANPHAM/Details/5
        public ActionResult Details(string id)
        {
            var db = sanpham_bus.ChiTiet(id);
            return View(db);
        }

        // GET: SANPHAM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SANPHAM/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SANPHAM/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SANPHAM/Edit/5
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

        // GET: SANPHAM/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SANPHAM/Delete/5
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
