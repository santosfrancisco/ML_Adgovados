using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ML_Adgovados.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Teste()
        {
            return View();
        }
        public ActionResult Socios()
        {
            return View();
        }
        public ActionResult QuemSomos()
        {
            return View();
        }
        public ActionResult Areas()
        {
            return View();
        }
        public ActionResult AreaDetalhe()
        {
            return View();
        }
        public ActionResult SocioDetalhe()
        {
            return View();
        }
    }
}