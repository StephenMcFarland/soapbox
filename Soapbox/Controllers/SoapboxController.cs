using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Soapbox.Controllers
{
    public class SoapboxController : Controller
    {
        // GET: Soapbox
        public ActionResult Index()
        {
            return View();
        }
    }
}