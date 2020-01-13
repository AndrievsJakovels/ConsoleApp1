using MoviesApp4.Models;
using MoviesApp4Logic;
using MoviesApp4Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesApp4.Controllers
{

    public class UserController : Controller

    {
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }









        [HttpPost]
        public ActionResult Register(UserModel model)
        {

            if (ModelState.IsValid)
            {
                using (var db = new DB())

                {
                    string error = UserManager.Register(new MoviesApp4Logic.Database.Users()
                        {

                            E_mail = model.E_mail,
                            Name = model.Name,
                            Password = model.Password
                    });

                    if (error == null)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        ModelState.AddModelError("", error);

                    }

                }
              
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {


                Users user = UserManager.Login(model.E_mail, model.Password);




                    if (user == null)
                    {
                        ModelState.AddModelError("user", "Nepareizs epasts/parole");
                    }
                    else
                    {
                    Session.Set(new UserSessionModel()
                    {
                        user = UserModel.FromData(user)
                    });
                        return RedirectToAction("Login", "User");
                    }



                }


            return View(model);

        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Login", "User");
        }


        public ActionResult MyBasket()
        {


            return View(Session.Get().Basket);
        }



    }

     


     }
    
