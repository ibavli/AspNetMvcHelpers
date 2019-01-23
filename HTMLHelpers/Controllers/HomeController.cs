using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActionLink()
        {
            return View();
        }

        public ActionResult BeginForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Gonderdim()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ParametreliGonderdim(int Id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Derslerim()
        {
            return View();
        }

        public ActionResult TextBox()
        {
            return View();
        }

        public ActionResult TextArea()
        {
            return View();
        }

        public ActionResult Checkbox()
        {
            return View();
        }

        public ActionResult RadioButton()
        {
            return View();
        }

        public ActionResult DropDownList()
        {
            return View();
        }

        public ActionResult ListBox()
        {
            return View();
        }

        public ActionResult PassWord()
        {
            return View();
        }

        public ActionResult Hidden()
        {
            return View();
        }

        public ActionResult Label()
        {
            return View();
        }
    }
}