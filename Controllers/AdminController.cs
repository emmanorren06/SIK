

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SIK.DAL;
using SIK.Models;

namespace  SIK.Controllers {
    public class AdminController : Controller{
        private IAdmin _adm;

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
        public IActionResult Tampil(){
            var data = _adm.GetAllAdmin();
            return View(data);
        }
        public IActionResult Update(){
            return View();
        }
       
    }
    
}