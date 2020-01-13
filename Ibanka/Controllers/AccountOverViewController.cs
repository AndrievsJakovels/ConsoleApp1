using Ibanka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ibanka.Controllers
{
    public class AccountOverViewController : Controller
    {
        // GET: AccountOverView
        public ActionResult Index(SessionModel model)
        {
            int jaunsId = Session.Get().account.UsersId;
            model.jaunsId = jaunsId;

            int citsId = Session.Get().user.Id;
            model.citsId = citsId;

            int kontaId = Session.Get().account.Id;
            model.kontaId = kontaId;

            List<Payments> payments = new List<Payments>();
            using (var db = new DB())
            {

                payments = db.Payments.Where(k => k.Konta1Id == model.kontaId  && model.jaunsId == model.citsId ) .ToList();
             payments = db.Payments.Where(k => k.Konta2Id == model.kontaId && model.jaunsId == model.citsId).ToList();

                // k.Konta2Id == model.kontaId

            }
            return View(payments);
        }
    }
}