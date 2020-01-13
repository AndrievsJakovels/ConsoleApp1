﻿using MoviesApp4.Models;
using MoviesApp4Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesApp4.Controllers
{
    public class CinemaController : Controller 
    {
        [HttpGet]
        public ActionResult Index()
        {
            List<CinemaModel> cinemas = CinemaManager.GetCinemas().Select(c => CinemaModel.FromData(c)).ToList();
         
           
            return View(cinemas);
        }




        public ActionResult Edit(int? id)
        {
            CinemaModel cinema = null;
            // ja ID ir definēts -> tiek veikta rediģēšana
            if (id.HasValue)
            {
                cinema = CinemaModel.FromData(CinemaManager.GetCinema(id.Value));
                cinema.Movies = MovieManager.GetMovies(id.Value).Select(m => MovieModel.FromData(m)).ToList();

            }

            // citādi tiek veikta pievienošana
            else
            {
                cinema = new CinemaModel();

            }
            return View(cinema);
        }

        [HttpPost]
        public ActionResult Edit(CinemaModel cinema)
        {
            if (ModelState.IsValid)
            {
              
                    if (cinema.Id != 0)
                    {
                    CinemaManager.Update(cinema.ToData());

                    }
                    else
                    {
                    CinemaManager.Create(cinema.ToData());

                    }
 
                
            }
            return View(cinema);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            CinemaManager.Delete(id);

            return RedirectToAction("Index");
        }


    }
} 