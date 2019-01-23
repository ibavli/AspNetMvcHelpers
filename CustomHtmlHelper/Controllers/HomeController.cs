using CustomHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<MyMessages> messages = new List<MyMessages>();
            messages.Add(new MyMessages() { Level = 1, Text = "ali veli bilmem ne" });
            messages.Add(new MyMessages() { Level = 2, Text = "hasan hüseyin bilmem ne" });
            messages.Add(new MyMessages() { Level = 3, Text = "ecemsu pelinsu bilmem ne" });
            messages.Add(new MyMessages() { Level = 4, Text = "haydar cabbar bilmem ne" });

            return View(messages);
        }
    }
}