using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebHelperWebGrid.Models;

namespace WebHelperWebGrid.Controllers
{
    public class HomeController : Controller
    {
        List<Urun> urunler = new List<Urun>()
            {
                new Urun { Id = 1, Ad = "Masaüstü Bilgisayar", Fiyat = 1200, Adet = 20},
                new Urun { Id = 2, Ad = "Laptop", Fiyat = 2000, Adet = 40},
                new Urun { Id = 3, Ad = "Tablet", Fiyat = 800, Adet = 65},
                new Urun { Id = 4, Ad = "Akıllı Telefon", Fiyat = 12, Adet = 44},
                new Urun { Id = 5, Ad = "Ev Telefonu", Fiyat = 12, Adet = 140}
            };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UrunListesi()
        {
            return View(urunler);
        }

        public ActionResult UrunListesiIstenilenSutunlar()
        {
            return View(urunler);
        }

        public ActionResult UrunListesiDefaultSort()
        {
            return View(urunler);
        }

        public ActionResult UrunListesiSayfalamaYapma()
        {
            return View(urunler);
        }
        
    }
}