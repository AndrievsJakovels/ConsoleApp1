using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesApp4.Controllers
{
    public class MainViewController : Controller
    {
        // GET: MainView
        public ActionResult Index()
        {
            return View();


        }
    }
}