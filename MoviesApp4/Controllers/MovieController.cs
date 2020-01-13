using MoviesApp4.Models;
using MoviesApp4Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesApp4.Controllers
{
    public class MovieController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            List<MovieModel> movies = new List<MovieModel>();
            movies = MovieManager.GetMovies().Select(m => MovieModel.FromData(m)).ToList();

            return View(movies);
        }


        [HttpGet]
        public ActionResult Edit(int? id, int cinemaId)
        {

            MovieModel movie = null;
            if (!id.HasValue)
            {
                movie = new MovieModel()
                {
                    CinemaId = cinemaId,
                };


            }
            else
            {
                movie = MovieModel.FromData(MovieManager.GetMovie(id.Value));



            }



            return View(movie);
        }

        [HttpPost]

        public ActionResult Edit(MovieModel model)
        {
            if (ModelState.IsValid)
            {
               
                    if (model.Id == 0)
                    {
                    MovieManager.Create(model.ToData());
                    }
                
                else
                {
                    MovieManager.Update(model.ToData());

                }
               

                // sūtam atpakaļ uz kino rediģēšanas formu
                return RedirectToAction("Edit", "Cinema", new { id = model.CinemaId });
            }



            return View(model);
        }



        [HttpGet]
        public ActionResult Delete(int id, int cinemaId)
        {

           MovieManager.Delete(id);

            return RedirectToAction("Edit", "Cinema", new { id = cinemaId});
           
        }
    }
}