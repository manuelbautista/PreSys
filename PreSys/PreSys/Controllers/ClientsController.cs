using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreSys.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Index()
        {
            return View("ClientsList");
        }

        public ActionResult New()
        {
            return View("New");
        }

        public ActionResult Edit(int id)
        {
            return View("Edit");
        }
     }
}