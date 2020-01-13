using MoviesApp4Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp4Logic.Managers
{
/// <summary>
/// Filmu pārvaldnieks
/// </summary>
    public class MovieManager
    {
        /// <summary>
        /// Pilns filmu saraksts
        /// </summary>
        /// <returns>Saraksts ar filmām</returns>
        public static List<Movies> GetMovies()
        {
            using (var db = new DB())
            {
                return db.Movies.OrderBy(m => m.Name).ToList();
            }

        }
        /// <summary>
        /// Filmu atlase pēc kinoteātra
        /// </summary>
        /// <param name="cinemaId"></param>
        /// <returns> Saraksts ar filmām</returns>
        /// 
        public static List<Movies> GetMovies(int cinemaId)
        {
            using (var db = new DB())
            {
                return db.Movies.Where(m => m.CinemaId == cinemaId)
                    .OrderBy(m => m.Name)
                    .ToList();
            }
        }


        public static Movies GetMovie(int id)
        {
            using (var db = new DB())
            {
                return db.Movies.Find(id);

            }


        }



        /// <summary>
        /// Filmas dzēšana
        /// </summary>
        /// <param name="id">Filmas ID</param>
        public static void Delete(int id)
        {
            using (var db = new DB())
            {
                db.Movies.Remove(db.Movies.Find(id));
                db.SaveChanges();

            }

        }
        /// <summary>
        /// Izveido filmu
        /// </summary>
        /// <param name="movie">Filmas dati</param>
        /// <returns>Filmu</returns>
        public static Movies Create(Movies movie)
        {
            using (var db = new DB())
            {
                movie = db.Movies.Add(movie);
                db.SaveChanges();
                return movie;

            }
        }
        /// <summary>
        /// Atjauno filmas datus
        /// </summary>
        /// <param name="movie">Filmas dati</param>
        /// <returns>Filmu</returns>
        public static Movies Update(Movies movie)
        {
            using (var db = new DB())
            {
                var existing = db.Movies.Find(movie.Id);
                existing.Name = movie.Name;
                existing.Year = movie.Year;

                db.SaveChanges();
                return existing;

            }

        }




    }
}
