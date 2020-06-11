

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIK.DAL;
using SIK.Models;

namespace  SIK.Controllers {
    public class AdminController : Controller{
        private IAdmin _adm;

        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password){
            try{
                var data = _adm.CekLogin(username,password);
                HttpContext.Session.SetString("username",data.username);
                ViewData["pesan"] = $"<p>Selamat Datang {data.username} anda berhasil login</p>";
                return View("Views/Home/Index.cshtml");
            }catch(Exception ex){
                ViewData["pesan"] = $"<span class='alert alert-danger'>{ex.Message}</span>";
                return Content($"{ex.Message}");
            }
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        

        [HttpPost]
        public IActionResult Registrasi(Admin adm){
            try{
                _adm.Insert(adm);
                return Content("Data berhasil ditambah");
            }
            catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }

        public AdminController(IAdmin adm)
        {
            _adm = adm;
        }
        public IActionResult Registrasi(){
            return View();
        }
        public IActionResult Tampil(){
            var data = _adm.GetAllAdmin();
            return View(data);
        }
        public IActionResult Update(){
            return View();
        }
       
    }
    
}