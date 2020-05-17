using Microsoft.AspNetCore.Mvc;
using SIK.DAL;

namespace SIK.Controllers{
    public class AktivaController : Controller{
        private IAktiva _akt;

        public AktivaController(IAktiva akt)
        {
            _akt = akt;
        }
        public IActionResult Details(){
            var dat = _akt.GetAllAktiva();
            return View(dat);
        }
        public IActionResult Create(){
            return View();
        }
        public IActionResult Update(){
            return View();
        }
    }
    
}