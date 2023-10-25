using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Sınıflar;
namespace MVCOnlineTicariOtomasyonn.Controllers
{
    public class İstatistikController : Controller
    {
        // GET: İstatistik
        Context c = new Context();
        public ActionResult Index()
        {
            var deger1 = c.Carilers.Count().ToString();
            ViewBag.d1=deger1;
            var deger2 = c.Ürüns.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3 = c.Personels.Count().ToString();
            ViewBag.d3 = deger3;
            var deger4 = c.Kategoris.Count().ToString();
            ViewBag.d4 = deger4;
            var deger5 = c.Ürüns.Sum(x=>x.Stok).ToString();
            ViewBag.d5 = deger5;
            var deger6 = (from x in c.Ürüns select x.Marka).Distinct().Count().ToString();
            ViewBag.d6 = deger6;
            var deger7 = c.Ürüns.Count(x=>x.Stok<=20).ToString();
            ViewBag.d7 = deger7;
            var deger8 = (from x in c.Ürüns orderby x.SatisFiyat descending select x.UrunAd).FirstOrDefault();
            ViewBag.d8 = deger8;
            return View();
        }
    }
}