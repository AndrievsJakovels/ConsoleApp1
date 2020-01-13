using MoviesApp4Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp4Logic
{
    public class UserManager
    {
        public static string Register(Users user)
        {
            using (var db = new DB())
            {
                if (db.Users.Any(e => e.E_mail == user.E_mail))
                {
                    return "šāds epasts ir jau reģistrēts";

                }

                db.Users.Add(user);
                db.SaveChanges();

                return null;

            }

        }
        public static Users Login(string email, string password)
        {
            using (var db = new DB())
            {
                return db.Users.FirstOrDefault(u => u.E_mail == email && u.Password == password);


            }




        }

    }
}
