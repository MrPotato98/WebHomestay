using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quanlyphongtro.Controllers
{
    public class MotelController : Controller
    {
        // GET: Motel
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Test()
        {
            return PartialView();
        }
    }
}