using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers.Controllers
{
    public class MesajIslemleriController : Controller
    {
        public ActionResult MesajGonder()
        {
            return View();
        }

        public ActionResult MesajDetay(int Id)
        {
            TempData["Id"] = $"{Id}'li Mesaj";
            return View();
        }
    }
}