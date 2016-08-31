using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return RedirectToAction("Login", "Account", new { Area = "Doctor" });
        }

    }
}
