using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreSys.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public JsonResult GetUsers(string user, string password)
        {
            var result = "";
            return Json(result, JsonRequestBehavior.AllowGet);

        }
        
    }
}