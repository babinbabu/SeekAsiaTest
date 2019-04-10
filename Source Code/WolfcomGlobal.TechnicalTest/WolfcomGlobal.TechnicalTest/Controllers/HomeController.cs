using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WolfcomGlobal.CoreLib.Core.Repositories;
using WolfcomGlobal.CoreLib.Model;

namespace WolfcomGlobal.TechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        [AcceptVerbs("GET")]
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs("GET")]
        public ActionResult Calculate()
        {
            return View();
        }

  
    }
}