using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_NHOM8.Models;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVC_NHOM8.Controllers
{
    public class HomeController : Controller
    {
        private ProductDBContext _db = new ProductDBContext();

        public ActionResult Index()
        {
            if (Session["idUser"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        //GET: Register

        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(USER _user)
        {
            if (ModelState.IsValid)
            {
                var check = _db.USERs.FirstOrDefault(s => s.EmailDK == _user.EmailDK);
                if (check == null)
                {
                    _user.MatKhau = GetMD5(_user.MatKhau);
                    var a = _db.QuyenDangNhaps.FirstOrDefault(s => s.TenQuyenDN.Equals("ROLE_USER"));
                    _user.QuyenDangNhaps = a;
                    _user.QuyenDNID = a.QuyenDNID;
                    _user.NgaySinh = DateTime.Parse("2000-04-02");
                    _db.Configuration.ValidateOnSaveEnabled = false;
                    _db.USERs.Add(_user);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }


            }
            return View();


        }

        public ActionResult Login()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string EmailDK, string MatKhau)
        {
            if (ModelState.IsValid)
            {


                var f_password = GetMD5(MatKhau);
                var data = _db.USERs.Where(s => s.EmailDK.Equals(EmailDK) && s.MatKhau.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["FullName"] = data.FirstOrDefault().TenDayDu;
                    Session["Email"] = data.FirstOrDefault().EmailDK;
                    Session["idUser"] = data.FirstOrDefault().UserID;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }


        //Logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }



        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }


    }
}