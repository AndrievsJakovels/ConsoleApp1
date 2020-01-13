using MoviesApp4Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp4Logic.Managers
{
    public class MovieSessionManager
    {
        public static Session Create(Session data)
        {
            using (var db = new DB())
            {
                data = db.Sessions.Add(data);
                db.SaveChanges();
                return data;

            }

        }

        public static void Delete(int id)
        {
            using (var db = new DB())
            {
                db.Sessions.Remove(db.Sessions.Find(id));
                db.SaveChanges();

            }

        }

        public static Session Update(Session data)
        {
            using (var db = new DB())
            {
                var existing = db.Sessions.Find(data.Id);
                existing.Time = data.Time;
                existing.Price = data.Price;

                db.SaveChanges();
                return existing;

            }
        }

        public static Session Get(int id)
        {
            using (var db = new DB())
            {
                return db.Sessions.Find(id);
            }

        }

        public static List<Session> GetSessions(int movieId)
        {
            using (var db = new DB())
            {
                return db.Sessions.Where (s => s.MovieId == movieId).ToList();
            }


        }




    }
}
