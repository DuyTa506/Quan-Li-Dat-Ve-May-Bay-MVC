using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_APP.Entities;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Data.Entity;
namespace Final_APP.Controllers
{
    public class AdminController : Controller
    {
        private DVMB conn = new DVMB();
        // GET: Admin
        public ActionResult Index()

        {
            if (Session["Admin"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        //Quan li nguoi dung 

        //Thong tin tai khona khach hang
        public ActionResult UserAccount()
        {
            List<TaiKhoan> ketqua = conn.TaiKhoans.ToList();
            return View(ketqua);
        }

        //----------------------end thong tin tai khoan

        //Xoa tai khoan
        public ActionResult DeleteAccount(string TenDangNhap)
        {
            if (TenDangNhap == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = conn.TaiKhoans.Find(TenDangNhap);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoan);
        }

        // POST: TaiKhoan/Delete/5
        [HttpPost, ActionName("DeleteAccount")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAccountConfirmed(string TenDangNhap)
        {

            TaiKhoan taiKhoan = conn.TaiKhoans.Find(TenDangNhap);
            conn.TaiKhoans.Remove(taiKhoan);
            conn.SaveChanges();
            return RedirectToAction("UserAccount");
        }

        //------------End xoa tai khoan



        //Them nguoi dung
        public ActionResult AddUser()
        {
            return View();
        }


        // POST:NguoiDung/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUser(User_Account user_Account)
        {
            
            var taiKhoan = new TaiKhoan()
            {
                TenDangNhap = user_Account.TenDangNhap,
                MatKhau = user_Account.MatKhau,
                Quyen = user_Account.Quyen =false,
            };

            var nguoiDung = new NguoiDung()
            {
                MaNguoiDung = user_Account.MaNguoiDung,
                HoTen = user_Account.HoTen,
                SDT = user_Account.SDT,
                Email = user_Account.Email,
                TenDangNhap = user_Account.TenDangNhap,
            };
            
            conn.TaiKhoans.Add(taiKhoan);
            conn.NguoiDungs.Add(nguoiDung);
            conn.SaveChanges();
            return RedirectToAction("AddUser");
        }
        //-----------End them nguoi dung




        //Thong tin nguoi dung
        public ActionResult UserDetail()
        {
            List<NguoiDung> ketqua = conn.NguoiDungs.ToList();
            return View(ketqua);
        }

        //Sua thong tin nguoi dung
        // GET: NguoiDungs/Edit
        public ActionResult EditUser(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguoiDung nguoiDung = conn.NguoiDungs.Find(id);
            if (nguoiDung == null)
            {
                return HttpNotFound();
            }
            ViewBag.TenDangNhap = new SelectList(conn.TaiKhoans, "TenDangNhap", "MatKhau", nguoiDung.TenDangNhap);
            return View(nguoiDung);
        }

        // POST: NguoiDungs/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditUser([Bind(Include = "MaNguoiDung,HoTen,SDT,Email,TenDangNhap")] NguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                conn.Entry(nguoiDung).State = EntityState.Modified;
                conn.SaveChanges();
                return RedirectToAction("UserDetail");
            }
            ViewBag.TenDangNhap = new SelectList(conn.TaiKhoans, "TenDangNhap", "MatKhau", nguoiDung.TenDangNhap);
            return View(nguoiDung);
        }

        //---------------End quan li nguoi dung
    }
}