using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRevision1.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {

            ViewBag.cn = "DIGITAL BUS PASS";
            ViewData["address"] = "Nagpur";

            return View();
        }
    }
}