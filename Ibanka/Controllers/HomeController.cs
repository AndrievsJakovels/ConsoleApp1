using Ibanka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ibanka.Controllers
{
    public class HomeController : Controller
    {
        
     [HttpGet]
        public ActionResult Index()
        {
            List<Accounts> account = new List<Accounts>();
            using (var db = new DB())
            {
                int id = Session.Get().user.Id;
                account = db.Accounts.Where(a => a.UsersId == id).ToList();

            }
            return View(account);
        }








    }
}