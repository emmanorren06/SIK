


using System;
using Microsoft.AspNetCore.Mvc;
using SIK.DAL;
using SIK.Models;

namespace SIK.Controllers
{
    public class KategoriController : Controller{
        private IKategori _ktg;

        public KategoriController(IKategori ktg)
        {
            _ktg = ktg;
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Post(Kategori ktg){
            try{
                _ktg.Insert(ktg);
                return Content("Data Berhasil Ditambah !");
            }
            catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }
        public IActionResult Tampil()
        {
            var data = _ktg.GetAllKategori();
            return View(data);
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}