﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PreSys.Controllers
{
    public class PrestamosController : Controller
    {
        // GET: Prestamos
        public ActionResult Index()
        {
            return View("PrestamosList");
        }

        public ActionResult New()
        {
            return View("Nuevo");
        }
    }
}