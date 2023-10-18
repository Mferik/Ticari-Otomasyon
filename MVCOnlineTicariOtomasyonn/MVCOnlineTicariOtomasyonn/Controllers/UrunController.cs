using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Sınıflar;

namespace MVCOnlineTicariOtomasyonn.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index()
            
        {
            var urunler = c.Ürüns.ToList();
            return View(urunler);
        }
    }
}