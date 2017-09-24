using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMembership.Controllers
{
    public class ShreeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}