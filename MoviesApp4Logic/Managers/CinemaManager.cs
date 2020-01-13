using MoviesApp4Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp4Logic.Managers
{
    public class CinemaManager
    {
        public static Cinema Create(Cinema cinema)
        {
            using (var db = new DB())
            {
                cinema = db.Cinemas.Add(cinema);
                db.SaveChanges();
                return cinema;

            }


        }

        public static void Delete(int id)
        {
            using (var db = new DB())
            {
                db.Movies.RemoveRange(db.Movies.Where(m => m.CinemaId == id));
                db.Cinemas.Remove(db.Cinemas.Find(id));
                db.SaveChanges();

            }
        }

        public static Cinema Update(Cinema cinema)
        {
            using (var db = new DB())
            {

                var existing = db.Cinemas.Find(cinema.Id);
                existing.Adress = cinema.Adress;
                existing.Name = cinema.Name;
              

                db.SaveChanges();
                return existing;

            }
        }

        public static Cinema GetCinema(int id)
        {
            using (var db = new DB())
            {
                return db.Cinemas.Find(id);

            }

        }
        public static List<Cinema> GetCinemas ()
        {
            using (var db = new DB())
            {
                return db.Cinemas
                    .OrderBy(m => m.Name)
                    .ToList();
            }
        }

        public static int CountMovies(int cinemaId)
        {

            using (var db = new DB())
            {
                return db.Movies.Count(m => m.CinemaId == cinemaId);


            }



        }


    }
}
