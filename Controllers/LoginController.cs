using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_APP.Entities;
using Final_APP.DAO;
namespace Final_APP.Controllers
{
    public class LoginController : Controller
    {
        private DVMB conn = new DVMB();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        // Post: Login
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(TaiKhoan account)
        {
            if (ModelState.IsValid)
            {


                var data = conn.TaiKhoans.Where(s => s.TenDangNhap.Equals(account.TenDangNhap) &&  s.MatKhau.Equals(account.MatKhau)).FirstOrDefault();
                if (data != null)
                {
                    if (data.Quyen == true)
                    {
                        if (data.MatKhau == account.MatKhau)
                        {
                            Session["Admin"] = data.TenDangNhap.ToString();
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                    else if (data.Quyen == false)
                    {
                        if (data.MatKhau == account.MatKhau)
                        {
                            Session["User"] = data.TenDangNhap.ToString();
                           
                            return RedirectToAction("Index", "User");
                        }
                        else
                            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
                    }

                    //add session

                }
                else
                {
                    ModelState.AddModelError("", "Vui lòng nhập tài khoản và mật khẩu");
                    ViewBag.error = "Login failed";
                    
                }
            }
            return View(account);
        }
        //------------------Register -------------------------


        //GET: Register
        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(TaiKhoan _user)
        {
            _user.Quyen = false;
            if (ModelState.IsValid)
            {
                var check = conn.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == _user.TenDangNhap);
                if (check == null)
                {
                    
                    conn.Configuration.ValidateOnSaveEnabled = false;
                    conn.TaiKhoans.Add(_user);
                    conn.SaveChanges();
                    ViewBag.sucess = "Tạo tài khoản thành công";
                    return RedirectToAction("Index" ,"User");
                }
                else
                {
                    ViewBag.error = "Tên đăng nhập đã tồn tại";
                    return View();
                }


            }
            return View();


        }


    }
}