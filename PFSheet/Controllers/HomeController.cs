using PFSheet.CommonClasses;
using PFSheet.Utility.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace PFSheet.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IPFLogger Log = Container.Instance.Resolve<IPFLogger>();

        public ActionResult Index(string returnUrl)
        {
            Log.Debug("TESTING !!!@@@");
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
    }
}