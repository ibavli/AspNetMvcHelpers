using StronglyTypedHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedHelper.Controllers
{
    public class PersonelController : Controller
    {
        public ActionResult Yeni()
        {
            return View(new Personel());
        }

        [HttpPost]
        public ActionResult Yeni(Personel model)
        {
            bool modeldekiVerilerDogruMu = ModelState.IsValid;
            return View(new Personel());
        }
    }
}