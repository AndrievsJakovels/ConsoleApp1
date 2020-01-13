using MoviesApp4.Models;
using MoviesApp4Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesApp4.Controllers
{
    public class MainView2Controller : Controller
    {
       [HttpGet]
        public ActionResult Index(int? id)
        {
            FilmuModelis model = new FilmuModelis();

            model.Cinemas = CinemaManager.GetCinemas().Select(c => CinemaModel.FromData(c)).ToList();


            foreach (var cinema in model.Cinemas)
                {
                cinema.MovieCount = CinemaManager.CountMovies(cinema.Id);

            }


            if (id.HasValue)
            {
                model.Movies = MovieManager.GetMovies(id.Value).Select(m => MovieModel.FromData(m)).ToList();

            }
            else
            {
                model.Movies = new List<MovieModel>();
            }

                return View(model);
        }

        public ActionResult Movie(int id)
        {
            MovieReservationModel model = new MovieReservationModel();

            //1. Atlasīt filmas datus pēc Id

            model.Movie = MovieModel.FromData(MovieManager.GetMovie(id));


            //2. Atlasīt filmas seansu pēc filmas ID

            model.Sessions = MovieSessionManager.GetSessions(id).Select(s => MoviesSessionModel.FromData(s)).ToList();
            //3. Ielikt rezultātus modeli
            //4. Realizēt MOvie.cshtml failu - attēlot filmas datus un datus un sarakstu ar seansiem

            return View(model);
        }

        public ActionResult Buy(int id)
        {
            // seansa dati

            MoviesSessionModel session = MoviesSessionModel.FromData(MovieSessionManager.Get(id));

            // nolasām lietotaja sesijas datus un papildiām grozu ar izvēlēto seansu

            var basket = Session.Get().Basket;
            basket.Add(session);

            return RedirectToAction("Movie", new { id = session.MovieId });


        }



    }
}