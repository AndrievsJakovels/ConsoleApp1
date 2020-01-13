
using MoviesApp4.Models;
using MoviesApp4Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class MovieSessionController : Controller
    {
        // GET: MovieSession
        public ActionResult Index(int movieId)
        {
            List<MoviesSessionModel> sessions = new List<MoviesSessionModel>();
            sessions = MovieSessionManager.GetSessions(movieId).Select(s => MoviesSessionModel.FromData(s)).ToList();
            return View(sessions);

        }
        [HttpGet]
        public ActionResult Edit(int? id, int movieId)
        {
            MoviesSessionModel session = null;
            if (id.HasValue)
            {
                session = MoviesSessionModel.FromData(MovieSessionManager.Get(id.Value));
            }
            else
            {
                session = new MoviesSessionModel();
                session.MovieId = movieId;
            }
            return View(session);
        }
        [HttpPost]
        public ActionResult Edit(MoviesSessionModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id != 0)
                {
                    MovieSessionManager.Update(model.ToData());
                }
                else
                {
                    MovieSessionManager.Create(model.ToData());
                }
            }
            return RedirectToAction("Edit", "Session", new { id = model.MovieId });
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            MovieSessionManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}