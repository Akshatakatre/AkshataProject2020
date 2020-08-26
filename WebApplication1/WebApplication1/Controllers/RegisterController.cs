using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegistrationClass rm, FormCollection fc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BasicPassword = fc["BasicPassword"];

                ViewBag.StrongPassword = rm.ConfirmPassword;
                return View(rm);
            }
            else
            {
                return View();
            }

        }
    }
}