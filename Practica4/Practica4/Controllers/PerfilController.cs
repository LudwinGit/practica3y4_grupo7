﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica4.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult vPerfil()
        {
            return View();
        }

        public ActionResult IrA(string v)
        {
            return RedirectToAction(v, "Perfil");
        }

    }
}