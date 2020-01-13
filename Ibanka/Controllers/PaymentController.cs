using Ibanka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ibanka.Controllers
{
    public class PaymentController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<Payments> payment = new List<Payments>();
            using (var db = new DB())
            {

                payment = db.Payments.ToList();

            }
            return View();
        }

        [HttpGet]
        public ActionResult PaymentCheck(int Id)
        {

            Payments payment = null;
            using (var db = new DB())


            {

                payment = db.Payments.Find(Id);

            }
            return View(payment);
        }
        [HttpPost]
        public ActionResult PaymentCheck(Payments payments)
        {

            return RedirectToAction("PaymentCheckOut", new { id = payments.Id });

        }
        [HttpGet]
        public ActionResult PaymentCheckOut()
        {
            int id = Session.Get().user.Id;


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
        public ActionResult PaymentCheckOut(SessionModel model)
        {
            int jaunsId = Session.Get().Id;
            model.jaunsId = jaunsId;

            Payments payments = new Payments();

            if (ModelState.IsValid)
            {
                using (var db = new DB())
                {
                    Keys key = db.Keys.First(k => k.KeyName == model.KeyName );

                    if (key == null)
                    {
                        ModelState.AddModelError("Key", "Koda kļūda");

                    }

                    if (key != null)
                    {
                        return RedirectToAction("Index", "Home");


                    }
                    else
                    {
                        ModelState.AddModelError("Key", "Kļūda");

                    }

                  
                }

            }



            return View(model);
        }







        [HttpPost]
        public ActionResult Index(Payments payments)
        {
            if (ModelState.IsValid)
            {


                using (var db = new DB())
                {
               
                    payments = db.Payments.Add(new Payments()
                    {
                        NamePayment = payments.NamePayment,
                        // saņēmējs
                        Konta1Id = payments.Konta1Id,

                        // no konta
                        Konta2Id = payments.Konta2Id,


                        AccountMoney = payments.AccountMoney,
                        Resaon = payments.Resaon,


                  
                      



                    });
                  
                    db.SaveChanges();



                }
                return RedirectToAction("PaymentCheck", new { id = payments.Id });



            }

            else
            {
                ModelState.AddModelError("payment", "Kļūda");

            }
         //   Edit(payments.Id);

            return View(payments);
        }

        [HttpPost]
        public  ActionResult  Delete(int Id)
        {
  
            using (var db = new DB())
            {
                db.Payments.Remove(db.Payments.Find(Id));

                db.SaveChanges();

            }
            

         return RedirectToAction("Index");
        }

/*
        [HttpGet]
        public ActionResult Edit(int Id)
        {

            Payments payments = new Payments();
            payments.Id = Id;
      

            using (var db = new DB())
            {
                payments = db.Payments.First(a => a.Id == Id);

            }



            return View(payments);
        }

        [HttpPost]
        public ActionResult Edit(Payments payments)
        {
            Accounts accounts = null;
          

            using (var db = new DB())
            {
                var existing  = db.Payments.Find(accounts.Id);
              //  var existingAccountMoney;
                existing.AccountMoney = payments.AccountMoney -200;
                db.SaveChanges();
            }

            

            return View(payments);
        }

*/


        public ActionResult BankSample()
        {





            return View();
        }

        public ActionResult BankSampleTelephone()
        {





            return View();
        }
        public ActionResult BankSampleElectricity()
        {





            return View();
        }
        public ActionResult BankSampleWater()
        {





            return View();
        }


    }
}
 