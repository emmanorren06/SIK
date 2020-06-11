using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIK.DAL;

namespace SIK.Controllers{
    public class AktivaController : Controller{
        private IAktiva _akt;

        public AktivaController(IAktiva akt)
        {
            _akt = akt;
        }
        private bool IsLogin()
        {
            if (HttpContext.Session.GetString("username")== null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Cekusername(string username)
        {
             if (HttpContext.Session.GetString("username") != null &&
            HttpContext.Session.GetString("username") == username)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IActionResult Details()
        {
            if (!IsLogin())
            {
                TempData["pesan"] = "<span class='alert alert-danger'>Silahkan Login terlebih dahulu untuk mengakses halaman ini.</span>";
                return RedirectToAction("Login","Admin");
            }
           var dat = _akt.GetAllAktiva();
           return View(dat);
        }
        public IActionResult Create(){
             if (!IsLogin())
            {

                TempData["pesan"] = "<span class='alert alert-danger'>Silahkan Login terlebih dahulu untuk mengakses halaman mahasiswa.</span>";
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                if (!Cekusername("admin"))
                {
                    TempData["pesan"] = "<span class='alert alert-danger'>Silahkan login sebagai admin untuk create mahasiswa</span>";
                    return RedirectToAction("Login", "Admin");
                }

            }

            return View();
        }
        public IActionResult Update(){
            try{
            var dat = _akt.GetAllAktiva();
            return View(dat);
            }
            catch (Exception ex)
            {
                return Content($"Error : {ex.Message}");
            }
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
    
}