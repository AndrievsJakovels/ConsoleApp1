using Internetabanka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internetabanka.Controllers
{
    public class UserController : Controller
    {
   
        public ActionResult Index()
        {
            List<User> users = new List<User>();
            using (var db = new Db())
            {

                users = db.Users.ToList();
            }
            return View(users);
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            User user = null;
            using (var db = new Db())
            {

                user = db.Users.Find(id);
            }

            return View(user);

        }
        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Db())
                {
                    User olduser = db.Users.Find(user.Id);
                    olduser.Name = user.Name;
                    olduser.Password = user.Password;
                    db.SaveChanges();
                }

            }

            return View(user);

        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }




        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Db())
                {
                    User user = db.Users.FirstOrDefault(u => u.Name == model.Name);


                    if (user == null)
                    {
                        ModelState.AddModelError("user", "Nepareizs lietotājs");

                    }
                    else
                    {

                        ModelState.AddModelError("user", "Lietotajs atrasts");
                    }
                }
                    
            }
            return View(model);
        }

        
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Register(User model)
        {

            if (ModelState.IsValid)
            {
                using (var db = new Db())

                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    if (db.Users.Any(u => u.Name == model.Name))
                    {
                        ModelState.AddModelError("exists", "paroles nesakrīt");

                    }
                    else
                    {
                        db.Users.Add(new User()
                        {
                           
                            Name = model.Name,
                            Password = model.Password


                        });

                        db.SaveChanges();
                    }

                }
                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}