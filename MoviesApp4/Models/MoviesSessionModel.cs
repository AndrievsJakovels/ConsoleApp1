using System;
using MoviesApp4.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesApp4.Models
{
    public class MoviesSessionModel
    {

        public int Id { get; set; }

        [StringLength(10)]
        public string Time { get; set; }

        [StringLength(10)]
        public string Price { get; set; }

        public int MovieId { get; set; }

             public MoviesApp4Logic.Database.Session ToData()
               {
                   return new MoviesApp4Logic.Database.Session()
                   {
                        Id = Id,
                       Time = Time,
                       Price = Price,
                       MovieId = MovieId,
                   };
               }
       

        public static MoviesSessionModel FromData(MoviesApp4Logic.Database.Session data)
        {
            return new MoviesSessionModel()
            {
                Id = data.Id,
                Time = data.Time,
                Price = data.Price,
                MovieId = data.MovieId,
            };
        }
    }
}