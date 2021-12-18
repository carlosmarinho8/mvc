using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAgencia.Controllers
{
    public class AgenciaController : Controller
    {
        // GET: Agencia
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult destinos()
        {
            return View();
        }
        public ActionResult promocoes()
        {
            return View();
        }
        public ActionResult contato()
        {
            return View();
        }
    }
}