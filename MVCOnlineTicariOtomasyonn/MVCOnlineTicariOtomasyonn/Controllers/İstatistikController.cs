﻿using System;
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
            return View();
        }
    }
}