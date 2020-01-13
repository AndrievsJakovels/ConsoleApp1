
using Ibanka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ibanka.Controllers
{
    public class UserController : Controller
    {
        


        [HttpGet]
        public ActionResult Index()
        {
            List<Users> users = new List<Users>();
            using (var db = new DB())
            {

                users = db.Users.ToList();
            }
            return View(users);
        }


        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Login2(int id)
        {
            
            if (id == 1)
            {
                Random rnd = new Random();
                int Kartesnr = rnd.Next(1, 6);
                SessionModel model = new SessionModel();
                model.Kartesnr = Kartesnr;


                return View(model);
            }

            if (id == 2)
            {

                Random rnd = new Random();
                int Kartesnr = rnd.Next(6, 11);
                SessionModel model = new SessionModel();
                model.Kartesnr = Kartesnr;

                return View(model);

            }
            else
            {
                return View();
            }

           
            
        }



        [HttpPost]
        public ActionResult Login2(SessionModel model)
        {
            

            if (ModelState.IsValid)
            {
                using (var db = new DB())
                {
                    Users user = db.Users.FirstOrDefault(u => u.Password == model.Password && u.Id == model.Id);
                    Keys key = db.Keys.FirstOrDefault(k =>   k.KeyName == model.KeyName );
                    Accounts account = db.Accounts.FirstOrDefault(k => k.UsersId == model.Id);

                    if (user == null )
                    {
                        ModelState.AddModelError("user", "Nepareiza Parole");
                        
                    }
                     if (key == null)
                    {
                        ModelState.AddModelError("key", "Nepareizs    kods");

                    }

                    if (user != null && key != null && account != null)
                    {
                        
                        
                    Session.Set(new SessionModel()
                    { user = user, account = account }); 

                  
                        return RedirectToAction("Index", "Home"); 
                    }

                    else
                    {
                        ModelState.AddModelError("user", "Kļūda");

                    }
                }
            }
            return View(model);
        }









        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DB())
                {
                    Users user = db.Users.FirstOrDefault(u => u.Id == model.Id);

                    if (user == null)
                    {
                        ModelState.AddModelError("user", "Nepareizs Id");
                    }
                    else
                    {
                        return RedirectToAction("Login2",  new { id = user.Id});
                    }
                }
            }
            return View(model);
        }


        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Login");
        }



    }
}